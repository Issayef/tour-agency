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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientBase form = new ClientBase();
            form.Show();
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
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatisticForm form = new StatisticForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
        }
    }
}
