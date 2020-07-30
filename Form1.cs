using FinalMVC.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void table01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.QL_tbl01_frm frm = new Views.QL_tbl01_frm();
            Utils.ShowFormInPanel(panel1, frm);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls[0].Width = panel1.Width;
                panel1.Controls[0].Height = panel1.Height;
            }
        }

        private void formTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.QL_test_frm frm = new Views.QL_test_frm();
            Utils.ShowFormInPanel(panel1, frm);
        }
    }
}
