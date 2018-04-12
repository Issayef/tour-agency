using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;


namespace tour_agency
{
    public partial class Contract : Form
    {

        private readonly string TemplateFileName = @"D:\Prilozhenie_1.docx";//путь к файлу
        private string spath = @"D:\"+"Dogovor"+ DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".docx";
        //private string spath = @"D:\" + "Dogovor"+".docx";


        public Contract()
        {
            InitializeComponent();
        }

        public void Information()
        {
            DateTime data = DateTime.Now;
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Svetunya\Desktop\Светкина учеба\Проект_КомРПО\БД\TouristAgency.mdf;Integrated Security=True;Connect Timeout=30";

            SqlCommand cmt = new SqlCommand();
            cmt.CommandType = CommandType.Text;
            cmt.CommandText = "Insert into contract_table (fio,contract_date, manager_id) Values('" + textBoxFIO.Text + "', '" + data + "', '" + ManagerTextBox.Text + "'); ";
            cmt.Connection = myCon;

            SqlCommand ps = new SqlCommand();
            ps.CommandType = CommandType.Text;
            ps.CommandText = "Insert into passport_inf (pas_numb, country_code, sex, country, date_of_issue, expriation_date, issued_by) Values('" + PassportNumberTextBox.Text + "', '" + textBoxCountryCode.Text + "', '" + SexTextBox.Text + "', '" + CountryTextBox.Text + "','" + DataVidachyTextBox.Text + "','" + textBoxExpDate.Text + "', '" + KemVidanTextBox.Text + "' ); ";
            ps.Connection = myCon;

            SqlCommand fl = new SqlCommand();
            fl.CommandType = CommandType.Text;
            fl.CommandText = "Insert into flight_inf (airoport_mov_name, airoport_arr_name, date_mov,time_mov, time_arr) Values('" + AirportDepTextBox.Text + "', '" + AirportArrTextBox.Text + "', '" + DateDepTextBox.Text + "', '" + TimeDepTextBox.Text + "','" + TimeArrTextBox.Text + "' ); ";
            fl.Connection = myCon;

            SqlCommand tu = new SqlCommand();
            tu.CommandType = CommandType.Text;
            tu.CommandText = "Insert into turist (FIO, date_of_birth, pasport_number, phone) Values('" + textBoxFIO.Text + "', '" + BirthTextBox.Text + "', '" + PassportNumberTextBox.Text + "', '" + PhoneTextBox.Text + "' ); ";
            tu.Connection = myCon;

            SqlCommand it = new SqlCommand();
            it.CommandType = CommandType.Text;
            it.CommandText = "Insert into tour_inf (date_of_moving, date_of_arrival, visit_country, visit_resort, hotel_stars, nutrion, number_of_adults, number_of_children, coastline) Values('" + TourBeginTextBox.Text + "', '" + TourEndTextBox.Text + "', '" + CountryTourTextBox.Text + "', '" + CityTextBox.Text + "', '" + HotelStarTextBox.Text + "', '" + FoodTextBox.Text + "', '" + textBoxAdults.Text + "', '" + textBoxChildren.Text + "', '" + CoastlineTextBox.Text + "');";
            it.Connection = myCon;

            myCon.Open();
            try
            {
                cmt.ExecuteNonQuery();
                ps.ExecuteNonQuery();
                fl.ExecuteNonQuery();
                tu.ExecuteNonQuery();
                it.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Сохранение прошло успешно.", "Сохранение", MessageBoxButtons.OK);
            }
            catch { DialogResult result = MessageBox.Show("Не удалось сохранить. Проверьте данные. Например: формат даты", "Сохранение", MessageBoxButtons.OK); }
            myCon.Close();
        }
       
        private void buttonSaveBD_Click(object sender, EventArgs e)
        {
            Information();
        }
             

        #region Метод замены ключевых слов на данные
        /// <summary>
        /// Метод замены ключевых слов на данные
        /// </summary>
        /// <param name="stubToReplace">Ключевые слова</param>
        /// <param name="text">Текст, который заменяет ключевые слова</param>
        /// <param name="wordDocument">Наш документ</param>
        private void ReplaceWordsStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;//перменная для хранения данных документа
            range.Find.ClearFormatting();//метод сброса всех натсроек текста
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);//находим ключевые слова и заменяем их
        }
        #endregion

        private void SaveWordButton_Click(object sender, EventArgs e)
        {
            #region Переменные для хранения данных
            var lastname = LastnameTextBox.Text;//фио 
            var firsttname = FirstnameTextBox.Text;//фио 
            var ottname = textBoxFIO.Text;//фио 
            var birthYear = BirthTextBox.Text;//дата рождения
            var sex = SexTextBox.Text;//пол
            var phone = PhoneTextBox.Text;//телефон
            var passportNumber = PassportNumberTextBox.Text;//номер паспорта
            var country = CountryTextBox.Text;//страна выдачи
            var data_vidachy = DataVidachyTextBox.Text;//дата выдачи паспорта
            var kem_vidan = KemVidanTextBox.Text;//орган выдачи

            var country_tour = CountryTourTextBox.Text;//фио 
            var city = CityTextBox.Text;//фио 
            var hotel = HotelTextBox.Text;//фио 
            var hotel_star = HotelStarTextBox.Text;//дата рождения
            var food = FoodTextBox.Text;//пол
            var coastline = CoastlineTextBox.Text;//телефон
            var tour_begin = TourBeginTextBox.Text;//номер паспорта
            var tour_end = TourEndTextBox.Text;//страна выдачи

            var airport_departure = AirportDepTextBox.Text;//дата рождения
            var airport_arrival = AirportArrTextBox.Text;//пол
            var date_departure = DateDepTextBox.Text;//телефон
            var time_departure = TimeDepTextBox.Text;//номер паспорта
            var time_arrival = TimeArrTextBox.Text;//номер паспорта
            var time_travel = TimeTravelTextBox.Text;//страна выдачи

            var manager = ManagerTextBox.Text;//страна выдачи

            var day = DateTime.Now.ToString("dd");
            var month = DateTime.Now.ToString("MM");
            var year = DateTime.Now.ToString("yyyy");
            #endregion

            var wordApp = new Word.Application();//переменная для word
            wordApp.Visible = false;//word скрыт
            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);//переменная для хранения нашего документа

                #region Вставка вмето специальных выражений в нашем файле
                ReplaceWordsStub("{lastname}", lastname, wordDocument);
                ReplaceWordsStub("{firsttname}", firsttname, wordDocument);
                ReplaceWordsStub("{ottname}", ottname, wordDocument);
                ReplaceWordsStub("{lastname}", lastname, wordDocument);
                ReplaceWordsStub("{firsttname}", firsttname, wordDocument);
                ReplaceWordsStub("{ottname}", ottname, wordDocument);
                ReplaceWordsStub("{birthYear}", birthYear, wordDocument);
                ReplaceWordsStub("{sex}", sex, wordDocument);
                ReplaceWordsStub("{phone}", phone, wordDocument);
                ReplaceWordsStub("{passportNumber}", passportNumber, wordDocument);
                ReplaceWordsStub("{country}", country, wordDocument);
                ReplaceWordsStub("{data_vidachy}", data_vidachy, wordDocument);
                ReplaceWordsStub("{kem_vidan}", kem_vidan, wordDocument);

                ReplaceWordsStub("{country_tour}", country_tour, wordDocument);
                ReplaceWordsStub("{city}", city, wordDocument);
                ReplaceWordsStub("{hotel}", hotel, wordDocument);
                ReplaceWordsStub("{hotel_star}", hotel_star, wordDocument);
                ReplaceWordsStub("{food}", food, wordDocument);
                ReplaceWordsStub("{coastline}", coastline, wordDocument);
                ReplaceWordsStub("{tour_begin}", tour_begin, wordDocument);
                ReplaceWordsStub("{tour_end}", tour_end, wordDocument);

                ReplaceWordsStub("{airport_departure}", airport_departure, wordDocument);
                ReplaceWordsStub("{airport_arrival}", airport_arrival, wordDocument);
                ReplaceWordsStub("{date_departure}", date_departure, wordDocument);
                ReplaceWordsStub("{time_departure}", time_departure, wordDocument);
                ReplaceWordsStub("{time_arrival}", time_arrival, wordDocument);
                ReplaceWordsStub("{time_travel}", time_travel, wordDocument);

                ReplaceWordsStub("{manager}", manager, wordDocument);
                ReplaceWordsStub("{dd}", day, wordDocument);
                ReplaceWordsStub("{mm}", month, wordDocument);
                ReplaceWordsStub("{yyyy}", year, wordDocument);
                #endregion

                wordDocument.SaveAs2(spath);//сохроняем наш документ
                wordDocument.Close();//закрываем документ
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!!!");//окно ошибки
            }
            finally
            {
                wordApp.Quit();//закрываем word
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menu = new MenuForm();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}