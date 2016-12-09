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
            ShowData(null);
        }
        private void ShowData(List<Dodaj_zlecenie> sd)
        {
            if(sd != null)
            {
                dataGridView1.DataSource = sd;
            }
            else 
            {
                using (Baza_zlecenEntities db = new Baza_zlecenEntities())
                {
                    dataGridView1.DataSource = db.Dodaj_zlecenie.ToList();
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (Baza_zlecenEntities db = new Baza_zlecenEntities())
            {
                this.ShowData(db.Dodaj_zlecenie.Where(dz => dz.Zleceniodawca.Contains( textBox2.Text)).Where(dz => dz.NumerKatalogowy.Contains(textBox3.Text)).Where(dz => dz.Nazwa.Contains(textBox4.Text)).Where(dz => dz.Opis.Contains(textBox5.Text)).Where(dz => dz.PrzewidywanyCzasPracy.Contains(textBox6.Text)).Where(dz => dz.DataRealizacjiKlient.Contains(textBox7.Text)).Where(dz => dz.DataRealizacjiFinalna.Contains(textBox8.Text)).ToList());
            }

        }
    }
}
