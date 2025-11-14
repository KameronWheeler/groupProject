using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupProject
{
    public partial class EditEvents : Form
    {
        public EditEvents()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserMenu userMenuForm = new UserMenu();
            userMenuForm.Show();
            this.Hide();
        }
    }
}
