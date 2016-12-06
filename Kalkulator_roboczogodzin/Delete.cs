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
    public partial class Delete : Form
    {
        public Delete()
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
    }
}
