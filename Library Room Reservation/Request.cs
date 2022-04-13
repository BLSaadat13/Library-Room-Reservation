using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Room_Reservation
{
    class Request
    {
        Controller ctrl = new Controller();
        private string newRoomId;
        private string newDT;
        private string oldRoomId;
        private string oldDT;
        private string studentId;
        private string reason;

        public string NewRoomId { get => newRoomId; set => newRoomId = value; }
        public string NewDT { get => newDT; set => newDT = value; }
        public string OldRoomId { get => oldRoomId; set => oldRoomId = value; }
        public string OldDT { get => oldDT; set => oldDT = value; }
        public string StudentId { get => studentId; set => studentId = value; }
        public string Reason { get => reason; set => reason = value; }

        public Request(string newRoomId, string newDT, string oldRoomId, string oldDT, string studentId, string reason)
        {
            this.newRoomId = newRoomId;
            this.newDT = newDT;
            this.oldRoomId = oldRoomId;
            this.oldDT = oldDT;
            this.studentId = studentId;
            this.reason = reason;
        }

        Request req = new Request(....);
        // req.createNewRequest();
        public int createNewRequest() // create a new change room request
        {
            SqlConnection con = ctrl.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO requestChange (oldRoomId, oldDT, newRoomId, newDT, studentId, reason, status) VALUES (@oldRoom,@oldDT, @newRoom, @newDT, @studentId, @reason, @status)", con);
            cmd.Parameters.AddWithValue("@oldRoom", OldRoomId);
            cmd.Parameters.AddWithValue("@studentId", StudentId);
            cmd.Parameters.AddWithValue("@oldDT", OldDT);
            cmd.Parameters.AddWithValue("@newRoom", NewRoomId);
            cmd.Parameters.AddWithValue("@newDT", NewDT);
            cmd.Parameters.AddWithValue("@reason", Reason);
            cmd.Parameters.AddWithValue("@status", "Pending");
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }


    }
}
