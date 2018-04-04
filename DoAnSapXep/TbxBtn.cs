using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnSapXep
{
    public partial class TbxBtn : UserControl
    {
        public TbxBtn()
        {
            InitializeComponent();
            DatGiaTriMatDinh();
        }
        private void DatGiaTriMatDinh()
        {
            this.Width = this.Height = btn1.Width = btn1.Height = tbx1.Width = tbx1.Height = ThamSo.KichCoNode;
            tbx1.Location = this.Location;// neu 1 trong 3 thay doi vi tri thi tat ca deu thay doi theo
            btn1.Location = this.Location;
            this.Size = new Size(ThamSo.KichCoNode, ThamSo.KichCoNode);
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            btn1.BackColor = Color.Gray;
            tbx1.BackColor = Color.Gray;
            tbx1.AcceptsReturn = true;            

        }
        public event EventHandler ValueChange;
        private int value=0;

        public override string Text
        {
            get
            {
                return btn1.Text;
            }

            set
            {
                
                btn1.Text = value.ToString();
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks==2)
            {
                btn1.Visible = false;
                tbx1.Text = btn1.Text;
                tbx1.SelectionStart = tbx1.Text.Length;// dat con tro chuot "cusor" qua ben phai neu so da co
                tbx1.BringToFront();
                tbx1.Focus();
            }
        }

        private void tbx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        
        }

        private void tbx1_Enter(object sender, EventArgs e)
        {

        }

        private void tbx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                e.Handled = true;
                btn1.Text = value.ToString();
                btn1.Visible = true;
                btn1.BringToFront();
                btn1.Focus();
            }
           
        }

        private void tbx1_TextChanged(object sender, EventArgs e)
        {
            if (tbx1.Text!="")
            {
                
                value = Int32.Parse(tbx1.Text);
            }
         
        }
    }
}
