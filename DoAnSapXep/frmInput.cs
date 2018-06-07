using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnSapXep
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
            textBox2.Text = ThamSo.SoluongNodeLonNhat.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            label1.Focus();
            textBox2.GotFocus += TextBox2_GotFocus;
        }

        private void TextBox2_GotFocus(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
