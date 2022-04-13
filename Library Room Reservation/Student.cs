using System.Data.SqlClient;

namespace Library_Room_Reservation
{
    class Student
    {
        Controller ctrl = new Controller();
        private string studentId;
        private string studentName;
        private string studentEmail;
        private string studentPassword;

        public string StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentEmail { get => studentEmail; set => studentEmail = value; }
        public string StudentPassword { get => studentPassword; set => studentPassword = value; }

        public Student(string studentId, string studentName, string studentEmail, string studentPassword)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
            this.StudentEmail = studentEmail;
            this.StudentPassword = studentPassword;
        }

        public int addNewStudent() // create new student account
        {
            SqlConnection conn = ctrl.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO student (studentId, studentName, studentPassword, studentEmail) VALUES (@studentId, @studentName, @password, @email)", conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@studentName", studentName);
            cmd.Parameters.AddWithValue("@password", studentPassword);
            cmd.Parameters.AddWithValue("@email", studentEmail);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

    }
}
