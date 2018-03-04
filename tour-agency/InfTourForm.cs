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
    public partial class InfTourForm : Form
    {
        public static string Bianaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\днс\Documents\учёба Биана\GitHub\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Alexconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\_курсач\БД\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";
        public static string Lenaconnection = "";
        public static string Svetaconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Svetunya\Desktop\Светкина учеба\Проект_КомРПО\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";

        public string conString = Alexconnection;

        public void CreateCountry()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd;
            сmd = "Select CountryName From Country Order by CountryName";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Country c = new Country();
                c.countryname = myReader["CountryName"].ToString();
                comboBoxCountry.Items.Add(c.countryname);
            }
            myReader.Close();
            myCon.Close();
        }
        public void CreateCity(string coname)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd;
            сmd = "Select a.CityName From City a, Country b Where b.CountryName LIKE '" + coname + "' and a.CountryID=b.CountryID Order by a.CityName";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                City c = new City();
                c.cityname = myReader["CityName"].ToString();
                comboBoxCity.Items.Add(c.cityname);
            }
            myReader.Close();
            myCon.Close();
        }
        public void CreateHotel(string ciname, string cost)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd;
            сmd = "Select h.HotelName From HotelInfa h, City c Where c.CityName LIKE '" + ciname + "'and c.CityID=h.CityID and h.NightlyRate <= '" + cost + "' Order by h.HotelName";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Hotel h = new Hotel();
                h.hotelname = myReader["HotelName"].ToString();
                comboBoxHotel.Items.Add(h.hotelname);
            }
            myReader.Close();
            myCon.Close();
        }
        public void CreateHotelInf(string hname)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd;
            сmd = "Select HotDescription, NightlyRate  From HotelInfa Where HotelName LIKE '" + hname + "'";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Hotel h = new Hotel();
                h.information = myReader["HotDescription"].ToString();
                h.price = Convert.ToInt16(myReader["NightlyRate"].ToString());
                labelTextHotel.Text = h.information;
                listBoxCostHotel.Items.Add(h.price);
            }
            myReader.Close();
            myCon.Close();
        }

        public void CreateExcursion(string ciname)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd;
            сmd = "Select e.EksName From Excursion e, City c Where c.CityName LIKE '" + ciname + "'and c.CityID=e.CityID Order by e.EksName";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Excursion e = new Excursion();
                e.exname = myReader["EksName"].ToString();
                comboBoxEx.Items.Add(e.exname);
            }
            myReader.Close();
            myCon.Close();
        }
        public void CreateExInf(string ename)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = conString;
            string сmd;
            сmd = "Select EksPrice, EksDescription, EksTime_hours From Excursion Where EksName LIKE '" + ename + "'";
            SqlCommand myCommand = new SqlCommand(сmd, myCon);
            myCon.Open();
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Excursion e = new Excursion();
                e.exprice = Convert.ToInt16(myReader["EksPrice"].ToString());
                e.exdescription = myReader["EksDescription"].ToString();
                e.extime = Convert.ToInt16(myReader["EksTime_hours"].ToString());
                labelTextEx.Text = e.exdescription;
                listBoxCostEx.Items.Add(e.exprice);
                listBoxTimeEx.Items.Add(e.extime);
            }
            myReader.Close();
            myCon.Close();
        }
        public InfTourForm()
        {
            InitializeComponent();
            CreateCountry();
            labelTextHotel.Text = "";
        }
        public void RefreshCity()
        {
            labelTextHotel.Text = "";
            listBoxCostHotel.Items.Clear();
            comboBoxHotel.Text = "";
            comboBoxHotel.Items.Clear();
            comboBoxCity.Items.Clear();
            comboBoxCity.Text = "";
            labelTextEx.Text = " ";
            listBoxTimeEx.Items.Clear();
            listBoxCostEx.Items.Clear();
            comboBoxEx.Items.Clear();
            comboBoxEx.Text = "";
            CreateCity(comboBoxCountry.SelectedItem.ToString());
        }
        public void RefreshHotel()
        {
            labelTextHotel.Text = "";
            listBoxCostHotel.Items.Clear();
            comboBoxHotel.Items.Clear();
            comboBoxHotel.Text = "";
            comboCostBox.Text = "";
        }
        public void RefreshHotel_2()
        {
            labelTextHotel.Text = "";
            listBoxCostHotel.Items.Clear();
            comboBoxHotel.Items.Clear();
            comboBoxHotel.Text = "";
            CreateHotel(comboBoxCity.SelectedItem.ToString(), comboCostBox.SelectedItem.ToString());
        }
        public void RefreshHotelInf()
        {
            listBoxCostHotel.Items.Clear();
            CreateHotelInf(comboBoxHotel.SelectedItem.ToString());
        }

        public void RefreshEx()
        {
            labelTextEx.Text = " ";
            listBoxTimeEx.Items.Clear();
            listBoxCostEx.Items.Clear();
            comboBoxEx.Items.Clear();
            comboBoxEx.Text = "";
            CreateExcursion(comboBoxCity.SelectedItem.ToString());
        }
        public void RefreshExInf()
        {
            labelTextEx.Text = " ";
            listBoxTimeEx.Items.Clear();
            listBoxCostEx.Items.Clear();
            CreateExInf(comboBoxEx.SelectedItem.ToString());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCity();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshHotel();
            RefreshEx();
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshHotelInf();
        }

        private void comboBoxEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshExInf();
        }

        private void comboCostBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshHotel_2();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
