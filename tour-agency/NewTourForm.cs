using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tour_agency
{
    public partial class NewTourForm : Form
    {
        public static string Bianaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\днс\Documents\учёба Биана\GitHub\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Alexconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\_курсач\БД\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Lenaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\пк\Documents\Lena\tour-agency\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Svetaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Svetunya\Desktop\Светкина учеба\Проект_КомРПО\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        //public static string Alexconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\_Git\tour-agency\tour-agency\TouristAgency.mdf;Integrated Security=True";
        public string conString = Alexconnection;

        public void SaveInformation()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            SqlCommand rvi = new SqlCommand();
            rvi.CommandType = CommandType.Text;       
            rvi.CommandText=
                "Insert into  Country (CountryName) " +
                "Values('" + CountryTextBox.Text + "'); ";

            rvi.Connection = myCon;
            myCon.Open();
            try
            {
                rvi.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Сохранение прошло успешно.", "Сохранение", MessageBoxButtons.OK);
            }
            catch { DialogResult result = MessageBox.Show("Не удалось сохранить", "Сохранение", MessageBoxButtons.OK); }
            myCon.Close();
        }
        public void SaveCity()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;

            SqlCommand select = new SqlCommand();
            select.CommandType = CommandType.Text;

            SqlCommand citycmd = new SqlCommand();
            citycmd.CommandType = CommandType.Text;

            select.CommandText = "Select CountryID FROM Country  Where CountryName LIKE '" + CountryTextBox.Text + "'";
            /*
            /*
             * rvi.CommandText = "Insert into  Review (ID_contract, ratingManager, ratingHotel," +
                " ratingFood, ratingFlight, ratingEx, Comment) " +
                "Values('" + textBoxContract.Text + "', '" 
                + Convert.ToInt32(comboBoxManager.Text) + "', '" 
                + Convert.ToInt32(comboBoxHotel.Text) + "', '" 
                + Convert.ToInt32(comboBoxFood.Text) + "', '" 
                + Convert.ToInt32(comboBoxFlight.Text) + "', '" 
                + Convert.ToInt32(comboBoxEx.Text) + "', '" 
                + richTextBoxReview.Text + "'); ";
            */
            select.Connection = myCon;
            citycmd.Connection = myCon;
            myCon.Open();



            var id = select.ExecuteScalar();
            citycmd.CommandText =
               "Insert into  City (CityName, CountryID) " +
               "Values('" + CityTextBox.Text + "', '" + id + "'); ";
            try
            {
                citycmd.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Сохранение прошло успешно.", "Сохранение", MessageBoxButtons.OK);
            }
            catch { DialogResult result = MessageBox.Show("Не удалось сохранить", "Сохранение", MessageBoxButtons.OK); }
            myCon.Close();
        }


        public NewTourForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveCity();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SaveCityButton.Hide();
            SaveButton.Show();
            button3.Hide();
            CityTextBox.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {  
            SaveCityButton.Show();
            SaveButton.Hide();
            button3.Hide();

            CityTextBox.Show();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();

            label2.Show();
            label3.Hide();
            label4.Hide();
            label5.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button3.Show();
            SaveCityButton.Hide();
            SaveButton.Hide();
            CityTextBox.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menu = new MenuForm();
            menu.Show();
        }
    }
}
