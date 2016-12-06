using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
        private void Add_Load(object sender, EventArgs e)
        {

        }
        
        private void add_button_Click(object sender, EventArgs e)
        {
            string zleceniodawca = textBox1.Text;
            string numerKatalogowy = textBox2.Text;
            string nazwa = textBox3.Text;
            string opis = textBox4.Text;
            string dataRealizacjiKlient = textBox5.Text;
            string przewidywanyCzasPracy = textBox6.Text;
            string dataRealizacjiFinalna = textBox7.Text;
            using (BazaZlecenModel db = new BazaZlecenModel())
            {
                Dodaj_zlecenie dodaj = new Dodaj_zlecenie()
                {
                    Zleceniodawca = zleceniodawca,
                    NumerKatalogowy = numerKatalogowy,
                    Nazwa = nazwa,
                    Opis = opis,
                    DataRealizacjiKlient = dataRealizacjiKlient,
                    PrzewidywanyCzasPracy = przewidywanyCzasPracy,
                    DataRealizacjiFinalna = dataRealizacjiFinalna
                };
                db.Dodaj_zlecenie.Add(dodaj);
                db.SaveChanges();
                MessageBox.Show("Dodano pomyślnie");
            }
        }
    }
}
