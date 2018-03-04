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
    public partial class ClientBase : Form
    {
        public ClientBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.Show();
        }
    }
}
