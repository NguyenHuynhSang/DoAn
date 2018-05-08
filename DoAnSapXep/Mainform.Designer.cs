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
            this.lbYTuongThuatToan = new System.Windows.Forms.Label();
            this.lbHuy = new System.Windows.Forms.Label();
            this.lbKhoiTao = new System.Windows.Forms.Label();
            this.lbDieuKhien = new System.Windows.Forms.Label();
            this.lbThuatToan = new System.Windows.Forms.Label();
            this.lbSapXep = new System.Windows.Forms.Label();
            this.lbMangChuaSapXep = new System.Windows.Forms.Label();
            this.sapxepPanel = new System.Windows.Forms.Panel();
            this.lbTocDo = new System.Windows.Forms.Label();
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
            this.dieukhienpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HienThiPanel = new System.Windows.Forms.Panel();
            this.ngonngupanel = new System.Windows.Forms.Panel();
            this.btnVi = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.lbNgonNgu = new System.Windows.Forms.Label();
            this.sapxepPanel.SuspendLayout();
            this.chuasapxepPanel.SuspendLayout();
            this.DebugPanel.SuspendLayout();
            this.thuattoanpanel.SuspendLayout();
            this.Loaisapxeppanel.SuspendLayout();
            this.dieukhienpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.khoitaopanel.SuspendLayout();
            this.huypanel.SuspendLayout();
            this.HienThiPanel.SuspendLayout();
            this.ngonngupanel.SuspendLayout();
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
            // lbYTuongThuatToan
            // 
            this.lbYTuongThuatToan.AutoSize = true;
            this.lbYTuongThuatToan.Location = new System.Drawing.Point(6, 8);
            this.lbYTuongThuatToan.Name = "lbYTuongThuatToan";
            this.lbYTuongThuatToan.Size = new System.Drawing.Size(95, 13);
            this.lbYTuongThuatToan.TabIndex = 11;
            this.lbYTuongThuatToan.Text = "Ý tưởng thuật toán";
            // 
            // lbHuy
            // 
            this.lbHuy.AutoSize = true;
            this.lbHuy.Location = new System.Drawing.Point(3, 4);
            this.lbHuy.Name = "lbHuy";
            this.lbHuy.Size = new System.Drawing.Size(26, 13);
            this.lbHuy.TabIndex = 12;
            this.lbHuy.Text = "Hủy";
            // 
            // lbKhoiTao
            // 
            this.lbKhoiTao.AutoSize = true;
            this.lbKhoiTao.Location = new System.Drawing.Point(3, 18);
            this.lbKhoiTao.Name = "lbKhoiTao";
            this.lbKhoiTao.Size = new System.Drawing.Size(50, 13);
            this.lbKhoiTao.TabIndex = 13;
            this.lbKhoiTao.Text = "Khởi Tạo";
            // 
            // lbDieuKhien
            // 
            this.lbDieuKhien.AutoSize = true;
            this.lbDieuKhien.Location = new System.Drawing.Point(3, 11);
            this.lbDieuKhien.Name = "lbDieuKhien";
            this.lbDieuKhien.Size = new System.Drawing.Size(59, 13);
            this.lbDieuKhien.TabIndex = 14;
            this.lbDieuKhien.Text = "Điều Khiển";
            this.lbDieuKhien.Click += new System.EventHandler(this.lbDieuKhien_Click);
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
            this.sapxepPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sapxepPanel.Controls.Add(this.ManHinh_label);
            this.sapxepPanel.Location = new System.Drawing.Point(6, 12);
            this.sapxepPanel.Name = "sapxepPanel";
            this.sapxepPanel.Size = new System.Drawing.Size(1144, 290);
            this.sapxepPanel.TabIndex = 18;
            // 
            // lbTocDo
            // 
            this.lbTocDo.AutoSize = true;
            this.lbTocDo.Location = new System.Drawing.Point(226, 39);
            this.lbTocDo.Name = "lbTocDo";
            this.lbTocDo.Size = new System.Drawing.Size(42, 13);
            this.lbTocDo.TabIndex = 4;
            this.lbTocDo.Text = "Tốc độ";
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
            this.DebugPanel.Controls.Add(this.lbYTuongThuatToan);
            this.DebugPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugPanel.Location = new System.Drawing.Point(6, 355);
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
            this.thuattoanpanel.Location = new System.Drawing.Point(6, 496);
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
            this.Loaisapxeppanel.Location = new System.Drawing.Point(267, 496);
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
            // dieukhienpanel
            // 
            this.dieukhienpanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dieukhienpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dieukhienpanel.Controls.Add(this.label1);
            this.dieukhienpanel.Controls.Add(this.trackBar1);
            this.dieukhienpanel.Controls.Add(this.label11);
            this.dieukhienpanel.Controls.Add(this.lbTocDo);
            this.dieukhienpanel.Controls.Add(this.huybnt);
            this.dieukhienpanel.Controls.Add(this.dungbtn);
            this.dieukhienpanel.Controls.Add(this.batdaubtn);
            this.dieukhienpanel.Controls.Add(this.lbDieuKhien);
            this.dieukhienpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dieukhienpanel.Location = new System.Drawing.Point(847, 355);
            this.dieukhienpanel.Name = "dieukhienpanel";
            this.dieukhienpanel.Size = new System.Drawing.Size(303, 116);
            this.dieukhienpanel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "5";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(85, 39);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(135, 32);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "00:00";
            // 
            // huybnt
            // 
            this.huybnt.Location = new System.Drawing.Point(216, 77);
            this.huybnt.Name = "huybnt";
            this.huybnt.Size = new System.Drawing.Size(75, 23);
            this.huybnt.TabIndex = 8;
            this.huybnt.Text = "Hủy";
            this.huybnt.UseVisualStyleBackColor = true;
            // 
            // dungbtn
            // 
            this.dungbtn.Location = new System.Drawing.Point(118, 77);
            this.dungbtn.Name = "dungbtn";
            this.dungbtn.Size = new System.Drawing.Size(75, 23);
            this.dungbtn.TabIndex = 9;
            this.dungbtn.Text = "Dừng";
            this.dungbtn.UseVisualStyleBackColor = true;
            this.dungbtn.Click += new System.EventHandler(this.dungbtn_Click);
            // 
            // batdaubtn
            // 
            this.batdaubtn.Location = new System.Drawing.Point(20, 77);
            this.batdaubtn.Name = "batdaubtn";
            this.batdaubtn.Size = new System.Drawing.Size(75, 23);
            this.batdaubtn.TabIndex = 10;
            this.batdaubtn.Text = "Bắt đầu";
            this.batdaubtn.UseVisualStyleBackColor = true;
            this.batdaubtn.Click += new System.EventHandler(this.batdaubtn_Click);
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
            this.khoitaopanel.Location = new System.Drawing.Point(847, 477);
            this.khoitaopanel.Name = "khoitaopanel";
            this.khoitaopanel.Size = new System.Drawing.Size(303, 115);
            this.khoitaopanel.TabIndex = 24;
            this.khoitaopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.khoitaopanel_Paint);
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
            this.huypanel.Location = new System.Drawing.Point(847, 598);
            this.huypanel.Name = "huypanel";
            this.huypanel.Size = new System.Drawing.Size(171, 52);
            this.huypanel.TabIndex = 25;
            // 
            // huyqtbtn
            // 
            this.huyqtbtn.Location = new System.Drawing.Point(86, 20);
            this.huyqtbtn.Name = "huyqtbtn";
            this.huyqtbtn.Size = new System.Drawing.Size(76, 23);
            this.huyqtbtn.TabIndex = 14;
            this.huyqtbtn.Text = "Hủy";
            this.huyqtbtn.UseVisualStyleBackColor = true;
            // 
            // xoamangbtn
            // 
            this.xoamangbtn.Location = new System.Drawing.Point(5, 20);
            this.xoamangbtn.Name = "xoamangbtn";
            this.xoamangbtn.Size = new System.Drawing.Size(76, 23);
            this.xoamangbtn.TabIndex = 15;
            this.xoamangbtn.Text = "Xóa mảng";
            this.xoamangbtn.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(267, 589);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(89, 61);
            this.panel10.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // codeListBox
            // 
            this.codeListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.codeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.Location = new System.Drawing.Point(3, 27);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.Size = new System.Drawing.Size(471, 262);
            this.codeListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code C++";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kiem tra tham so";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(433, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kiem tra Button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HienThiPanel
            // 
            this.HienThiPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HienThiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HienThiPanel.Controls.Add(this.button2);
            this.HienThiPanel.Controls.Add(this.button1);
            this.HienThiPanel.Controls.Add(this.codeListBox);
            this.HienThiPanel.Controls.Add(this.label2);
            this.HienThiPanel.Location = new System.Drawing.Point(362, 355);
            this.HienThiPanel.Name = "HienThiPanel";
            this.HienThiPanel.Size = new System.Drawing.Size(479, 295);
            this.HienThiPanel.TabIndex = 22;
            // 
            // ngonngupanel
            // 
            this.ngonngupanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ngonngupanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ngonngupanel.Controls.Add(this.btnVi);
            this.ngonngupanel.Controls.Add(this.btnEn);
            this.ngonngupanel.Controls.Add(this.lbNgonNgu);
            this.ngonngupanel.Location = new System.Drawing.Point(1024, 598);
            this.ngonngupanel.Name = "ngonngupanel";
            this.ngonngupanel.Size = new System.Drawing.Size(126, 52);
            this.ngonngupanel.TabIndex = 27;
            // 
            // btnVi
            // 
            this.btnVi.BackgroundImage = global::DoAnSapXep.Properties.Resources.vnflag;
            this.btnVi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVi.Location = new System.Drawing.Point(65, 20);
            this.btnVi.Name = "btnVi";
            this.btnVi.Size = new System.Drawing.Size(33, 23);
            this.btnVi.TabIndex = 4;
            this.btnVi.UseVisualStyleBackColor = true;
            this.btnVi.Click += new System.EventHandler(this.btnVi_Click);
            // 
            // btnEn
            // 
            this.btnEn.BackgroundImage = global::DoAnSapXep.Properties.Resources.usaplag;
            this.btnEn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEn.Location = new System.Drawing.Point(27, 20);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(32, 23);
            this.btnEn.TabIndex = 3;
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // lbNgonNgu
            // 
            this.lbNgonNgu.AutoSize = true;
            this.lbNgonNgu.Location = new System.Drawing.Point(35, 4);
            this.lbNgonNgu.Name = "lbNgonNgu";
            this.lbNgonNgu.Size = new System.Drawing.Size(56, 13);
            this.lbNgonNgu.TabIndex = 0;
            this.lbNgonNgu.Text = "Ngôn Ngữ";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1162, 662);
            this.Controls.Add(this.ngonngupanel);
            this.Controls.Add(this.Loaisapxeppanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.thuattoanpanel);
            this.Controls.Add(this.DebugPanel);
            this.Controls.Add(this.huypanel);
            this.Controls.Add(this.khoitaopanel);
            this.Controls.Add(this.dieukhienpanel);
            this.Controls.Add(this.HienThiPanel);
            this.Controls.Add(this.chuasapxepPanel);
            this.Controls.Add(this.sapxepPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM MÔ PHỎNG THUẬT TOÁN SẮP XẾP v1.0";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.sapxepPanel.ResumeLayout(false);
            this.sapxepPanel.PerformLayout();
            this.chuasapxepPanel.ResumeLayout(false);
            this.chuasapxepPanel.PerformLayout();
            this.DebugPanel.ResumeLayout(false);
            this.DebugPanel.PerformLayout();
            this.thuattoanpanel.ResumeLayout(false);
            this.thuattoanpanel.PerformLayout();
            this.Loaisapxeppanel.ResumeLayout(false);
            this.Loaisapxeppanel.PerformLayout();
            this.dieukhienpanel.ResumeLayout(false);
            this.dieukhienpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.khoitaopanel.ResumeLayout(false);
            this.khoitaopanel.PerformLayout();
            this.huypanel.ResumeLayout(false);
            this.huypanel.PerformLayout();
            this.HienThiPanel.ResumeLayout(false);
            this.HienThiPanel.PerformLayout();
            this.ngonngupanel.ResumeLayout(false);
            this.ngonngupanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ManHinh_label;
        private System.Windows.Forms.Label lbYTuongThuatToan;
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
        private TextBox yTuongTextBox;
        private Timer timer1;
        private Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox codeListBox;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel HienThiPanel;
        private Panel ngonngupanel;
        private Button btnVi;
        private Button btnEn;
        private Label lbNgonNgu;
        private TrackBar trackBar1;
        private Label label1;
    }
}

