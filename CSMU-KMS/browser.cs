using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMU_KMS
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
            //webBrowser1.Navigate("http://grd.csmu.edu.tw/kms/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://grd.csmu.edu.tw/kms/");
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
