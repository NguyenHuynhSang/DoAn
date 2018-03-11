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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Các biến toàn cục
        /// </summary>
        public bool isSapXepTang = true;
        public bool isDangChay = false;
        public int SoLuongNode =2;
        public List<int> DanhSachThamSo;
        public List<Button> DanhSachButton;
        Random rank = new Random();
        int a = 2;
       
        private void huyqtbtn_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Khi sự kiện text đã thay đổi kiểm tra xem slnodetbx có là rỗng hay không nếu rổng rán lại số lượng node=0 vì trường hợp người dùng
        /// đã nhập 1 giá trị ví dụ số 12 mà muốn đổi thành số 20, nếu không có điều kiện sẽ bị lỗi không thể chuyển ra kiểu int được
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
            if (soluongNodetbx.Text=="")
            {
                SoLuongNode = 0;
            }
            else
            {
                SoLuongNode = Int32.Parse(soluongNodetbx.Text);
            }
        }
        /// <summary>
        /// Bắt sự kiện keyPress chỉ cho phép nhập số vào tbx
        /// Char.IsDigit(e.KeyChar) kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không, hàm này trả về kiểu bool
        /// Char.IsContro(e.KeyChar) –> kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển(nếu k có nó sẽ bắt nút enter,delete... như là không phải là số)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)))
            {
            
                    MessageBox.Show("Số phần tử phải là số nguyên lớn hơn 2 và nhỏ hơn " + ThamSo.SoluongNodeLonNhat);
                    e.Handled = true;// dừng tất cả các tiến trình có liên quan đến thằng e
              
            }
        }

        private void taongaunhienbtn_Click(object sender, EventArgs e)
        {
           
            SoLuongNode = rank.Next(2,ThamSo.SoluongNodeLonNhat);
            VeNut();
        }

        private void HienThiPanel_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void venutbtn_Click(object sender, EventArgs e)
        {
            if (SoLuongNode<2||SoLuongNode>ThamSo.SoluongNodeLonNhat)
            {
                MessageBox.Show("Số lượng Node phải lớn hơn hoặc bằng 2 và nhỏ hơn "+ThamSo.SoluongNodeLonNhat);
                soluongNodetbx.Focus();
                return;
            }
            VeNut();
        }
        /// <summary>
        /// Khởi tạo 2 list 1 list int lưu giá trị dãy 1 list btn hiện thị trên GUI
        /// </summary>
        void VeNut()
        {
            DanhSachThamSo = new List<int>(SoLuongNode);
            DanhSachButton = new List<Button>(SoLuongNode);
            sapxepPanel.Controls.Clear(); // Xóa những btn cũ trên panel ở phiên làm việc
            int temp = -SoLuongNode / 2;
            int temp2 = ThamSo.KhoangCachCacNode / 2;
            int temp3 = temp + 1;
            Point newPoint;
            for (int i = 0; i < SoLuongNode; i++)
            {
                Button btn = new Button();
                int value = rank.Next(2, 100);
              
                btn.Text = value.ToString();
                btn.Width =btn.Height= ThamSo.KichCoNode;
                btn.BackColor = Color.Gray;
                if (SoLuongNode%2!=0)
                {
                    newPoint = new Point(sapxepPanel.Width / 2 - btn.Width / 2,
                                         sapxepPanel.Height / 2 - btn.Height / 2);
                    btn.Location =new Point(newPoint.X+temp*btn.Width+temp*ThamSo.KhoangCachCacNode,newPoint.Y);
                    temp++;
                }
                else
                {
                    if (i==SoLuongNode/2)
                    {
                        temp2 = -temp2;
                        temp3 = 0;
                    }
                    
                    newPoint = new Point(sapxepPanel.Width / 2 - btn.Width / 2 + ThamSo.KichCoNode / 2, sapxepPanel.Height / 2 - btn.Height / 2);
                    btn.Location = new Point(newPoint.X - temp2 + temp3 * ThamSo.KhoangCachCacNode+ temp *btn.Width,newPoint.Y);// Node Xuất hiện giữa panel
                    temp++;
                    temp3++;
                }
                
                btn.Enabled = false;
                sapxepPanel.Controls.Add(btn);
                DanhSachButton.Add(btn);
                DanhSachButton[i] = btn;
                DanhSachThamSo.Add(value);
            }
            
           

        }
        /// <summary>
        /// Phần kiểm thử làm rồi xóa sau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            Button btn1 = new Button();
            Button btn2 = new Button();
            //  Button btn3 = new Button();

            btn1.Width = btn1.Height = ThamSo.KichCoNode;
            btn2.Width = btn2.Height = ThamSo.KichCoNode;
            // btn3.Width = btn3.Height = ThamSo.KichCoNode;
            btn1.BackColor = btn2.BackColor = Color.Gray;
            Point center = new Point(sapxepPanel.Width / 2, sapxepPanel.Height / 2 - btn1.Height / 2);
            //  btn3.Location = center;
            btn1.Location = new Point(center.X - ThamSo.KhoangCachCacNode / 2 - ThamSo.KichCoNode, center.Y);
            btn2.Location = new Point((center.X + ThamSo.KhoangCachCacNode / 2), center.Y);
            sapxepPanel.Controls.Add(btn1);
            sapxepPanel.Controls.Add(btn2);
            //  sapxepPanel.Controls.Add(btn3);
            MessageBox.Show(btn1.Location + "    " + btn2.Location + ThamSo.KhoangCachCacNode);
        }

        private void sapxepPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
