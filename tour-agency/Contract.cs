using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            var ottname = OtnameTextBox.Text;//фио 
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

       
    }
}