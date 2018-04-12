using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace DoAnSapXep
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ManHinh_label = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbYTuongThuaToan = new System.Windows.Forms.Label();
            this.lbHuy = new System.Windows.Forms.Label();
            this.lbKhoiTao = new System.Windows.Forms.Label();
            this.lbDieuKhien = new System.Windows.Forms.Label();
            this.lbThuatToan = new System.Windows.Forms.Label();
            this.lbSapXep = new System.Windows.Forms.Label();
            this.lbMangChuaSapXep = new System.Windows.Forms.Label();
            this.sapxepPanel = new System.Windows.Forms.Panel();
            this.lbTocDo = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chuasapxepPanel = new System.Windows.Forms.Panel();
            this.DebugPanel = new System.Windows.Forms.Panel();
            this.yTuongTextBox = new System.Windows.Forms.TextBox();
            this.thuattoanpanel = new System.Windows.Forms.Panel();
            this.insertionrdbtn = new System.Windows.Forms.RadioButton();
            this.mergerdbtn = new System.Windows.Forms.RadioButton();
            this.shellrdbtn = new System.Windows.Forms.RadioButton();
            this.quickrdbtn = new System.Windows.Forms.RadioButton();
            this.shakerrdbtn = new System.Windows.Forms.RadioButton();
            this.selectionrdbtn = new System.Windows.Forms.RadioButton();
            this.heaprdbtn = new System.Windows.Forms.RadioButton();
            this.bubblerdbtn = new System.Windows.Forms.RadioButton();
            this.binaryinsertionrdbtn = new System.Windows.Forms.RadioButton();
            this.interchangerdbtn = new System.Windows.Forms.RadioButton();
            this.Loaisapxeppanel = new System.Windows.Forms.Panel();
            this.giamrdbtn = new System.Windows.Forms.RadioButton();
            this.tangrdbtn = new System.Windows.Forms.RadioButton();
            this.HienThiPanel = new System.Windows.Forms.Panel();
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.dieukhienpanel = new System.Windows.Forms.Panel();
            this.huybnt = new System.Windows.Forms.Button();
            this.dungbtn = new System.Windows.Forms.Button();
            this.batdaubtn = new System.Windows.Forms.Button();
            this.khoitaopanel = new System.Windows.Forms.Panel();
            this.soluongNodetbx = new System.Windows.Forms.TextBox();
            this.nhaptaybtn = new System.Windows.Forms.Button();
            this.lbSoPhanTu = new System.Windows.Forms.Label();
            this.docfilebtn = new System.Windows.Forms.Button();
            this.venutbtn = new System.Windows.Forms.Button();
            this.taongaunhienbtn = new System.Windows.Forms.Button();
            this.huypanel = new System.Windows.Forms.Panel();
            this.huyqtbtn = new System.Windows.Forms.Button();
            this.xoamangbtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbNgonNgu = new System.Windows.Forms.Label();
            this.btnNgonNgu = new System.Windows.Forms.Button();
            this.sapxepPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.chuasapxepPanel.SuspendLayout();
            this.DebugPanel.SuspendLayout();
            this.thuattoanpanel.SuspendLayout();
            this.Loaisapxeppanel.SuspendLayout();
            this.HienThiPanel.SuspendLayout();
            this.dieukhienpanel.SuspendLayout();
            this.khoitaopanel.SuspendLayout();
            this.huypanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManHinh_label
            // 
            this.ManHinh_label.AutoSize = true;
            this.ManHinh_label.Location = new System.Drawing.Point(2, 10);
            this.ManHinh_label.Name = "ManHinh_label";
            this.ManHinh_label.Size = new System.Drawing.Size(53, 13);
            this.ManHinh_label.TabIndex = 2;
            this.ManHinh_label.Text = "Màn Hình";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(19, 8);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(54, 13);
            this.lbCode.TabIndex = 3;
            this.lbCode.Text = "Code C++";
            // 
            // lbYTuongThuaToan
            // 
            this.lbYTuongThuaToan.AutoSize = true;
            this.lbYTuongThuaToan.Location = new System.Drawing.Point(6, 8);
            this.lbYTuongThuaToan.Name = "lbYTuongThuaToan";
            this.lbYTuongThuaToan.Size = new System.Drawing.Size(95, 13);
            this.lbYTuongThuaToan.TabIndex = 11;
            this.lbYTuongThuaToan.Text = "Ý tưởng thuật toán";
            // 
            // lbHuy
            // 
            this.lbHuy.AutoSize = true;
            this.lbHuy.Location = new System.Drawing.Point(17, 6);
            this.lbHuy.Name = "lbHuy";
            this.lbHuy.Size = new System.Drawing.Size(26, 13);
            this.lbHuy.TabIndex = 12;
            this.lbHuy.Text = "Hủy";
            // 
            // lbKhoiTao
            // 
            this.lbKhoiTao.AutoSize = true;
            this.lbKhoiTao.Location = new System.Drawing.Point(17, 15);
            this.lbKhoiTao.Name = "lbKhoiTao";
            this.lbKhoiTao.Size = new System.Drawing.Size(50, 13);
            this.lbKhoiTao.TabIndex = 13;
            this.lbKhoiTao.Text = "Khởi Tạo";
            // 
            // lbDieuKhien
            // 
            this.lbDieuKhien.AutoSize = true;
            this.lbDieuKhien.Location = new System.Drawing.Point(17, 8);
            this.lbDieuKhien.Name = "lbDieuKhien";
            this.lbDieuKhien.Size = new System.Drawing.Size(59, 13);
            this.lbDieuKhien.TabIndex = 14;
            this.lbDieuKhien.Text = "Điều Khiển";
            // 
            // lbThuatToan
            // 
            this.lbThuatToan.AutoSize = true;
            this.lbThuatToan.Location = new System.Drawing.Point(8, 5);
            this.lbThuatToan.Name = "lbThuatToan";
            this.lbThuatToan.Size = new System.Drawing.Size(63, 13);
            this.lbThuatToan.TabIndex = 15;
            this.lbThuatToan.Text = "Thuật Toán";
            // 
            // lbSapXep
            // 
            this.lbSapXep.AutoSize = true;
            this.lbSapXep.Location = new System.Drawing.Point(18, 11);
            this.lbSapXep.Name = "lbSapXep";
            this.lbSapXep.Size = new System.Drawing.Size(48, 13);
            this.lbSapXep.TabIndex = 16;
            this.lbSapXep.Text = "Sắp Xếp";
            // 
            // lbMangChuaSapXep
            // 
            this.lbMangChuaSapXep.AutoSize = true;
            this.lbMangChuaSapXep.Location = new System.Drawing.Point(8, 14);
            this.lbMangChuaSapXep.Name = "lbMangChuaSapXep";
            this.lbMangChuaSapXep.Size = new System.Drawing.Size(101, 13);
            this.lbMangChuaSapXep.TabIndex = 17;
            this.lbMangChuaSapXep.Text = "Mảng chưa sắp xếp";
            // 
            // sapxepPanel
            // 
            this.sapxepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sapxepPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sapxepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sapxepPanel.Controls.Add(this.ManHinh_label);
            this.sapxepPanel.Location = new System.Drawing.Point(6, 12);
            this.sapxepPanel.Name = "sapxepPanel";
            this.sapxepPanel.Size = new System.Drawing.Size(1144, 290);
            this.sapxepPanel.TabIndex = 18;
            // 
            // lbTocDo
            // 
            this.lbTocDo.AutoSize = true;
            this.lbTocDo.Location = new System.Drawing.Point(249, 8);
            this.lbTocDo.Name = "lbTocDo";
            this.lbTocDo.Size = new System.Drawing.Size(42, 13);
            this.lbTocDo.TabIndex = 4;
            this.lbTocDo.Text = "Tốc độ";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(108, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(135, 32);
            this.trackBar1.TabIndex = 3;
            // 
            // chuasapxepPanel
            // 
            this.chuasapxepPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chuasapxepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chuasapxepPanel.Controls.Add(this.lbMangChuaSapXep);
            this.chuasapxepPanel.Location = new System.Drawing.Point(6, 308);
            this.chuasapxepPanel.Name = "chuasapxepPanel";
            this.chuasapxepPanel.Size = new System.Drawing.Size(1144, 41);
            this.chuasapxepPanel.TabIndex = 19;
            // 
            // DebugPanel
            // 
            this.DebugPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DebugPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DebugPanel.Controls.Add(this.yTuongTextBox);
            this.DebugPanel.Controls.Add(this.lbYTuongThuaToan);
            this.DebugPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugPanel.Location = new System.Drawing.Point(6, 515);
            this.DebugPanel.Name = "DebugPanel";
            this.DebugPanel.Size = new System.Drawing.Size(350, 135);
            this.DebugPanel.TabIndex = 20;
            // 
            // yTuongTextBox
            // 
            this.yTuongTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yTuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yTuongTextBox.Location = new System.Drawing.Point(5, 24);
            this.yTuongTextBox.Multiline = true;
            this.yTuongTextBox.Name = "yTuongTextBox";
            this.yTuongTextBox.ReadOnly = true;
            this.yTuongTextBox.Size = new System.Drawing.Size(340, 106);
            this.yTuongTextBox.TabIndex = 12;
            // 
            // thuattoanpanel
            // 
            this.thuattoanpanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thuattoanpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thuattoanpanel.Controls.Add(this.insertionrdbtn);
            this.thuattoanpanel.Controls.Add(this.mergerdbtn);
            this.thuattoanpanel.Controls.Add(this.shellrdbtn);
            this.thuattoanpanel.Controls.Add(this.quickrdbtn);
            this.thuattoanpanel.Controls.Add(this.shakerrdbtn);
            this.thuattoanpanel.Controls.Add(this.selectionrdbtn);
            this.thuattoanpanel.Controls.Add(this.heaprdbtn);
            this.thuattoanpanel.Controls.Add(this.bubblerdbtn);
            this.thuattoanpanel.Controls.Add(this.binaryinsertionrdbtn);
            this.thuattoanpanel.Controls.Add(this.interchangerdbtn);
            this.thuattoanpanel.Controls.Add(this.lbThuatToan);
            this.thuattoanpanel.Location = new System.Drawing.Point(6, 355);
            this.thuattoanpanel.Name = "thuattoanpanel";
            this.thuattoanpanel.Size = new System.Drawing.Size(255, 154);
            this.thuattoanpanel.TabIndex = 4;
            // 
            // insertionrdbtn
            // 
            this.insertionrdbtn.AutoSize = true;
            this.insertionrdbtn.Location = new System.Drawing.Point(147, 31);
            this.insertionrdbtn.Name = "insertionrdbtn";
            this.insertionrdbtn.Size = new System.Drawing.Size(85, 17);
            this.insertionrdbtn.TabIndex = 12;
            this.insertionrdbtn.Text = "Insertion sort";
            this.insertionrdbtn.UseVisualStyleBackColor = true;
            this.insertionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // mergerdbtn
            // 
            this.mergerdbtn.AutoSize = true;
            this.mergerdbtn.Location = new System.Drawing.Point(11, 123);
            this.mergerdbtn.Name = "mergerdbtn";
            this.mergerdbtn.Size = new System.Drawing.Size(75, 17);
            this.mergerdbtn.TabIndex = 21;
            this.mergerdbtn.Text = "Merge sort";
            this.mergerdbtn.UseVisualStyleBackColor = true;
            this.mergerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // shellrdbtn
            // 
            this.shellrdbtn.AutoSize = true;
            this.shellrdbtn.Location = new System.Drawing.Point(147, 123);
            this.shellrdbtn.Name = "shellrdbtn";
            this.shellrdbtn.Size = new System.Drawing.Size(68, 17);
            this.shellrdbtn.TabIndex = 20;
            this.shellrdbtn.Text = "Shell sort";
            this.shellrdbtn.UseVisualStyleBackColor = true;
            this.shellrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // quickrdbtn
            // 
            this.quickrdbtn.AutoSize = true;
            this.quickrdbtn.Location = new System.Drawing.Point(147, 100);
            this.quickrdbtn.Name = "quickrdbtn";
            this.quickrdbtn.Size = new System.Drawing.Size(73, 17);
            this.quickrdbtn.TabIndex = 19;
            this.quickrdbtn.Text = "Quick sort";
            this.quickrdbtn.UseVisualStyleBackColor = true;
            this.quickrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // shakerrdbtn
            // 
            this.shakerrdbtn.AutoSize = true;
            this.shakerrdbtn.Location = new System.Drawing.Point(147, 77);
            this.shakerrdbtn.Name = "shakerrdbtn";
            this.shakerrdbtn.Size = new System.Drawing.Size(79, 17);
            this.shakerrdbtn.TabIndex = 18;
            this.shakerrdbtn.Text = "Shaker sort";
            this.shakerrdbtn.UseVisualStyleBackColor = true;
            this.shakerrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // selectionrdbtn
            // 
            this.selectionrdbtn.AutoSize = true;
            this.selectionrdbtn.Location = new System.Drawing.Point(147, 54);
            this.selectionrdbtn.Name = "selectionrdbtn";
            this.selectionrdbtn.Size = new System.Drawing.Size(89, 17);
            this.selectionrdbtn.TabIndex = 17;
            this.selectionrdbtn.Text = "Selection sort";
            this.selectionrdbtn.UseVisualStyleBackColor = true;
            this.selectionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // heaprdbtn
            // 
            this.heaprdbtn.AutoSize = true;
            this.heaprdbtn.Location = new System.Drawing.Point(11, 100);
            this.heaprdbtn.Name = "heaprdbtn";
            this.heaprdbtn.Size = new System.Drawing.Size(71, 17);
            this.heaprdbtn.TabIndex = 12;
            this.heaprdbtn.Text = "Heap sort";
            this.heaprdbtn.UseVisualStyleBackColor = true;
            this.heaprdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // bubblerdbtn
            // 
            this.bubblerdbtn.AutoSize = true;
            this.bubblerdbtn.Location = new System.Drawing.Point(11, 77);
            this.bubblerdbtn.Name = "bubblerdbtn";
            this.bubblerdbtn.Size = new System.Drawing.Size(78, 17);
            this.bubblerdbtn.TabIndex = 16;
            this.bubblerdbtn.Text = "Bubble sort";
            this.bubblerdbtn.UseVisualStyleBackColor = true;
            this.bubblerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // binaryinsertionrdbtn
            // 
            this.binaryinsertionrdbtn.AutoSize = true;
            this.binaryinsertionrdbtn.Location = new System.Drawing.Point(11, 54);
            this.binaryinsertionrdbtn.Name = "binaryinsertionrdbtn";
            this.binaryinsertionrdbtn.Size = new System.Drawing.Size(116, 17);
            this.binaryinsertionrdbtn.TabIndex = 12;
            this.binaryinsertionrdbtn.Text = "Binary insertion sort";
            this.binaryinsertionrdbtn.UseVisualStyleBackColor = true;
            this.binaryinsertionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // interchangerdbtn
            // 
            this.interchangerdbtn.AutoSize = true;
            this.interchangerdbtn.Location = new System.Drawing.Point(11, 31);
            this.interchangerdbtn.Name = "interchangerdbtn";
            this.interchangerdbtn.Size = new System.Drawing.Size(102, 17);
            this.interchangerdbtn.TabIndex = 12;
            this.interchangerdbtn.Text = "Interchange sort";
            this.interchangerdbtn.UseVisualStyleBackColor = true;
            this.interchangerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // Loaisapxeppanel
            // 
            this.Loaisapxeppanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Loaisapxeppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loaisapxeppanel.Controls.Add(this.giamrdbtn);
            this.Loaisapxeppanel.Controls.Add(this.tangrdbtn);
            this.Loaisapxeppanel.Controls.Add(this.lbSapXep);
            this.Loaisapxeppanel.Location = new System.Drawing.Point(267, 355);
            this.Loaisapxeppanel.Name = "Loaisapxeppanel";
            this.Loaisapxeppanel.Size = new System.Drawing.Size(89, 87);
            this.Loaisapxeppanel.TabIndex = 21;
            // 
            // giamrdbtn
            // 
            this.giamrdbtn.AutoSize = true;
            this.giamrdbtn.Location = new System.Drawing.Point(21, 58);
            this.giamrdbtn.Name = "giamrdbtn";
            this.giamrdbtn.Size = new System.Drawing.Size(49, 17);
            this.giamrdbtn.TabIndex = 12;
            this.giamrdbtn.TabStop = true;
            this.giamrdbtn.Text = "Giảm";
            this.giamrdbtn.UseVisualStyleBackColor = true;
            this.giamrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // tangrdbtn
            // 
            this.tangrdbtn.AutoSize = true;
            this.tangrdbtn.Location = new System.Drawing.Point(21, 36);
            this.tangrdbtn.Name = "tangrdbtn";
            this.tangrdbtn.Size = new System.Drawing.Size(50, 17);
            this.tangrdbtn.TabIndex = 13;
            this.tangrdbtn.TabStop = true;
            this.tangrdbtn.Text = "Tăng";
            this.tangrdbtn.UseVisualStyleBackColor = true;
            this.tangrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // HienThiPanel
            // 
            this.HienThiPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HienThiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HienThiPanel.Controls.Add(this.codeListBox);
            this.HienThiPanel.Controls.Add(this.lbCode);
            this.HienThiPanel.Location = new System.Drawing.Point(362, 355);
            this.HienThiPanel.Name = "HienThiPanel";
            this.HienThiPanel.Size = new System.Drawing.Size(479, 295);
            this.HienThiPanel.TabIndex = 22;
            // 
            // codeListBox
            // 
            this.codeListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.Location = new System.Drawing.Point(3, 22);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.Size = new System.Drawing.Size(471, 264);
            this.codeListBox.TabIndex = 4;
            // 
            // dieukhienpanel
            // 
            this.dieukhienpanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dieukhienpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dieukhienpanel.Controls.Add(this.lbTocDo);
            this.dieukhienpanel.Controls.Add(this.huybnt);
            this.dieukhienpanel.Controls.Add(this.trackBar1);
            this.dieukhienpanel.Controls.Add(this.dungbtn);
            this.dieukhienpanel.Controls.Add(this.batdaubtn);
            this.dieukhienpanel.Controls.Add(this.lbDieuKhien);
            this.dieukhienpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dieukhienpanel.Location = new System.Drawing.Point(847, 355);
            this.dieukhienpanel.Name = "dieukhienpanel";
            this.dieukhienpanel.Size = new System.Drawing.Size(303, 87);
            this.dieukhienpanel.TabIndex = 23;
            // 
            // huybnt
            // 
            this.huybnt.Location = new System.Drawing.Point(200, 40);
            this.huybnt.Name = "huybnt";
            this.huybnt.Size = new System.Drawing.Size(75, 23);
            this.huybnt.TabIndex = 8;
            this.huybnt.Text = "Hủy";
            this.huybnt.UseVisualStyleBackColor = true;
            // 
            // dungbtn
            // 
            this.dungbtn.Location = new System.Drawing.Point(114, 40);
            this.dungbtn.Name = "dungbtn";
            this.dungbtn.Size = new System.Drawing.Size(75, 23);
            this.dungbtn.TabIndex = 9;
            this.dungbtn.Text = "Dừng";
            this.dungbtn.UseVisualStyleBackColor = true;
            // 
            // batdaubtn
            // 
            this.batdaubtn.Location = new System.Drawing.Point(28, 40);
            this.batdaubtn.Name = "batdaubtn";
            this.batdaubtn.Size = new System.Drawing.Size(75, 23);
            this.batdaubtn.TabIndex = 10;
            this.batdaubtn.Text = "Bắt đầu";
            this.batdaubtn.UseVisualStyleBackColor = true;
            // 
            // khoitaopanel
            // 
            this.khoitaopanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.khoitaopanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.khoitaopanel.Controls.Add(this.soluongNodetbx);
            this.khoitaopanel.Controls.Add(this.nhaptaybtn);
            this.khoitaopanel.Controls.Add(this.lbSoPhanTu);
            this.khoitaopanel.Controls.Add(this.docfilebtn);
            this.khoitaopanel.Controls.Add(this.venutbtn);
            this.khoitaopanel.Controls.Add(this.taongaunhienbtn);
            this.khoitaopanel.Controls.Add(this.lbKhoiTao);
            this.khoitaopanel.Location = new System.Drawing.Point(847, 448);
            this.khoitaopanel.Name = "khoitaopanel";
            this.khoitaopanel.Size = new System.Drawing.Size(303, 115);
            this.khoitaopanel.TabIndex = 24;
            // 
            // soluongNodetbx
            // 
            this.soluongNodetbx.Location = new System.Drawing.Point(165, 30);
            this.soluongNodetbx.Multiline = true;
            this.soluongNodetbx.Name = "soluongNodetbx";
            this.soluongNodetbx.Size = new System.Drawing.Size(41, 18);
            this.soluongNodetbx.TabIndex = 15;
            this.soluongNodetbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.soluongNodetbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nhaptaybtn
            // 
            this.nhaptaybtn.Location = new System.Drawing.Point(163, 84);
            this.nhaptaybtn.Name = "nhaptaybtn";
            this.nhaptaybtn.Size = new System.Drawing.Size(128, 24);
            this.nhaptaybtn.TabIndex = 6;
            this.nhaptaybtn.Text = "Nhập bằng tay";
            this.nhaptaybtn.UseVisualStyleBackColor = true;
            // 
            // lbSoPhanTu
            // 
            this.lbSoPhanTu.AutoSize = true;
            this.lbSoPhanTu.Location = new System.Drawing.Point(82, 30);
            this.lbSoPhanTu.Name = "lbSoPhanTu";
            this.lbSoPhanTu.Size = new System.Drawing.Size(59, 13);
            this.lbSoPhanTu.TabIndex = 14;
            this.lbSoPhanTu.Text = "Số phần tử";
            // 
            // docfilebtn
            // 
            this.docfilebtn.Location = new System.Drawing.Point(20, 86);
            this.docfilebtn.Name = "docfilebtn";
            this.docfilebtn.Size = new System.Drawing.Size(123, 24);
            this.docfilebtn.TabIndex = 4;
            this.docfilebtn.Text = "Đọc file";
            this.docfilebtn.UseVisualStyleBackColor = true;
            // 
            // venutbtn
            // 
            this.venutbtn.Location = new System.Drawing.Point(163, 54);
            this.venutbtn.Name = "venutbtn";
            this.venutbtn.Size = new System.Drawing.Size(128, 24);
            this.venutbtn.TabIndex = 5;
            this.venutbtn.Text = "Vẽ nút";
            this.venutbtn.UseVisualStyleBackColor = true;
            this.venutbtn.Click += new System.EventHandler(this.venutbtn_Click);
            // 
            // taongaunhienbtn
            // 
            this.taongaunhienbtn.Location = new System.Drawing.Point(20, 53);
            this.taongaunhienbtn.Name = "taongaunhienbtn";
            this.taongaunhienbtn.Size = new System.Drawing.Size(123, 24);
            this.taongaunhienbtn.TabIndex = 7;
            this.taongaunhienbtn.Text = "Ngẫu nhiên";
            this.taongaunhienbtn.UseVisualStyleBackColor = true;
            this.taongaunhienbtn.Click += new System.EventHandler(this.taongaunhienbtn_Click);
            // 
            // huypanel
            // 
            this.huypanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.huypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huypanel.Controls.Add(this.huyqtbtn);
            this.huypanel.Controls.Add(this.xoamangbtn);
            this.huypanel.Controls.Add(this.lbHuy);
            this.huypanel.Location = new System.Drawing.Point(847, 573);
            this.huypanel.Name = "huypanel";
            this.huypanel.Size = new System.Drawing.Size(303, 77);
            this.huypanel.TabIndex = 25;
            // 
            // huyqtbtn
            // 
            this.huyqtbtn.Location = new System.Drawing.Point(165, 36);
            this.huyqtbtn.Name = "huyqtbtn";
            this.huyqtbtn.Size = new System.Drawing.Size(128, 26);
            this.huyqtbtn.TabIndex = 14;
            this.huyqtbtn.Text = "Hủy quá trình";
            this.huyqtbtn.UseVisualStyleBackColor = true;
            this.huyqtbtn.Click += new System.EventHandler(this.huyqtbtn_Click);
            // 
            // xoamangbtn
            // 
            this.xoamangbtn.Location = new System.Drawing.Point(19, 36);
            this.xoamangbtn.Name = "xoamangbtn";
            this.xoamangbtn.Size = new System.Drawing.Size(122, 26);
            this.xoamangbtn.TabIndex = 15;
            this.xoamangbtn.Text = "Xóa mảng";
            this.xoamangbtn.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btnNgonNgu);
            this.panel10.Controls.Add(this.lbNgonNgu);
            this.panel10.Location = new System.Drawing.Point(267, 448);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(89, 61);
            this.panel10.TabIndex = 26;
            // 
            // lbNgonNgu
            // 
            this.lbNgonNgu.AutoSize = true;
            this.lbNgonNgu.Location = new System.Drawing.Point(14, 4);
            this.lbNgonNgu.Name = "lbNgonNgu";
            this.lbNgonNgu.Size = new System.Drawing.Size(56, 13);
            this.lbNgonNgu.TabIndex = 0;
            this.lbNgonNgu.Text = "Ngôn Ngữ";
            // 
            // btnNgonNgu
            // 
            this.btnNgonNgu.Location = new System.Drawing.Point(8, 24);
            this.btnNgonNgu.Name = "btnNgonNgu";
            this.btnNgonNgu.Size = new System.Drawing.Size(75, 23);
            this.btnNgonNgu.TabIndex = 1;
            this.btnNgonNgu.Text = "Tiếng Việt";
            this.btnNgonNgu.UseVisualStyleBackColor = true;
            this.btnNgonNgu.Click += new System.EventHandler(this.btnNgonNgu_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1162, 662);
            this.Controls.Add(this.thuattoanpanel);
            this.Controls.Add(this.DebugPanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.huypanel);
            this.Controls.Add(this.khoitaopanel);
            this.Controls.Add(this.dieukhienpanel);
            this.Controls.Add(this.HienThiPanel);
            this.Controls.Add(this.Loaisapxeppanel);
            this.Controls.Add(this.chuasapxepPanel);
            this.Controls.Add(this.sapxepPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀN MÔ PHỎNG THUẬT TOÁN SẮP XẾP v1.0";
            this.sapxepPanel.ResumeLayout(false);
            this.sapxepPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.chuasapxepPanel.ResumeLayout(false);
            this.chuasapxepPanel.PerformLayout();
            this.DebugPanel.ResumeLayout(false);
            this.DebugPanel.PerformLayout();
            this.thuattoanpanel.ResumeLayout(false);
            this.thuattoanpanel.PerformLayout();
            this.Loaisapxeppanel.ResumeLayout(false);
            this.Loaisapxeppanel.PerformLayout();
            this.HienThiPanel.ResumeLayout(false);
            this.HienThiPanel.PerformLayout();
            this.dieukhienpanel.ResumeLayout(false);
            this.dieukhienpanel.PerformLayout();
            this.khoitaopanel.ResumeLayout(false);
            this.khoitaopanel.PerformLayout();
            this.huypanel.ResumeLayout(false);
            this.huypanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ManHinh_label;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbYTuongThuaToan;
        private System.Windows.Forms.Label lbHuy;
        private System.Windows.Forms.Label lbKhoiTao;
        private System.Windows.Forms.Label lbDieuKhien;
        private System.Windows.Forms.Label lbThuatToan;
        private System.Windows.Forms.Label lbSapXep;
        private System.Windows.Forms.Label lbMangChuaSapXep;
        private System.Windows.Forms.Panel sapxepPanel;
        private System.Windows.Forms.Panel chuasapxepPanel;
        private System.Windows.Forms.Panel DebugPanel;
        private System.Windows.Forms.Panel thuattoanpanel;
        private System.Windows.Forms.RadioButton interchangerdbtn;
        private System.Windows.Forms.Panel Loaisapxeppanel;
        private System.Windows.Forms.Panel HienThiPanel;
        private System.Windows.Forms.Panel dieukhienpanel;
        private System.Windows.Forms.Panel khoitaopanel;
        private System.Windows.Forms.Panel huypanel;
        private System.Windows.Forms.RadioButton insertionrdbtn;
        private System.Windows.Forms.RadioButton mergerdbtn;
        private System.Windows.Forms.RadioButton shellrdbtn;
        private System.Windows.Forms.RadioButton quickrdbtn;
        private System.Windows.Forms.RadioButton shakerrdbtn;
        private System.Windows.Forms.RadioButton selectionrdbtn;
        private System.Windows.Forms.RadioButton heaprdbtn;
        private System.Windows.Forms.RadioButton bubblerdbtn;
        private System.Windows.Forms.RadioButton binaryinsertionrdbtn;
        private System.Windows.Forms.RadioButton giamrdbtn;
        private System.Windows.Forms.RadioButton tangrdbtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button huybnt;
        private System.Windows.Forms.Button dungbtn;
        private System.Windows.Forms.Button batdaubtn;
        private System.Windows.Forms.Label lbSoPhanTu;
        private System.Windows.Forms.Button docfilebtn;
        private System.Windows.Forms.Button venutbtn;
        private System.Windows.Forms.Button nhaptaybtn;
        private System.Windows.Forms.Button taongaunhienbtn;
        private System.Windows.Forms.Button huyqtbtn;
        private System.Windows.Forms.Button xoamangbtn;
        private System.Windows.Forms.TextBox soluongNodetbx;
        private System.Windows.Forms.Label lbTocDo;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private TextBox yTuongTextBox;
        private ListBox codeListBox;
        private Label lbNgonNgu;
        private Button btnNgonNgu;
    }
}

