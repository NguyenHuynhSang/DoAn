using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

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

        private bool isRunning = false;
        private int SoLuongNode = 5;
        public List<int> DanhSachThamSo;
        public List<Node> DanhSachButton;
        Random rank = new Random();
        private int ThoiGianDoi=1;
        private int Phut=0;
        private int Giay=0;
        //int a = 2;


        // Cac thong so mac dinh khi form duoc tao ra
        private void Mainform_Load(object sender, EventArgs e)
        {
            VeNut();
            interchangerdbtn.Checked = true;
            tangrdbtn.Checked = true;
        }
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
            DanhSachButton = new List<Node>(SoLuongNode);
            sapxepPanel.Controls.Clear(); // Xóa những btn cũ trên panel ở phiên làm việc
            int temp = -SoLuongNode / 2;
            int temp2 = ThamSo.KhoangCachCacNode / 2;
            int temp3 = temp + 1;
            Point newPoint;
            for (int i = 0; i < SoLuongNode; i++)
            {
                Node btn = new Node(i);
                int value = rank.Next(2, 100);
                btn.Text = value.ToString();
                btn.BackColor = Color.Honeydew;
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
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
            timer1.Start();
            if (interchangerdbtn.Checked==true)
            {
                
                backgroundWorker1.RunWorkerAsync(); // goi ham do work  
            }
            if (bubblerdbtn.Checked==true)
            {
              //  backgroundWorker2.RunWorkerAsync();
            }
        }

        private void dungbtn_Click(object sender, EventArgs e)
        {
            isRunning = false;
            timer1.Stop() ;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DanhSachButton != null)
            {
                foreach (Node item in DanhSachButton)
                {
                    MessageBox.Show(item.Location.ToString()+item.X_vitri);
                }
            }
        }

        /// <summary>
        /// Thử dùng backgoundWalker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///  
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Do work xu ly du lieu nhung khong the cap nhat len Gui
            // Ham dowork thuc hien xong goi ham complete
            InterchangeSort();
        }
        /// <summary>
        /// Khu vuc bao tri 
        /// dang bi loi
        /// </summary>
        #region thu dung cach co san

        //Thread sortingThread;
        //Action hamSapXep;
        //public void BatDauSapXep()
        //{
          


        //    sortingThread = new Thread(new ThreadStart(hamSapXep));
        //    sortingThread.Start();

        //    // Dùng thread vì : có thể abort khi nào cần, task k làm đc
        //    // cả task và thread đều k thể tạo control và add vào trong thread khác --> dùng Invoke để giải quyết
        //}

        //public void DiChuyenNodeDen(object oNode, object oVitriMoi)  // public delegate void ParameterizedThreadStart(object obj);
        //{
        //    int vitriMoi = (int)oVitriMoi;
        //    TbxBtn node = (TbxBtn)oNode;
        //    if (vitriMoi > node.vitriHienTai)
        //    {
        //        node.ChuyenLen();
        //        node.ChuyenNgang(vitriMoi);
        //        node.ChuyenXuong();
        //    }
        //    else if (vitriMoi < node.vitriHienTai)
        //    {
        //        node.ChuyenXuong();
        //        node.ChuyenNgang(vitriMoi);
        //        node.ChuyenLen();
        //    }

        //    // Gán lại giá trị vị trí hiện tại
        //    node.vitriHienTai = vitriMoi;

        //    // Khi dùng thread thì dùng delegate Callback lại 
        //    //this.BeginInvoke(moveIsStopped);          // define: public Action moveIsStopped = null;

        //}

        //// Hoán vị chổ của 2 node
        //Task hoanVi1Task;
        //Task hoanVi2Task;
        //private void HoanVi2Node(int vitriNodeA, int vitriNodeB)
        //{
        //    // Cách dùng task
        //    hoanVi1Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(DanhSachButton[vitriNodeA], vitriNodeB); });
        //    hoanVi2Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(DanhSachButton[vitriNodeB], vitriNodeA); });
        //    // note: Task.Factory.StartNew = THÊM task vào cuối hàng đợi và CHẠY ngay khi có thể

        //    Task.WaitAll(hoanVi1Task, hoanVi1Task);

        //    // Thay đổi vị trí của node trong mảng nodeArray
        //    if (DanhSachButton.Count != 0)                   //check xem nếu mảng còn tồn tại --> trong trường hợp mảng đã bị hủy
        //    {
        //        // Đổi màu 2 node sau khi sắp xếp
        //        Color tempColor = DanhSachButton[vitriNodeA].BackColor;
        //        DanhSachButton[vitriNodeA].BackColor = DanhSachButton[vitriNodeB].BackColor;//nodeArr[vitriNodeB].BackColor;
        //        DanhSachButton[vitriNodeB].BackColor = tempColor;

        //        TbxBtn t = DanhSachButton[vitriNodeA];
        //        DanhSachButton[vitriNodeA] = DanhSachButton[vitriNodeB];
        //        DanhSachButton[vitriNodeB] = t;
        //    }

           

        //}
        //private void InterchangeSort()
        //{
            
            
           
        //    for (int i = 0; i < DanhSachThamSo.Count() - 1; i++)
        //    {
        //        for (int j = i + 1; j < DanhSachThamSo.Count(); j++)
        //        {
                  
                  
        //            if (DanhSachThamSo[j] < DanhSachThamSo[i])
        //            {

        //                HoanVi2Node(i, j);

        //            }

        //        }
        //    }
             
                   

                    
           
        //}

        //public void CapNhatDanhSachThamSo(int i,int j)
        //{
        //    int temp = DanhSachThamSo[i];
        //    DanhSachThamSo[i] = DanhSachThamSo[j];
        //    DanhSachThamSo[j] = temp;
        //}
        //public void CapNhatDanhSachNode(int i,int j)
        //{
        //    TbxBtn temp = DanhSachButton[i];
            
        //    DanhSachButton[i] = DanhSachButton[j];
        //    DanhSachButton[j] = temp;
        //    //DanhSachButton[i].Location = new Point(DanhSachButton[j].X_vitri, sapxepPanel.Height / 2 - DanhSachButton[i].Height / 2);
        //    //DanhSachButton[j].Location = new Point(DanhSachButton[i].X_vitri, sapxepPanel.Height / 2 - DanhSachButton[j].Height / 2);
        //}

        #endregion


        private void CapNhatThamSo(int vt1,int vt2)
        {
            int temp = DanhSachThamSo[vt1];
            DanhSachThamSo[vt1] = DanhSachThamSo[vt2];
            DanhSachThamSo[vt2] = temp;

        }
        private void CapNhatDanhSachNode(int vt1,int vt2)
        {
            Node temp = DanhSachButton[vt1];
            DanhSachButton[vt1] = DanhSachButton[vt2];
            DanhSachButton[vt2]=temp;
        }

        private void InterchangeSort()
        {

            int i, j;
           
            status st = new status(); 
            for (i = 0; i < SoLuongNode - 1; i++)
            {
                for (j = i + 1; j < SoLuongNode; j++)
                {
                 
                        if (DanhSachThamSo[j] < DanhSachThamSo[i])
                        {
                            Thread.Sleep(1);
                            DanhSachButton[i].BackColor = DanhSachButton[j].BackColor = Color.Green;
                            CapNhatThamSo(i, j);
                            DichuyeninterChangeSoft(j, i);
                           
                        }
                 

                }
            }
        }
        private int Height = ThamSo.DoCaoDiChuyen + 10;

        private void DichuyeninterChangeSoft(int vt1, int vt2)
        {
            status st = new status();
            st.vt1 = vt1;
            st.vt2 = vt2;
         
            st.Type = LoaiDiChuyen.Di_LEN_DI_XUONG;
            for (int i = 0  ; i < Height; i=i+2)
            {
                // goiham progresschanged de cap nhat lai giao dien
                // Khi tao brackgroundworker nho set reportprogree la true k se bi 
             
                backgroundWorker1.ReportProgress(0,st);
                Thread.Sleep(ThoiGianDoi);
            }
            st.Type = LoaiDiChuyen.QUA_PHAI_QUA_TRAI;
            int _width =Math.Abs(vt1-vt2)*(ThamSo.KichCoNode+ThamSo.KhoangCachCacNode);
            for (int i = 0; i < _width; i=i+2)
            {
             
               
                backgroundWorker1.ReportProgress(0, st);
                Thread.Sleep(ThoiGianDoi);
            }
            st.Type = LoaiDiChuyen.DI_XUONG_DI_LEN;
            for (int i = 0; i < Height; i=i+2)
            {
           
                backgroundWorker1.ReportProgress(0, st);
                Thread.Sleep(ThoiGianDoi);
            }
            st.Type = LoaiDiChuyen.DUNG;
            backgroundWorker1.ReportProgress(0, st);
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mystring= " ";
            foreach (int item in DanhSachThamSo)
            {

                mystring=mystring+ item.ToString()+" ";  
            }
            button1.Text = mystring;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mystring = "";
            foreach (Node item in DanhSachButton)
            {
                mystring = mystring + item.Text + item.Location.ToString() + ": ";
            }
            button2.Text = mystring;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            /// Cap nhat Gui sau do goi lai ham dowork
            status st = e.UserState as status;// lay gia tri st truyen vao ham trn
            if (st==null)
            {
                return;
            }
            if (st.Type==LoaiDiChuyen.DUNG)
            {
                DanhSachButton[st.vt1].BackColor = DanhSachButton[st.vt2].BackColor = Color.Honeydew;
                CapNhatDanhSachNode(st.vt2, st.vt1);
                return;
            }
           
            if (st.Type==LoaiDiChuyen.Di_LEN_DI_XUONG)
            {
                DanhSachButton[st.vt1].Location = new Point(DanhSachButton[st.vt1].Location.X,DanhSachButton[st.vt1].Location.Y+2);
                DanhSachButton[st.vt2].Location = new Point(DanhSachButton[st.vt2].Location.X, DanhSachButton[st.vt2].Location.Y - 2);
            }
            else
            {
                if (st.Type==LoaiDiChuyen.QUA_PHAI_QUA_TRAI)
                {
                    DanhSachButton[st.vt1].Location = new Point(DanhSachButton[st.vt1].Location.X-2, DanhSachButton[st.vt1].Location.Y);
                    DanhSachButton[st.vt2].Location = new Point(DanhSachButton[st.vt2].Location.X+2, DanhSachButton[st.vt2].Location.Y);
                }
                else
                {
                    if (st.Type==LoaiDiChuyen.DI_XUONG_DI_LEN)
                    {
                        DanhSachButton[st.vt1].Location = new Point(DanhSachButton[st.vt1].Location.X, DanhSachButton[st.vt1].Location.Y -2);
                        DanhSachButton[st.vt2].Location = new Point(DanhSachButton[st.vt2].Location.X, DanhSachButton[st.vt2].Location.Y +2);
                    }
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ///xong
            timer1.Stop();
            MessageBox.Show("sap xep hoan tat");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ThoiGianDoi = trackBar1.Value;
            label12.Text = trackBar1.Value.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

  

    
    }
}
