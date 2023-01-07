using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_App
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainFrm = new mainForm();
            mainFrm.Closed += (s, args) => this.Close();
            mainFrm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Amir Mustafa Haji Sadeghian. \nFor Najafabad Azad University - Professor Shokoh Sadeghi", "Application developer information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
