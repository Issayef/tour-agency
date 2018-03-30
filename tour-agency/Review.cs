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
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }
        public static string Bianaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\днс\Documents\учёба Биана\GitHub\tour-agency\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Alexconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\_курсач\БД\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Lenaconnection = "";
        public static string Svetaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Svetunya\Desktop\Светкина учеба\Проект_КомРПО\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";

        public string conString = Bianaconnection;

        public void SaveInformation()
        {
            DateTime data = DateTime.Now;
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;

            SqlCommand rvi = new SqlCommand();
            rvi.CommandType = CommandType.Text;
            rvi.CommandText = "Insert into  Review (ID_contract, ratingManager, ratingHotel, ratingFood, ratingFlight, ratingEx, Comment) Values('" + textBoxContract.Text + "', '" + Convert.ToInt32(comboBoxManager.Text) + "', '" + Convert.ToInt32(comboBoxHotel.Text) + "', '" + Convert.ToInt32(comboBoxFood.Text) + "', '" + Convert.ToInt32(comboBoxFlight.Text) + "', '" + Convert.ToInt32(comboBoxEx.Text) + "', '" + richTextBoxReview.Text + "'); ";
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveInformation();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
