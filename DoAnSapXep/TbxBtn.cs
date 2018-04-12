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
    public partial class    TbxBtn : UserControl
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
            tbx1.TextAlign = HorizontalAlignment.Center;
            this.Size = new Size(ThamSo.KichCoNode, ThamSo.KichCoNode);
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            btn1.BackColor = Color.Gray;
            tbx1.BackColor = Color.Gray;
            tbx1.AcceptsReturn = true;
            X_vitri = this.Location.X ;


        }
        public event EventHandler ValueChange;
        private int value = 0;
        private int x_vitri;
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

        public int X_vitri
        {
            get
            {
                return x_vitri;
            }

            set
            {
                this.x_vitri = value;
            }
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                btn1.Visible = false;
                tbx1.Text = btn1.Text;
                tbx1.SelectionStart = tbx1.Text.Length;// dat con tro chuot "cusor" qua ben phai neu so da co
                tbx1.BringToFront();
                tbx1.Focus();
                MessageBox.Show(x_vitri+"");
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
            if (tbx1.Text != "")
            {

                value = Int32.Parse(tbx1.Text);
            }

        }
        /// <summary>
        /// Các hàm di chuyển node;
        /// </summary>
        /// <param name="Node"></param>
        public  void ChuyenLen()
        {
            this.Location = new Point(this.Location.X,this.Location.Y-1);

        }
        public void ChuyenXuong()
        {
            this.Location = new Point(this.Location.X, this.Location.Y + 1);


        }
        public static void ChuyenNgang(TbxBtn Node1, TbxBtn Node2)
        { 
                Node1.Location = new Point(Node1.Location.X+1,Node1.Location.Y);
                Node2.Location = new Point(Node2.Location.X -1, Node2.Location.Y);

        }

        private void ChonDongListBox(int dong)
        {
            
        }
        private void TbxBtn_BackColorChanged(object sender, EventArgs e)
        {
            btn1.BackColor = this.BackColor;
        }

        private void TbxBtn_Load(object sender, EventArgs e)
        {
            x_vitri = this.Location.X;
        }
    }
}
