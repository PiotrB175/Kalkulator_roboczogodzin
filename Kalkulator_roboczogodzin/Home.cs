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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Add Add = new Kalkulator_roboczogodzin.Add();
            Add.ShowDialog();
            this.Close();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Edit Edit = new Kalkulator_roboczogodzin.Edit();
            Edit.ShowDialog();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Delete Delete = new Kalkulator_roboczogodzin.Delete();
            Delete.ShowDialog();
            this.Close();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Show Show = new Kalkulator_roboczogodzin.Show();
            Show.ShowDialog();
            this.Close();
        }
    }
}
