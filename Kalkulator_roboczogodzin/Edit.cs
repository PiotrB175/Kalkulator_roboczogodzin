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
        private void UpdateData()
        {
            using (Baza_zlecenEntities db = new Baza_zlecenEntities())
            {
                dataGridView1.DataSource = db.Dodaj_zlecenie.ToList();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int delete = (int)dataGridView1.Rows[0].Cells[0].Value;
            DeleteData(delete);
            MessageBox.Show("Rekord został usunięty");
            UpdateData();


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
    }
}
