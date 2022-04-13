using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Room_Reservation
{
    class Librarian
    {
        Controller ctrl = new Controller();
        private string librarianUsername;
        private string librarianPassword;

        public Librarian(string librarianUsername, string librarianPassword)
        {
            this.LibrarianUsername = librarianUsername;
            this.LibrarianPassword = librarianPassword;
        }

        public string LibrarianUsername { get => librarianUsername; set => librarianUsername = value; }
        public string LibrarianPassword { get => librarianPassword; set => librarianPassword = value; }

        public int addNewLibrarian() // create new librarian account
        {
            SqlConnection conn = ctrl.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO librarian (librarianUsername, librarianPassword) VALUES (@username,@password)", conn);
            cmd.Parameters.AddWithValue("@username", LibrarianUsername);
            cmd.Parameters.AddWithValue("@password", LibrarianPassword);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
