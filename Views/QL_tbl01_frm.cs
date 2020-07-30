using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalMVC.Controllers;

namespace FinalMVC.Views
{
    public partial class QL_tbl01_frm : Form
    {

        Table01Controller controller = new Table01Controller();
        public QL_tbl01_frm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void QL_tbl01_frm_Load(object sender, EventArgs e)
        {
            // hien thi full on load
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;


            //load and fill data


            dataGridView1.DataSource = controller.GetAll();



        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
