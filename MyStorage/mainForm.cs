using MyStorage.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStorage
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ShowFormAuthorization()
        {
            new AuthorizationForm().ShowDialog();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormAuthorization();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }
    }
}
