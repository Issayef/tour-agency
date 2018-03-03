using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tour_agency
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public string pas;
        public void Password(string login)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\днс\Documents\учёба Биана\GitHub\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
            string request = "Select Password From Registration Where Name = '" + login + "'";
            SqlCommand Command = new SqlCommand(request, Connection);
            Connection.Open();
            SqlDataReader Reader;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                FIO s2 = new FIO();
                s2.password = Reader["Password"].ToString();
                pas = s2.password;
            }
            Reader.Close();
            Connection.Close();
            if (pas == textBoxPassword.Text)
            {
                MenuForm form = new MenuForm();
                form.Show();
            }
            else { 
                labelError.Text = "Ошибка введенных данных";
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Password(textBoxLogin.Text);
        }

        class FIO
        {
            public string password;
        }
    }
}
