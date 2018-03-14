using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tour_agency
{
    public partial class TourBase : Form
    {
        public static string Bianaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\днс\Documents\учёба Биана\GitHub\tour-agency\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Alexconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\_курсач\БД\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Lenaconnection = "";
        public static string Svetaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Svetunya\Desktop\Светкина учеба\Проект_КомРПО\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";

        public string conString = Bianaconnection;

        public void CreateManager()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd = "Select name From managerinf Order by name";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Manager c = new Manager();
                c.name = myReader["name"].ToString();
                comboBoxManager.Items.Add(c.name);
            }
            myReader.Close();
            myCon.Close();
        }
        public void CreateTourist(string magname)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd = "Select fio From contract_table Where manager_id = (Select ID FROM managerinf WHERE name LIKE '" + magname + "') Order by fio";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Tourist c = new Tourist();
                c.touristname = myReader["fio"].ToString();
                comboBoxTourist.Items.Add(c.touristname);
            }
            myReader.Close();
            myCon.Close();
        }

            public void CreateContract(string fio)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd = "Select contract_id From contract_table Where fio LIKE '" + fio + "' ";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Contract c = new Contract();
                c.number = Convert.ToInt32(myReader["contract_id"].ToString());
                comboBoxContract.Items.Add(c.number);
            }
            myReader.Close();
            myCon.Close();
        }
            public void CreateStatus(int contract)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd = "Select status From status_classification Where status_id = (Select id_status FROM contract_table WHERE contract_id = '" + contract + "')";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Status c = new Status();
                c.status = myReader["status"].ToString();
                textBoxStatus.Text = c.status;
            }
            myReader.Close();
            myCon.Close();
        }
            
        public TourBase()
        {
            InitializeComponent();
            CreateManager();
        }
         private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTourist.Items.Clear();
            comboBoxTourist.Text = "";
            comboBoxContract.Items.Clear();
            comboBoxContract.Text = "";
            textBoxStatus.Text = "";
            CreateTourist(comboBoxManager.SelectedItem.ToString());
        }

        private void comboBoxTourist_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxContract.Items.Clear();
            comboBoxContract.Text = "";
            textBoxStatus.Text = "";
            CreateContract(comboBoxTourist.SelectedItem.ToString());
        }

        private void comboBoxContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxStatus.Text = "";
            CreateStatus(Convert.ToInt32(comboBoxContract.SelectedItem.ToString()));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
         

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        class Contract
        {
            public int number;
        }
    }
}
