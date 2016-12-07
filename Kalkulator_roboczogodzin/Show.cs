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
    public partial class Show : Form
    {
        public Show()
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

        private void Show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_zlecenDataSet.Dodaj_zlecenie' table. You can move, or remove it, as needed.
            this.dodaj_zlecenieTableAdapter.Fill(this.baza_zlecenDataSet.Dodaj_zlecenie);

            var context = new BazaZlecenModel();
            BindingSource bi = new BindingSource();
            bi.DataSource = context.Dodaj_zlecenie.ToList();
            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();

        }
    }
}
