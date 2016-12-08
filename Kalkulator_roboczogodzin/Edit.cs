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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            using (Baza_zlecenEntities db = new Baza_zlecenEntities())
            {
                dataGridView1.DataSource = db.Dodaj_zlecenie.ToList();
            }
        }

        private void DeleteData(int id)
        {
            using (Baza_zlecenEntities db = new Baza_zlecenEntities())
            {
                Dodaj_zlecenie row = db.Dodaj_zlecenie.First(r => r.Id == id);
                db.Dodaj_zlecenie.Remove(row);
                db.SaveChanges();

            }
        }

        private void OverwriteData()
        {
            int row = (int)dataGridView1.CurrentCell.RowIndex;
            int id = (int)dataGridView1.Rows[row].Cells[0].Value;
            using (Baza_zlecenEntities db = new Baza_zlecenEntities())
            {
                Dodaj_zlecenie dodaj_zlecenie = db.Dodaj_zlecenie.First(r => r.Id == id);
                dodaj_zlecenie.Zleceniodawca = dataGridView1.Rows[row].Cells[1].Value.ToString();
                dodaj_zlecenie.NumerKatalogowy = dataGridView1.Rows[row].Cells[2].Value.ToString();
                dodaj_zlecenie.Nazwa = dataGridView1.Rows[row].Cells[3].Value.ToString();
                dodaj_zlecenie.Opis = dataGridView1.Rows[row].Cells[4].Value.ToString();
                dodaj_zlecenie.PrzewidywanyCzasPracy = dataGridView1.Rows[row].Cells[5].Value.ToString();
                dodaj_zlecenie.DataRealizacjiKlient = dataGridView1.Rows[row].Cells[6].Value.ToString();
                dodaj_zlecenie.DataRealizacjiFinalna = dataGridView1.Rows[row].Cells[7].Value.ToString();
                db.SaveChanges();
                MessageBox.Show("Nadpisano pomyślnie");
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home Return = new Kalkulator_roboczogodzin.Home();
            Return.ShowDialog();
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        
        private void delete_button_Click(object sender, EventArgs e)
        {
            int r = (int)dataGridView1.CurrentCell.RowIndex;
            int delete = (int)dataGridView1.Rows[r].Cells[0].Value;
            DeleteData(delete);
            MessageBox.Show("Rekord został usunięty");
            UpdateData();
        }

        private void overwrite_button_Click(object sender, EventArgs e)
        {
            OverwriteData();
        }
    }
}
