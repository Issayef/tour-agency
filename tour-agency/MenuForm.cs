using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_agency
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //нет формы надо добавить
            InfTourForm form = new InfTourForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientBase form = new ClientBase();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfTourForm form = new InfTourForm();
            form.Show();
            this.Hide();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
           Contract form = new Contract ();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatisticForm form = new StatisticForm();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            this.Hide();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Review review = new Review();
            this.Hide();
            review.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
