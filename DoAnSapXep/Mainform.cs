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
using System.Reflection;
using System.Resources;
using System.Globalization;
using System.Drawing;
namespace DoAnSapXep
{
    public partial class    Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            bienArr = new Dictionary<string, Label>();
            List<string> bienArrString = new List<string>() { "i", "j", "min", "right", "left", "k", "pos", "m", "vt_x", "gap", "a:", "b:", "c:" };
            foreach (string item in bienArrString)
            {
                bienArr.Add(item, new Label());
            }
            foreach (var item in bienArr)
            {

                this.sapxepPanel.Controls.Add(item.Value);
                item.Value.TextAlign = ContentAlignment.MiddleCenter;
            }

            bienArr["i"].Size = bienArr["j"].Size = new Size(ThamSo.KichCoNode, 15);
        
            bienArr["i"].BackColor = bienArr["j"].BackColor = Color.Transparent;

            bienArr["min"].ForeColor = Color.LightGreen;
            bienArr["min"].Size = new Size(60, 20);
            bienArr["left"].ForeColor = Color.LightGreen;
            bienArr["left"].Size = new Size(60, 20);
            bienArr["right"].ForeColor = Color.IndianRed;
            bienArr["right"].Size = new Size(60, 20);
            bienArr["m"].ForeColor = bienArr["k"].ForeColor = Color.Coral;
            bienArr["m"].Size = bienArr["k"].Size = new Size(40, 15);
            bienArr["pos"].ForeColor = Color.Cornsilk;
            bienArr["pos"].Size = new Size(60, 20);
            bienArr["vt_x"].ForeColor = Color.Yellow;
            bienArr["vt_x"].Size = new Size(60, 20);
            bienArr["gap"].ForeColor = Color.LightGreen;
            bienArr["gap"].Size = new Size(60, 20);
            bienArr["a:"].ForeColor = bienArr["b:"].ForeColor = bienArr["c:"].ForeColor = Color.White;
            bienArr["a:"].Size = bienArr["b:"].Size = bienArr["c:"].Size = new Size(40, 15);

            culture = CultureInfo.CurrentCulture;

            Control.CheckForIllegalCrossThreadCalls = false;
            trackBar1.Maximum = ThamSo.ThoiGianDoi * 2;
            trackBar1.Minimum = 0;
            trackBar1.Value = ThamSo.ThoiGianDoi;
            trackBar1.LargeChange = 1;
        }

        /// <summary>
        /// Các biến toàn cục
        /// </summary>
        public static bool isEnglish = false;
        CultureInfo culture;

        public int loaiThuatToan;
        HienThiThuatToan HienThuattoan = new HienThiThuatToan();
        Thread thread;
        private bool isRunning = false;
        private bool isTang = true;
        private int SoLuongNode;
        public List<int> DanhSachThamSo;
        public List<Node> DanhSachNode;
        private List<Label> danhSachLabel;

        Random rank = new Random();
        private int Phut=0;
        private int Giay=0;

        //int a = 2;

        #region Biến i, j, k, pos,...

        private List<Node> nodeArr = new List<Node>();
        private List<Label> labelSTTArr = new List<Label>();
        private Dictionary<string, Label> bienArr;
        #endregion


        #region Set Ngôn Ngữ
        void setLang(string cultureName)
        {
            culture = new CultureInfo(cultureName);
            ResourceManager rm = new ResourceManager("DoAnSapXep.Lang.myResource", typeof(Mainform).Assembly);
            ManHinh_label.Text = rm.GetString("manhinh", culture);
            lbMangChuaSapXep.Text = rm.GetString("mangchuasapxep", culture);
            lbThuatToan.Text = rm.GetString("thuattoan", culture);
            lbSapXep.Text = rm.GetString("sapxep", culture);
            tangrdbtn.Text = rm.GetString("tang", culture);
            giamrdbtn.Text = rm.GetString("giam", culture);
            lbYTuongThuatToan.Text = rm.GetString("ytuongthuattoan", culture);
            lbDieuKhien.Text = rm.GetString("dieukhien", culture);
            lbTocDo.Text = rm.GetString("tocdo", culture);
            batdaubtn.Text = rm.GetString("batdau", culture);
            dungbtn.Text = rm.GetString("dung", culture);
            huybnt.Text = rm.GetString("huydieukhien", culture);
            lbKhoiTao.Text = rm.GetString("khoitao", culture);
            lbSoPhanTu.Text = rm.GetString("sophantu", culture);
            taongaunhienbtn.Text = rm.GetString("ngaunhien", culture);
            venutbtn.Text = rm.GetString("venut", culture);
            docfilebtn.Text = rm.GetString("docfile", culture);
            nhaptaybtn.Text = rm.GetString("nhapbangtay", culture);
            lbHuy.Text = rm.GetString("huyquatrinh", culture);
            xoamangbtn.Text = rm.GetString("xoamang", culture);
            huyqtbtn.Text = rm.GetString("huyquatrinh", culture);
            lbNgonNgu.Text = rm.GetString("ngonngu", culture);
            this.Text = rm.GetString("fname", culture);
        }


        #endregion

        #region Set English
        private void btnEn_Click(object sender, EventArgs e)
        {
            isEnglish = true;
            HienThiThuatToan.yTuongThuatToan.Clear();
            addIdea();
            setLang("en-US");
        }
        #endregion

        #region Set Tiếng Việt

        private void btnVi_Click(object sender, EventArgs e)
        {
            isEnglish = false;
            HienThiThuatToan.yTuongThuatToan.Clear();
            addYTuong();
            setLang("vi-VN");

        }
        #endregion



        // Cac thong so mac dinh khi form duoc tao ra
        private void Mainform_Load(object sender, EventArgs e)
        {
            VeNut();
            KhoiTaoMacDinh();
           
        }
        private void KhoiTaoMacDinh()
        {
            interchangerdbtn.Checked = true;
            tangrdbtn.Checked = true;
            soluongNodetbx.Text = "5";
            SoLuongNode = 5;
            VeNut();
            DieuChinhControls(isRunning);
        }
        private void DieuChinhControls(bool isRunning)
        {
            if (isRunning==true)
            {
                thuattoanpanel.Enabled = sapxepPanel.Enabled=khoitaopanel.Enabled=ngonngupanel.Enabled=batdaubtn.Enabled=Loaisapxeppanel.Enabled=false;
            }
            else
            {
                thuattoanpanel.Enabled = sapxepPanel.Enabled = khoitaopanel.Enabled = ngonngupanel.Enabled =batdaubtn.Enabled=Loaisapxeppanel.Enabled= true;

            }
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
            DanhSachNode = new List<Node>(SoLuongNode);
            danhSachLabel= new List<Label>(SoLuongNode);

            sapxepPanel.Controls.Clear(); // Xóa những btn cũ trên panel ở phiên làm việc
            int temp = -SoLuongNode / 2;
            int temp2 = ThamSo.KhoangCachCacNode / 2;
            int temp3 = temp + 1;
            Point newPoint;
            for (int i = 0; i < SoLuongNode; i++)
            {
                Label tam = new Label() { Text=i.ToString()};
                tam.Size = new Size(ThamSo.KichCoNode/2,ThamSo.KichCoNode/2);
                tam.Enabled = false;
                Node btn = new Node(i);
                int Value = rank.Next(2, 100);
                btn.Text = Value.ToString();
                btn.BackColor = Color.Honeydew;
                if (SoLuongNode % 2 != 0)
                {
                    newPoint = new Point(sapxepPanel.Width / 2 - btn.Width / 2,
                                         sapxepPanel.Height / 2 - btn.Height / 2);
                    btn.Location = new Point(newPoint.X + temp * btn.Width + temp * ThamSo.KhoangCachCacNode, newPoint.Y);
                    temp++;
                    tam.Location = new Point(btn.Location.X,btn.Location.Y+120);
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
                    tam.Location = new Point(btn.Location.X, btn.Location.Y + 120);
                    temp++;
                    temp3++;
                }
                sapxepPanel.Controls.Add(tam);
                sapxepPanel.Controls.Add(btn);
                DanhSachNode.Add(btn);
                DanhSachNode[i] = btn;
                DanhSachThamSo.Add(Value);
                danhSachLabel.Add(tam);

            }



        }

        private void radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                hienThiThuatToanNCodeC();
            }
            isTang = true;
        }
        #region Thêm ý tưởng vào yTuongTextBox
        private void addYTuong()
        {
            this.yTuongTextBox.Controls.Clear();
            this.yTuongTextBox.Text = HienThiThuatToan.yTuongVi;
        }
        private void addIdea()
        {
            this.yTuongTextBox.Controls.Clear();
            this.yTuongTextBox.Text = HienThiThuatToan.yTuongEn;
        }
        #endregion

        #region Hiển thị code c ++ và ý tưởng thuật toán
        private void hienThiThuatToanNCodeC()
        {
            if (isEnglish == true)
            {
                addIdea();
            }
            else
            {
                addYTuong();
            }
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
        #endregion


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
          
         isRunning = true;
         DieuChinhControls(isRunning);  
         Reset_CountTime();
         timer1.Start();
            
         backgroundWorker1.RunWorkerAsync(); // goi ham do work  

        }

        private void dungbtn_Click(object sender, EventArgs e)
        {
            isRunning = false;
            //TamDung();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DanhSachNode != null)
            {
                foreach (Node item in DanhSachNode)
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
        //    hoanVi1Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(DanhSachNode[vitriNodeA], vitriNodeB); });
        //    hoanVi2Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(DanhSachNode[vitriNodeB], vitriNodeA); });
        //    // note: Task.Factory.StartNew = THÊM task vào cuối hàng đợi và CHẠY ngay khi có thể

        //    Task.WaitAll(hoanVi1Task, hoanVi1Task);

        //    // Thay đổi vị trí của node trong mảng nodeArray
        //    if (DanhSachNode.Count != 0)                   //check xem nếu mảng còn tồn tại --> trong trường hợp mảng đã bị hủy
        //    {
        //        // Đổi màu 2 node sau khi sắp xếp
        //        Color tempColor = DanhSachNode[vitriNodeA].BackColor;
        //        DanhSachNode[vitriNodeA].BackColor = DanhSachNode[vitriNodeB].BackColor;//nodeArr[vitriNodeB].BackColor;
        //        DanhSachNode[vitriNodeB].BackColor = tempColor;

        //        TbxBtn t = DanhSachNode[vitriNodeA];
        //        DanhSachNode[vitriNodeA] = DanhSachNode[vitriNodeB];
        //        DanhSachNode[vitriNodeB] = t;
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
        //    TbxBtn temp = DanhSachNode[i];

        //    DanhSachNode[i] = DanhSachNode[j];
        //    DanhSachNode[j] = temp;
        //    //DanhSachNode[i].Location = new Point(DanhSachNode[j].X_vitri, sapxepPanel.Height / 2 - DanhSachNode[i].Height / 2);
        //    //DanhSachNode[j].Location = new Point(DanhSachNode[i].X_vitri, sapxepPanel.Height / 2 - DanhSachNode[j].Height / 2);
        //}

        #endregion

        #region Cac Ham cap nhat lai mang va Node
        private void CapNhatThamSo(int vt1,int vt2)
        {
            int temp = DanhSachThamSo[vt1];
            DanhSachThamSo[vt1] = DanhSachThamSo[vt2];
            DanhSachThamSo[vt2] = temp;

        }
        private void CapNhatDanhSachNode(int vt1,int vt2)
        {
            Node temp = DanhSachNode[vt1];
            DanhSachNode[vt1] = DanhSachNode[vt2];
            DanhSachNode[vt2]=temp;
        }
        #endregion

        #region Khung chuong trinh
        /// <summary>
        /// Su dung backgroundWalker de mo phong su di chuyen cua cac Node
        /// </summary>
        ///  Vi tri cua Node Dau tien<param name="vt1"></param>
        /// Vi tri Node tiep theo<param name="vt2"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Do work xu ly du lieu nhung khong the cap nhat len Gui
            // Ham dowork thuc hien xong goi ham complete
            HienThiThuatToan.ChayCodeC(1);
            if (interchangerdbtn.Checked == true)
            {
                InterchangeSort();
            }
            if (bubblerdbtn.Checked == true)
            {
                BubbleSort();
            }
            if (selectionrdbtn.Checked == true)
            {
                SelectionSort();
            }
            if (insertionrdbtn.Checked == true)
            {
                InsertionSort();
            }
            if (shakerrdbtn.Checked == true)
            {
                ShakerSort();
            }
            if (shellrdbtn.Checked == true)
            {
                ShellSort();
            }

        }
        private void DichuyenCacNode(int vt1, int vt2)
        {

            int Height = ThamSo.DoCaoDiChuyen + 10;
            int _width = Math.Abs(vt1 - vt2) * (ThamSo.KichCoNode + ThamSo.KhoangCachCacNode);
            status st = new status();
            st.vt1 = vt1;
            st.vt2 = vt2;

            st.Type = LoaiDiChuyen.Di_LEN_DI_XUONG;
            for (int i = 0; i < Height; i = i + 1)
            {
                // goiham progresschanged de cap nhat lai giao dien
                // Khi tao brackgroundworker nho set reportprogree la true k se bi 

                backgroundWorker1.ReportProgress(0, st);
                Thread.Sleep(ThamSo.ThoiGianDoi);
            }
            st.Type = LoaiDiChuyen.QUA_PHAI_QUA_TRAI;

            for (int i = 0; i < _width; i = i + 2)
            {


                backgroundWorker1.ReportProgress(0, st);
                Thread.Sleep(ThamSo.ThoiGianDoi);
            }
            st.Type = LoaiDiChuyen.DI_XUONG_DI_LEN;
            for (int i = 0; i < Height; i = i + 1)
            {

                backgroundWorker1.ReportProgress(0, st);
                Thread.Sleep(ThamSo.ThoiGianDoi);
            }
            st.Type = LoaiDiChuyen.DUNG;
            backgroundWorker1.ReportProgress(0, st);
            Thread.Sleep(ThamSo.ThoiGianDoi);
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            /// Cap nhat Gui sau do goi lai ham dowork
            status st = e.UserState as status;// lay gia tri st truyen vao ham trn
            if (st == null)
            {
                return;
            }
            if (st.Type == LoaiDiChuyen.DUNG)
            {
                DanhSachNode[st.vt1].BackColor = DanhSachNode[st.vt2].BackColor = Color.Honeydew;
                CapNhatDanhSachNode(st.vt2, st.vt1);

                return;

            }

            if (st.Type == LoaiDiChuyen.Di_LEN_DI_XUONG)
            {
                DanhSachNode[st.vt1].Location = new Point(DanhSachNode[st.vt1].Location.X, DanhSachNode[st.vt1].Location.Y + 1);
                DanhSachNode[st.vt2].Location = new Point(DanhSachNode[st.vt2].Location.X, DanhSachNode[st.vt2].Location.Y - 1);
            }

            if (st.Type == LoaiDiChuyen.QUA_PHAI_QUA_TRAI)
            {
                DanhSachNode[st.vt1].Location = new Point(DanhSachNode[st.vt1].Location.X - 2, DanhSachNode[st.vt1].Location.Y);
                DanhSachNode[st.vt2].Location = new Point(DanhSachNode[st.vt2].Location.X + 2, DanhSachNode[st.vt2].Location.Y);
            }

            if (st.Type == LoaiDiChuyen.DI_XUONG_DI_LEN)
            {
                DanhSachNode[st.vt1].Location = new Point(DanhSachNode[st.vt1].Location.X, DanhSachNode[st.vt1].Location.Y - 1);
                DanhSachNode[st.vt2].Location = new Point(DanhSachNode[st.vt2].Location.X, DanhSachNode[st.vt2].Location.Y + 1);
            }


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ///xong
            timer1.Stop();


            MessageBox.Show("Sắp xếp hoàn tất");
            isRunning = false;
            DieuChinhControls(isRunning);

        }
        #endregion
        private void Reset_CountTime()
        {

            Phut = Giay = 0;
            label11.Text = "00:00";
        }

        #region InterchangeSort
        private void InterchangeSort()
        {

            int i=0, j=0;
            bool flag;
           
            HienThiThuatToan.ChayCodeC(2);
            //status st = new status(); 
            for (i = 0; i < SoLuongNode - 1; i++)
            {
                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                bienArr["i"].Text = "i = " + i;
                sapxepPanel.Controls.Add(bienArr["i"]);
                HienThiThuatToan.ChayCodeC(3);
                for (j = i + 1; j < SoLuongNode; j++)
                {
                    bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 20);
                    bienArr["j"].Text = "j = " + j;
                    sapxepPanel.Controls.Add(bienArr["j"]);
                    HienThiThuatToan.ChayCodeC(4);
                    flag = false;
                    if (tangrdbtn.Checked==true)
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] < DanhSachThamSo[i]) flag = true;
                    }
                    if (giamrdbtn.Checked==true)
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] > DanhSachThamSo[i]) flag = true;
                    }
                    if (flag)
                    {
                        HienThiThuatToan.ChayCodeC(6);
                        Thread.Sleep(ThamSo.ThoiGianDoi);
                        DanhSachNode[i].BackColor = DanhSachNode[j].BackColor = Color.Green;
                        CapNhatThamSo(i, j);
                        DichuyenCacNode(j, i);
                    }
                }
            }
        } //xong
        #endregion
        #region SelectionSort
        private void SelectionSort()
        {
            
            int min, i=0, j=0;
            bool flag = false;
            

            HienThiThuatToan.ChayCodeC(2);
            for (i = 0; i < SoLuongNode - 1; i++)
            {
                
                HienThiThuatToan.ChayCodeC(3);
                HienThiThuatToan.ChayCodeC(5);
                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                bienArr["i"].Text = "i = " + i;
                sapxepPanel.Controls.Add(bienArr["i"]);
                for (j = i + 1; j < SoLuongNode; j++)
                {
                    HienThiThuatToan.ChayCodeC(6);
                    flag = false;
                    min = i;
                    bienArr["min"].Location = new Point(danhSachLabel[min].Location.X, danhSachLabel[min].Location.Y + 20);
                    bienArr["min"].Text = "min = " + min;
                    bienArr["min"].SendToBack();
                    sapxepPanel.Controls.Add(bienArr["min"]);
                    if (tangrdbtn.Checked == true)
                    {
                        
                        HienThiThuatToan.ChayCodeC(7);
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 20);
                        bienArr["j"].Text = "j = " + j;
                        sapxepPanel.Controls.Add(bienArr["j"]);
                        if (DanhSachThamSo[j] < DanhSachThamSo[min])
                        {
                            
                            min = j;
                            
                            flag = true;
                            bienArr["min"].Location = new Point(danhSachLabel[min].Location.X, danhSachLabel[min].Location.Y + 20);
                            bienArr["min"].Text = "min = " + min;
                            bienArr["min"].SendToBack();
                        }
                    }
                    if (giamrdbtn.Checked == true)
                    {
                        
                        HienThiThuatToan.ChayCodeC(7);
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 20);
                        bienArr["j"].Text = "j = " + j;
                        sapxepPanel.Controls.Add(bienArr["j"]);
                        if (DanhSachThamSo[j] > DanhSachThamSo[min])
                        {

                            min = j;
                            
                            flag = true;
                            bienArr["min"].Location = new Point(danhSachLabel[min].Location.X, danhSachLabel[min].Location.Y + 20);
                            bienArr["min"].Text = "min = " + min;
                            bienArr["min"].SendToBack();

                        }
                    }
                    if (flag == true)
                    {
                        HienThiThuatToan.ChayCodeC(8);
                        HienThiThuatToan.ChayCodeC(9);
                        Thread.Sleep(ThamSo.ThoiGianDoi);
                        DanhSachNode[i].BackColor = DanhSachNode[min].BackColor = Color.Green;
                        CapNhatThamSo(min, i);
                        DichuyenCacNode(min, i);
                    }
                }
            }
        }//xong
        #endregion
        #region BubbleSort
        private void BubbleSort()
        {
            int i, j;
            bool flag = false;
            HienThiThuatToan.ChayCodeC(2);
            HienThiThuatToan.ChayCodeC(3);
            for (i = 0; i < SoLuongNode - 1; i++)
            {
                HienThiThuatToan.ChayCodeC(4);
                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                bienArr["i"].Text = "i = " + i;
                sapxepPanel.Controls.Add(bienArr["i"]);
                for (j = SoLuongNode - 1; j > i; j--)
                {
                    flag = false;
                    if (tangrdbtn.Checked == true)
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] < DanhSachThamSo[j - 1]) flag = true;
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 20);
                        bienArr["j"].Text = "j = " + j;
                        sapxepPanel.Controls.Add(bienArr["j"]);
                    }
                    if (giamrdbtn.Checked == true)
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] > DanhSachThamSo[j - 1]) flag = true;
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 20);
                        bienArr["j"].Text = "j = " + j;
                        sapxepPanel.Controls.Add(bienArr["j"]);
                    }
                    if (flag == true)
                    {
                        HienThiThuatToan.ChayCodeC(6);
                        Thread.Sleep(ThamSo.ThoiGianDoi);
                        DanhSachNode[j].BackColor = DanhSachNode[j - 1].BackColor = Color.Green;
                        CapNhatThamSo(j, j - 1);
                        DichuyenCacNode(j, j - 1);
                    }

                }
            }
                        
        } //xong
        #endregion
        #region InsertionSort
        private void InsertionSort()
        {
            int pos, key;

            Node Nodetam;
            for (int i = 1; i < SoLuongNode ; i++)
            {
                key = DanhSachThamSo[i];
                Nodetam = DanhSachNode[i];
                pos = i - 1;
                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                bienArr["i"].Text = "i = " + i;
                sapxepPanel.Controls.Add(bienArr["i"]);
                DanhSachNode[i].ChuyenLen();
                bienArr["pos"].Location = new Point(danhSachLabel[pos].Location.X, danhSachLabel[pos].Location.Y - 20);
                bienArr["pos"].Text = "pos = " + pos;
                sapxepPanel.Controls.Add(bienArr["pos"]);
                if (tangrdbtn.Checked == true)
                {
                    while ((pos >= 0) && (DanhSachThamSo[pos] > key))
                    {
                        DanhSachNode[pos].ChuyenNgang(pos+1);
                        DanhSachNode[pos].vitriHienTai = pos + 1;                    
                        DanhSachNode[pos + 1] = DanhSachNode[pos];
                        DanhSachThamSo[pos+1]=DanhSachThamSo[pos];
                        HienThiThuatToan.ChayCodeC(10);
                        pos--;
                    }
              
                }
                else
                {
                    while ((pos >= 0) && (DanhSachThamSo[pos] < key))
                    {
                        DanhSachNode[pos].ChuyenNgang(pos + 1);
                        DanhSachNode[pos].vitriHienTai = pos + 1;
                        DanhSachNode[pos + 1] = DanhSachNode[pos];
                        DanhSachThamSo[pos + 1] = DanhSachThamSo[pos];
                        HienThiThuatToan.ChayCodeC(10);
                        pos--;
                    }
                }
                Nodetam.ChuyenNgang(pos+1);
                Nodetam.ChuyenXuong();
           
                DanhSachThamSo[pos + 1] = key;
                DanhSachNode[pos + 1] = Nodetam;
                Nodetam.vitriHienTai = pos + 1;
                
            }
        }//xong
        #endregion
        #region ShakerSort
        private void ShakerSort()
        {
            int i, j, left, right, k;
            left = 0;
            right = SoLuongNode - 1;
            k = SoLuongNode - 1;
            HienThiThuatToan.ChayCodeC(3);
            HienThiThuatToan.ChayCodeC(4);
            HienThiThuatToan.ChayCodeC(5);
            bienArr["left"].Location = new Point(danhSachLabel[left].Location.X, danhSachLabel[left].Location.Y-140 );
            bienArr["left"].Text = "left = " + left;
            bienArr["left"].Visible = true;
            bienArr["left"].SendToBack();
            sapxepPanel.Controls.Add(bienArr["left"]);
            bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y-140);
            bienArr["right"].Text = "right = " + right;
            bienArr["right"].Visible = true;
            bienArr["right"].SendToBack();
            sapxepPanel.Controls.Add(bienArr["right"]);
            bienArr["k"].Location = new Point(danhSachLabel[k].Location.X, danhSachLabel[k].Location.Y-10);
            bienArr["k"].Text = "k = " + k;
            bienArr["k"].Visible = true;
            bienArr["k"].SendToBack();
            sapxepPanel.Controls.Add(bienArr["k"]);
            while (left < right)
            {
                if (tangrdbtn.Checked == true)
                {
                    HienThiThuatToan.ChayCodeC(7);
                    for (i = right; i > left; i--)
                    {
                        HienThiThuatToan.ChayCodeC(8);
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 20);
                        bienArr["j"].Text = "j = " + j;
                        bienArr["j"].Visible = true;
                        bienArr["j"].SendToBack();
                        sapxepPanel.Controls.Add(bienArr["j"]);
                        if (DanhSachThamSo[i] < DanhSachThamSo[i - 1])
                        {
                            HienThiThuatToan.ChayCodeC(10);
                            Thread.Sleep(ThamSo.ThoiGianDoi);
                            DanhSachNode[i].BackColor = DanhSachNode[i - 1].BackColor = Color.Green;
                            CapNhatThamSo(i, i - 1);
                            DichuyenCacNode(i, i - 1);
                            k = i;
                            
                        }
                    }
                    left = k;
                    HienThiThuatToan.ChayCodeC(14);
                    for (j = left; j < right; j++)
                    {
                        HienThiThuatToan.ChayCodeC(15);
                        if (DanhSachThamSo[j] > DanhSachThamSo[j + 1])
                        {
                            HienThiThuatToan.ChayCodeC(17);
                            Thread.Sleep(ThamSo.ThoiGianDoi);
                            DanhSachNode[j + 1].BackColor = DanhSachNode[j].BackColor = Color.Green;
                            CapNhatThamSo(j + 1, j);
                            DichuyenCacNode(j + 1, j);
                            k = j;
                            bienArr["k"].Location = new Point(danhSachLabel[k].Location.X, danhSachLabel[k].Location.Y - 10);
                            bienArr["k"].Text = "k = " + k;
                        }
                    }
                    right = k;
                }
                if (giamrdbtn.Checked == true)
                {
                    HienThiThuatToan.ChayCodeC(7);
                    for (i = right; i > left; i--)
                    {
                        HienThiThuatToan.ChayCodeC(8);
                        if (DanhSachThamSo[i] > DanhSachThamSo[i - 1])
                        {
                            HienThiThuatToan.ChayCodeC(10);
                            Thread.Sleep(ThamSo.ThoiGianDoi);
                            DanhSachNode[i].BackColor = DanhSachNode[i - 1].BackColor = Color.Green;
                            CapNhatThamSo(i, i - 1);
                            DichuyenCacNode(i, i - 1);
                            k = i;
                        }
                    }
                    left = k;
                    
                    HienThiThuatToan.ChayCodeC(14);
                    bienArr["left"].Location = new Point(danhSachLabel[left].Location.X, danhSachLabel[left].Location.Y - 140);
                    bienArr["left"].Text = "left = " + left;
                    for (j = left; j < right; j++)
                    {
                        HienThiThuatToan.ChayCodeC(15);
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 20);
                        bienArr["j"].Text = "j = " + j;
                        if (DanhSachThamSo[j] < DanhSachThamSo[j + 1])
                        {
                            HienThiThuatToan.ChayCodeC(17);
                            Thread.Sleep(ThamSo.ThoiGianDoi);
                            DanhSachNode[j + 1].BackColor = DanhSachNode[j].BackColor = Color.Green;
                            CapNhatThamSo(j + 1, j);
                            DichuyenCacNode(j + 1, j);
                            k = j;
                            bienArr["k"].Location = new Point(danhSachLabel[k].Location.X, danhSachLabel[k].Location.Y - 10);
                            bienArr["k"].Text = "k = " + k;
                        }
                    }
                    right = k;
                }
            }

        } //xong
        #endregion
        #region ShellSort
        private void ShellSort()
        {
            HienThiThuatToan.ChayCodeC(1);
            for (int gap = SoLuongNode / 2; gap > 0; gap /= 2)
            {
                HienThiThuatToan.ChayCodeC(3);
                for (int i = gap; i < SoLuongNode; i++)
                {
                    HienThiThuatToan.ChayCodeC(5);
                    if (tangrdbtn.Checked == true)
                    {
                        HienThiThuatToan.ChayCodeC(7);
                        for (int j = i; j >= gap && DanhSachThamSo[j] < DanhSachThamSo[j - gap]; j -= gap)
                        {
                            HienThiThuatToan.ChayCodeC(9);
                            Thread.Sleep(ThamSo.ThoiGianDoi);
                            DanhSachNode[j].BackColor = DanhSachNode[j - gap].BackColor = Color.Green;
                            CapNhatThamSo(j, j - gap);
                            DichuyenCacNode(j, j - gap);
                        }
                    }
                    if (giamrdbtn.Checked == true)
                    {
                        HienThiThuatToan.ChayCodeC(7);
                        for (int j = i; j >= gap && DanhSachThamSo[j] > DanhSachThamSo[j - gap]; j -= gap)
                        {
                            HienThiThuatToan.ChayCodeC(9);
                            Thread.Sleep(ThamSo.ThoiGianDoi);
                            DanhSachNode[j].BackColor = DanhSachNode[j - gap].BackColor = Color.Green;
                            CapNhatThamSo(j, j - gap);
                            DichuyenCacNode(j, j - gap);
                        }
                    }
                }

            }
        } // xong
        #endregion

        //false
        #region Tạm dừng
        // Tạm dừng
        public static ManualResetEvent codeListBoxPauseStatus = new ManualResetEvent(true);
        public static bool CodeListBoxIsPause = false;
        /// <summary>
        /// bị False cmnr 
        /// </summary>
        void TamDung()
        {
            if (Node.IsPause)
            {
                Node.pauseStatus.Set();     // hàm để resume
                Node.IsPause = false;
                dungbtn.Text = "Tạm dừng";
                timer1.Start();
            }
            else
            {
                Node.pauseStatus.Reset();    // hàm để pause
                Node.IsPause = true;
                dungbtn.Text = "Tiếp tục";
                timer1.Stop();
            }
            if (CodeListBoxIsPause)
            {
                codeListBoxPauseStatus.Set();
                CodeListBoxIsPause = false;
                dungbtn.Text = "Tạm dừng";
                timer1.Start();
            }
            else
            {
                codeListBoxPauseStatus.Reset();
                CodeListBoxIsPause = true;
                dungbtn.Text = "Tiếp tục";
                timer1.Stop();
            }
        }
        #endregion

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
            foreach (Node item in DanhSachNode)
            {
                mystring = mystring + item.Text + item.Location.ToString() + ": ";
            }
            button2.Text = mystring;
        }


  
        private void lbDieuKhien_Click(object sender, EventArgs e)
        {

        }
        
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ThamSo.ThoiGianDoi = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
        }

    }
}
