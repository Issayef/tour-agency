using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tour_agency
{
    public partial class ClientBase : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Svetunya\Desktop\Светкина учеба\Проект_КомРПО\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        string sql = "SELECT FIO, date_of_birth, phone, pasport_number FROM turist ORDER BY FIO";

        public ClientBase()
        {              
                InitializeComponent();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);

                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    
                }

            
                       }
                     
        
    private void button1_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.Show();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); 
            ds.Tables[0].Rows.Add(row);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            

            /*SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Svetunya\Desktop\Светкина учеба\Проект_КомРПО\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
            string request = "INSERT INTO turist(FIO, date_of_birth, phone, pasport_number) VALUES(@FIO, @date_of_birth, @phone, @pasport_number) ";
            SqlCommand Command = new SqlCommand(request, Connection);
            Connection.Open();
            SqlDataReader Reader;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
               
            }
            Reader.Close();
            Connection.Close();*/

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);                                     
                adapter.Update(ds);
            }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
