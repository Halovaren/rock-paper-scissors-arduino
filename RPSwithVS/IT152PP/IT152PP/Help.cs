using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT152PP
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void mmbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu form2 = new MainMenu();
            form2.Show();
        }
    }
}
