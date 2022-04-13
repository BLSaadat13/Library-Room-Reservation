using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Room_Reservation
{
    class Room
    {
        Controller ctrl = new Controller();
        private string roomName;
        private string roomCapacity;

        public Room(string roomName)
        {
            this.RoomName = roomName;
            this.RoomCapacity = roomCapacity;
        }

        public string RoomName { get => roomName; set => roomName = value; }
        public string RoomCapacity { get => roomCapacity; set => roomCapacity = value; }

        public int reserveRoom(string studentId, string dateTime) // reserve room, add a new row to the ReserveRoom table
        {
            SqlConnection conn = ctrl.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ReserveRoom (RoomID, Date, STUDENTID) VALUES (@Room,@Date, @STUDENTID)", conn);
            cmd.Parameters.AddWithValue("@Room", roomName);
            cmd.Parameters.AddWithValue("@STUDENTID", studentId);
            cmd.Parameters.AddWithValue("@Date", dateTime);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }



        public int cancelRoom(string dateTime) // cancel room
        {
            SqlConnection conn = ctrl.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ReserveRoom WHERE RoomID =@room AND Date =@datetime", conn); // remove row from ReserveRoom table
            cmd.Parameters.AddWithValue("@room", roomName);
            cmd.Parameters.AddWithValue("@datetime", dateTime);
            int status = cmd.ExecuteNonQuery();
            if (status > 0)
            {
                MessageBox.Show("Cancel room success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmd = new SqlCommand("DELETE FROM requestChange WHERE newRoomId = @room AND newDT = @datetime", conn); // remove the accepted change room request from requestChange table
            cmd.Parameters.AddWithValue("@room", roomName);
            cmd.Parameters.AddWithValue("@datetime", dateTime);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DELETE FROM requestChange WHERE oldRoomId = @room AND oldDT = @datetime", conn); // remove the rejected OR recently sent change room request from requestChange table
            cmd.Parameters.AddWithValue("@room", roomName);
            cmd.Parameters.AddWithValue("@datetime", dateTime);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public bool checkSpecificRoomAvailablity(string dateTime) // check if the student had sent a request to change room 
        {
            bool exist = false;
            SqlConnection conn = ctrl.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ReserveRoom WHERE Date = @datetime", conn);
            cmd.Parameters.AddWithValue("@datetime", dateTime);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                exist = true;
            }
            conn.Close();
            return exist;
        }
    }
}
