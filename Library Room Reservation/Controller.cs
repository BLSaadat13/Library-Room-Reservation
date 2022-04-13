using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Library_Room_Reservation
{
    class Controller
    {
        DateTime now = DateTime.Now;
        
        public SqlConnection getConnection() // set connection with database
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB Library Room Reservation.mdf;Integrated Security=True;Connect Timeout=30";
            return conn;
        }

        public string userLogin(string username, string password)
        {
            string user = "";
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM student WHERE studentId=@studentId AND studentPassword=@studentPassword", conn);
            cmd.Parameters.AddWithValue("@studentId", username);
            cmd.Parameters.AddWithValue("@studentPassword", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) // check if the username and password is from a student
            {
                user = "student";
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("Select * FROM librarian WHERE librarianUsername=@studentId AND librarianPassword=@studentPassword", conn);
                cmd.Parameters.AddWithValue("@studentId", username);
                cmd.Parameters.AddWithValue("@studentPassword", password);
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // check if the username and password is from a librarian
                {
                    user = "librarian";
                }
                else
                {
                    user = "invalid";
                }
            }
            conn.Close();
            return user;
        }

        public (string studentName, string studentPassword, string studentEmail, string room, string dateTime) getStudentDetailAndRoom(string studentId)
        {
            string studentName = ""; // get the student details and which room he/she reserved at what time
            string studentPassword = "";
            string studentEmail = "";
            string room = "None";
            string dateTime = "None";
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE studentId = @studentId", conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                studentName = dr["studentName"].ToString();
                studentPassword = dr["studentPassword"].ToString();
                studentEmail = dr["studentEmail"].ToString();
            }
            string sqlFormattedDate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            cmd = new SqlCommand("SELECT RoomID,Date from ReserveRoom WHERE STUDENTID = @studentId AND Date > @now", conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@now", sqlFormattedDate);
            dr.Close();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                room = dr[0].ToString();
                dateTime = dr[1].ToString();
            }
            conn.Close();
            return (studentName, studentPassword, studentEmail, room, dateTime);
        }

        public List<string> getAvailableRoomList(string dateTime) // get the list of rooms available at that particular time
        {
            List<string> roomList = new List<string>();
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomName FROM rooms WHERE roomName NOT IN (SELECT roomID FROM ReserveRoom WHERE Date = @dateTime)", conn);
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                roomList.Add(dr[0].ToString());
            }
            conn.Close();
            return roomList;
        }

        public bool checkRequestExist(string studentId) // check if the student had sent a request to change room 
        {
            removeExpiredRequest();
            bool exist = false;
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM requestChange WHERE studentId = @studentId", conn);
            cmd.Parameters.AddWithValue("@studentId", Login.studentId);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                exist = true;
            }
            conn.Close();
            return exist;
        }

        public bool checkReservationExist(string studentId) // check if the student had reserved a room at the time
        {
            bool exist = false;
            SqlConnection conn = getConnection();
            conn.Open();
            string sqlFormattedDate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            SqlCommand cmd = new SqlCommand("SELECT RoomID,Date FROM ReserveRoom WHERE STUDENTID = @studentID AND Date > @now", conn);
            cmd.Parameters.AddWithValue("@studentID", Login.studentId);
            cmd.Parameters.AddWithValue("@now", sqlFormattedDate);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                exist = true;
            }
            conn.Close();
            return exist;
        }

        public void removeExpiredRequest() // delete the rows from request table where the reservation date had passed
        {
            SqlConnection conn = getConnection();
            conn.Open();
            string sqlFormattedDate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            SqlCommand cmd = new SqlCommand("DELETE FROM requestChange WHERE oldDT < @now;", conn);
            cmd.Parameters.AddWithValue("@now", sqlFormattedDate);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public (string requestId, string oldRoomId, string oldDT, string newRoomId, string newDT, string status) studentGetRequestDetail(string studentId) // get the detail of the request that the particular student has sent
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM requestChange WHERE studentId =@studentId ORDER BY requestId DESC", conn);
            da.SelectCommand.Parameters.AddWithValue("@studentId", studentId);
            string requestId = "";
            string oldRoomId = "";
            string oldDT = "";
            string newRoomId = "";
            string newDT = "";
            string status = "";
            using (DataSet ds = new DataSet())
            {
                da.Fill(ds);
                requestId = ds.Tables[0].Rows[0]["requestId"].ToString();
                oldRoomId = ds.Tables[0].Rows[0]["oldRoomId"].ToString();
                oldDT = ds.Tables[0].Rows[0]["oldDT"].ToString();
                newRoomId = ds.Tables[0].Rows[0]["newRoomId"].ToString();
                newDT = ds.Tables[0].Rows[0]["newDT"].ToString();
                status = ds.Tables[0].Rows[0]["status"].ToString();
            }
            conn.Close();
            return (requestId, oldRoomId, oldDT, newRoomId, newDT, status);
        }

        public bool studentIdExist(string username) // check if the student ID existed in the database
        {
            bool exist = false;
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE studentId = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                exist = true;
            }
            conn.Close();
            return exist;
        }

        public bool librarianCheckRequestExist() // check if there is request not settled by the librarian
        {
            bool exist = false;
            SqlConnection conn = getConnection();
            conn.Open();
            removeExpiredRequest();
            SqlCommand cmd = new SqlCommand("SELECT * FROM requestChange WHERE status = 'Pending'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                exist = true;
            }
            conn.Close();
            return exist;
        }
        public int acceptRequest(string requestId, string oldRoomId, string oldDT, string newRoomId, string studentId, string newDT) // accept the request sent by student
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE requestChange SET status = 'Accepted' WHERE requestId = @requestId", conn); // change the status from pending to accepted
            cmd.Parameters.AddWithValue("@requestId", requestId);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("DELETE FROM ReserveRoom WHERE RoomID = @oldRoom AND Date = @oldDT", conn); // remove the old reservation from the ReserveRoom table
            cmd.Parameters.AddWithValue("@oldRoom", oldRoomId);
            cmd.Parameters.AddWithValue("@oldDT", oldDT);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO ReserveRoom (RoomID, Date, STUDENTID) VALUES (@Room,@Date, @STUDENTID)", conn); // Add a new reservation to ReserveRoom table
            cmd.Parameters.AddWithValue("@Room", newRoomId);
            cmd.Parameters.AddWithValue("@STUDENTID", studentId);
            cmd.Parameters.AddWithValue("@Date", newDT);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int rejectRequest(string id) // reject the request sent by student
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE requestChange SET status = 'Rejected' WHERE requestId = @requestId", conn); // change the status from pending to rejected
            cmd.Parameters.AddWithValue("@requestId", id);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public List<string> getRequestIdList() // get a list of request ID that is still havent been checked by the librarian
        {
            List<string> requestIdList = new List<string>();
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT requestId FROM requestChange WHERE status = 'Pending'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                requestIdList.Add(dr["requestId"].ToString());
            }
            dr.Close();
            conn.Close();
            return requestIdList;
        }

        public (string oldRoomId, string oldDT, string newRoomId, string newDT, string studentId, string reason) getRequestDetail(string id) // get the details of the particular request
        {
            SqlConnection conn = getConnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM requestChange WHERE requestId = @requestId", conn);
            da.SelectCommand.Parameters.AddWithValue("@requestId", id);
            da.Fill(ds);
            conn.Close();
            string newDT = ds.Tables[0].Rows[0]["newDT"].ToString();
            string oldDT = ds.Tables[0].Rows[0]["oldDT"].ToString();
            string newRoomId = ds.Tables[0].Rows[0]["newRoomId"].ToString();
            string oldRoomId = ds.Tables[0].Rows[0]["oldRoomId"].ToString();
            string studentId = ds.Tables[0].Rows[0]["studentId"].ToString();
            string reason = ds.Tables[0].Rows[0]["reason"].ToString();
            conn.Close();
            return (oldRoomId, oldDT, newRoomId, newDT, studentId, reason);
        }

        public int studentUpdateProfile(string studentId, string studentEmail, string studentPassword) // update the students' password and email in database
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE student SET studentEmail = @email, studentPassword = @password WHERE studentId = @studentId", conn);
            cmd.Parameters.AddWithValue("@email", studentEmail);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@password", studentPassword);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public (string librarianUsername, string librarianPassword) getLibrarianDetail(string librarianId) // get the librarian profile detail
        {
            string librarianPassword = "";
            SqlConnection conn = getConnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM librarian WHERE librarianUsername = '" + Login.librarianUsername + "'", conn);
            da.Fill(ds);
            librarianPassword = ds.Tables[0].Rows[0]["librarianPassword"].ToString();
            conn.Close();
            return (librarianId, librarianPassword);
        }
        public int librarianUpdateProfile(string librarianId, string librarianPassword) // update the librarian password
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE librarian SET librarianPassword = @password WHERE librarianUsername = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", librarianId);
            cmd.Parameters.AddWithValue("@password", librarianPassword);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public bool librarianUsernameExist(string username) // check if the librarian username exists in the database 
        {
            bool exist = false;
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM librarian WHERE librarianUsername = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                exist = true;
            }
            conn.Close();
            return exist;
        }


        public dsReservationReport getDataForDailyReport() // get the data from ReserveRoom table to be displayed at daily report
        {
            SqlConnection conn = getConnection();
            conn.Open();
            string sqlFormattedDate = DateTime.Today.ToString("yyyy-MM-dd");
            SqlDataAdapter da = new SqlDataAdapter("SELECT RoomID, STUDENTID, Date FROM ReserveRoom WHERE CONVERT(CHAR(10),Date) = @today ORDER BY Date", conn);
            da.SelectCommand.Parameters.AddWithValue("@today", sqlFormattedDate);
            dsReservationReport dsR = new dsReservationReport();
            da.Fill(dsR, "dtReservation");
            conn.Close();
            return dsR;
        }
        public dsReservationReport getDataForMonthlyReport(int monthIndex, int year) // get the data from ReserveRoom table to be displayed at monthly report
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT RoomID, STUDENTID, Date FROM ReserveRoom WHERE MONTH(Date)=@month AND YEAR(Date)=@year ORDER BY Date", conn);
            da.SelectCommand.Parameters.AddWithValue("@month", monthIndex);
            da.SelectCommand.Parameters.AddWithValue("@year", year);
            dsReservationReport dsR = new dsReservationReport();
            da.Fill(dsR, "dtReservation");
            conn.Close();
            return dsR;
        }
    }
}
