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
            ShowData();
        }
        private void ShowData()
        {
            using (Baza_zlecenEntities db = new Baza_zlecenEntities())
            {
                dataGridView1.DataSource = db.Dodaj_zlecenie.ToList();
            }
        }
    }
}
