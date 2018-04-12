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

        public int loaiThuatToan;
        HienThiThuatToan HienThuattoan = new HienThiThuatToan();

        public bool isRunning = false;
        public int SoLuongNode = 2;
        public List<int> DanhSachThamSo;
        public List<TbxBtn> DanhSachButton;
        Random rank = new Random();
        private int Phut;
        private int Giay;
        //int a = 2;

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

            if (soluongNodetbx.Text == "")
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

            SoLuongNode = rank.Next(2, ThamSo.SoluongNodeLonNhat);
            VeNut();
        }

        private void HienThiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void venutbtn_Click(object sender, EventArgs e)
        {
            if (SoLuongNode < 2 || SoLuongNode > ThamSo.SoluongNodeLonNhat)
            {
                MessageBox.Show("Số lượng Node phải lớn hơn hoặc bằng 2 và nhỏ hơn " + ThamSo.SoluongNodeLonNhat);
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
            DanhSachButton = new List<TbxBtn>(SoLuongNode);
            sapxepPanel.Controls.Clear(); // Xóa những btn cũ trên panel ở phiên làm việc
            int temp = -SoLuongNode / 2;
            int temp2 = ThamSo.KhoangCachCacNode / 2;
            int temp3 = temp + 1;
            Point newPoint;
            for (int i = 0; i < SoLuongNode; i++)
            {
                TbxBtn btn = new TbxBtn();
                int value = rank.Next(2, 100);

                btn.Text = value.ToString();
                btn.Width = btn.Height = ThamSo.KichCoNode;
                btn.BackColor = Color.Gray;
                if (SoLuongNode % 2 != 0)
                {
                    newPoint = new Point(sapxepPanel.Width / 2 - btn.Width / 2,
                                         sapxepPanel.Height / 2 - btn.Height / 2);
                    btn.Location = new Point(newPoint.X + temp * btn.Width + temp * ThamSo.KhoangCachCacNode, newPoint.Y);
                    temp++;
                }
                else
                {
                    if (i == SoLuongNode / 2)
                    {
                        temp2 = -temp2;
                        temp3 = 0;
                    }

                    newPoint = new Point(sapxepPanel.Width / 2 - btn.Width / 2 + ThamSo.KichCoNode / 2, sapxepPanel.Height / 2 - btn.Height / 2);
                    btn.Location = new Point(newPoint.X - temp2 + temp3 * ThamSo.KhoangCachCacNode + temp * btn.Width, newPoint.Y);// Node Xuất hiện giữa panel
                    temp++;
                    temp3++;
                }


                sapxepPanel.Controls.Add(btn);
                DanhSachButton.Add(btn);
                DanhSachButton[i] = btn;
                DanhSachThamSo.Add(value);
            }



        }

        private void radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                hienThiThuatToanNCodeC();
            }

        }
        private void hienThiThuatToanNCodeC()
        {
            //Gán yTuongTextBox, codeListBox và isSapXepTang
            HienThiThuatToan.yTuongThuatToan = yTuongTextBox;
            HienThiThuatToan.codeListBox = codeListBox;
            bool tang = tangrdbtn.Checked;
            //chọn sort
            if (selectionrdbtn.Checked)
            {
                HienThiThuatToan.SelectionSort(tang);

            }
            else if (insertionrdbtn.Checked)
            {
                HienThiThuatToan.InsertionSort(tang);
            }
            else if (shakerrdbtn.Checked)
            {
                HienThiThuatToan.ShakerSort(tang);
            }
            else if (quickrdbtn.Checked)
            {
                HienThiThuatToan.QuickSort(tang);
            }
            else if (shellrdbtn.Checked)
            {
                HienThiThuatToan.ShellSort(tang);
            }
            else if (interchangerdbtn.Checked)
            {
                HienThiThuatToan.InterchangeSort(tang);
            }
            else if (binaryinsertionrdbtn.Checked)
            {
                HienThiThuatToan.BinaryInsertionSort(tang);
            }
            else if (bubblerdbtn.Checked)
            {
                HienThiThuatToan.BubbleSort(tang);
            }
            else if (heaprdbtn.Checked)
            {
                HienThiThuatToan.HeapSort(tang);
            }
            else if (mergerdbtn.Checked)
            {
                HienThiThuatToan.MergeSort(tang);
            }

        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                timer1.Stop();

            }
            DemThoiGian();
        }

        private void DemThoiGian()
        {
            if (Giay > 59)
            {
                Giay = 0;
                Phut++;
            }
            Giay++;
            label11.Text = Phut + ":" + Giay;
        }
        void batdaubtn_Click(object sender, EventArgs e)
        {
            isRunning = true;
            timer1.Enabled = true;
            timer2.Start();
        }

        private void dungbtn_Click(object sender, EventArgs e)
        {
            isRunning = false;
            timer1.Stop();
            timer2.Stop();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (DanhSachButton != null)
            {
                foreach (TbxBtn item in DanhSachButton)
                {
                    MessageBox.Show(item.Location.ToString()+item.X_vitri);
                }
            }
        }
        private bool flag = true;
        private void SwapHaiNode(TbxBtn node1,TbxBtn node2,int vitrimoi)
        {
            
             int  temp = sapxepPanel.Height / 2 - node1.Height / 2 - ThamSo.DoCaoDiChuyen;
            
           
            if (node1.Location.Y>temp&& flag==true)
            {
                node1.BackColor = node2.BackColor = Color.Green;
                    node1.ChuyenLen();
                    node2.ChuyenXuong();
                
            }
            else
            {  
                    if (node1.Location.X < node2.X_vitri)
                    {
                        TbxBtn.ChuyenNgang(node1, node2);
                      
                    }
                    else
                    {
                    node2.ChuyenLen();
                    flag = false;
                    node1.ChuyenXuong();
                    if (node1.Location.X==node2.X_vitri && node1.Location.Y == (sapxepPanel.Height / 2 - node1.Height / 2))
                    {
                        timer2.Stop();
                        isRunning = false;
                        node1.BackColor = node2.BackColor = Color.Gray;
                    }
                        
                    }
                
            }
          
        }

        /// <summary>
        /// Thử dùng backgoundWalker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
            



        private void timer2_Tick(object sender, EventArgs e)
        {
            
            SwapHaiNode(DanhSachButton[0],DanhSachButton[1],2);
           
        }


        private void InterchangeSort(List<int> danhsach)
        {
            int i, j;
            for (i = 0; i < DanhSachThamSo.Count() - 1; i++)
                for (j = i + 1; j < DanhSachThamSo.Count(); j++)
                    if (DanhSachThamSo[j] < DanhSachThamSo[i]) ;
                       // Swap([i], DanhSachThamSo[j]);
        }







    }
}
