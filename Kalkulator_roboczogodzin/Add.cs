using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_roboczogodzin
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home Return = new Kalkulator_roboczogodzin.Home();
            Return.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Dodaj_zlecenie' table. You can move, or remove it, as needed.
            this.dodaj_zlecenieTableAdapter.Fill(this.appData.Dodaj_zlecenie);

        }

        private void save_button_Click(object sender, EventArgs e)
        {

        }
    }
}
