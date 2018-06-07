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
            this.daydangxepListbox = new System.Windows.Forms.ListBox();
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
            this.thoatbtn = new System.Windows.Forms.Button();
            this.xoamangbtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HienThiPanel = new System.Windows.Forms.Panel();
            this.ngonngupanel = new System.Windows.Forms.Panel();
            this.btnVi = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.lbNgonNgu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caiDatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugPanel.SuspendLayout();
            this.thuattoanpanel.SuspendLayout();
            this.Loaisapxeppanel.SuspendLayout();
            this.dieukhienpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.khoitaopanel.SuspendLayout();
            this.huypanel.SuspendLayout();
            this.HienThiPanel.SuspendLayout();
            this.ngonngupanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbYTuongThuatToan
            // 
            this.lbYTuongThuatToan.AutoSize = true;
            this.lbYTuongThuatToan.Location = new System.Drawing.Point(4, 0);
            this.lbYTuongThuatToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYTuongThuatToan.Name = "lbYTuongThuatToan";
            this.lbYTuongThuatToan.Size = new System.Drawing.Size(125, 17);
            this.lbYTuongThuatToan.TabIndex = 11;
            this.lbYTuongThuatToan.Text = "Ý tưởng thuật toán";
            // 
            // lbHuy
            // 
            this.lbHuy.AutoSize = true;
            this.lbHuy.Location = new System.Drawing.Point(4, 5);
            this.lbHuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHuy.Name = "lbHuy";
            this.lbHuy.Size = new System.Drawing.Size(33, 17);
            this.lbHuy.TabIndex = 12;
            this.lbHuy.Text = "Hủy";
            // 
            // lbKhoiTao
            // 
            this.lbKhoiTao.AutoSize = true;
            this.lbKhoiTao.Location = new System.Drawing.Point(4, 22);
            this.lbKhoiTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoiTao.Name = "lbKhoiTao";
            this.lbKhoiTao.Size = new System.Drawing.Size(65, 17);
            this.lbKhoiTao.TabIndex = 13;
            this.lbKhoiTao.Text = "Khởi Tạo";
            // 
            // lbDieuKhien
            // 
            this.lbDieuKhien.AutoSize = true;
            this.lbDieuKhien.Location = new System.Drawing.Point(4, 14);
            this.lbDieuKhien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDieuKhien.Name = "lbDieuKhien";
            this.lbDieuKhien.Size = new System.Drawing.Size(77, 17);
            this.lbDieuKhien.TabIndex = 14;
            this.lbDieuKhien.Text = "Điều Khiển";
            this.lbDieuKhien.Click += new System.EventHandler(this.lbDieuKhien_Click);
            // 
            // lbThuatToan
            // 
            this.lbThuatToan.AutoSize = true;
            this.lbThuatToan.Location = new System.Drawing.Point(11, 6);
            this.lbThuatToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThuatToan.Name = "lbThuatToan";
            this.lbThuatToan.Size = new System.Drawing.Size(82, 17);
            this.lbThuatToan.TabIndex = 15;
            this.lbThuatToan.Text = "Thuật Toán";
            // 
            // lbSapXep
            // 
            this.lbSapXep.AutoSize = true;
            this.lbSapXep.Location = new System.Drawing.Point(24, 14);
            this.lbSapXep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSapXep.Name = "lbSapXep";
            this.lbSapXep.Size = new System.Drawing.Size(62, 17);
            this.lbSapXep.TabIndex = 16;
            this.lbSapXep.Text = "Sắp Xếp";
            // 
            // lbMangChuaSapXep
            // 
            this.lbMangChuaSapXep.AutoSize = true;
            this.lbMangChuaSapXep.Location = new System.Drawing.Point(20, 394);
            this.lbMangChuaSapXep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMangChuaSapXep.Name = "lbMangChuaSapXep";
            this.lbMangChuaSapXep.Size = new System.Drawing.Size(131, 17);
            this.lbMangChuaSapXep.TabIndex = 17;
            this.lbMangChuaSapXep.Text = "Mảng chưa sắp xếp";
            // 
            // sapxepPanel
            // 
            this.sapxepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sapxepPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sapxepPanel.Location = new System.Drawing.Point(9, 33);
            this.sapxepPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sapxepPanel.Name = "sapxepPanel";
            this.sapxepPanel.Size = new System.Drawing.Size(1525, 341);
            this.sapxepPanel.TabIndex = 18;
            this.sapxepPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sapxepPanel_MouseClick);
            // 
            // lbTocDo
            // 
            this.lbTocDo.AutoSize = true;
            this.lbTocDo.Location = new System.Drawing.Point(301, 48);
            this.lbTocDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTocDo.Name = "lbTocDo";
            this.lbTocDo.Size = new System.Drawing.Size(52, 17);
            this.lbTocDo.TabIndex = 4;
            this.lbTocDo.Text = "Tốc độ";
            // 
            // chuasapxepPanel
            // 
            this.chuasapxepPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chuasapxepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chuasapxepPanel.Location = new System.Drawing.Point(163, 382);
            this.chuasapxepPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chuasapxepPanel.Name = "chuasapxepPanel";
            this.chuasapxepPanel.Size = new System.Drawing.Size(1355, 48);
            this.chuasapxepPanel.TabIndex = 19;
            // 
            // DebugPanel
            // 
            this.DebugPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DebugPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DebugPanel.Controls.Add(this.lbYTuongThuatToan);
            this.DebugPanel.Controls.Add(this.yTuongTextBox);
            this.DebugPanel.Controls.Add(this.daydangxepListbox);
            this.DebugPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugPanel.Location = new System.Drawing.Point(8, 437);
            this.DebugPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DebugPanel.Name = "DebugPanel";
            this.DebugPanel.Size = new System.Drawing.Size(535, 166);
            this.DebugPanel.TabIndex = 20;
            // 
            // yTuongTextBox
            // 
            this.yTuongTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yTuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yTuongTextBox.Location = new System.Drawing.Point(7, 17);
            this.yTuongTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yTuongTextBox.Multiline = true;
            this.yTuongTextBox.Name = "yTuongTextBox";
            this.yTuongTextBox.ReadOnly = true;
            this.yTuongTextBox.Size = new System.Drawing.Size(453, 143);
            this.yTuongTextBox.TabIndex = 12;
            // 
            // daydangxepListbox
            // 
            this.daydangxepListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daydangxepListbox.FormattingEnabled = true;
            this.daydangxepListbox.ItemHeight = 17;
            this.daydangxepListbox.Location = new System.Drawing.Point(7, 17);
            this.daydangxepListbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daydangxepListbox.Name = "daydangxepListbox";
            this.daydangxepListbox.Size = new System.Drawing.Size(453, 136);
            this.daydangxepListbox.TabIndex = 13;
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
            this.thuattoanpanel.Location = new System.Drawing.Point(8, 610);
            this.thuattoanpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thuattoanpanel.Name = "thuattoanpanel";
            this.thuattoanpanel.Size = new System.Drawing.Size(389, 189);
            this.thuattoanpanel.TabIndex = 4;
            // 
            // insertionrdbtn
            // 
            this.insertionrdbtn.AutoSize = true;
            this.insertionrdbtn.Location = new System.Drawing.Point(227, 38);
            this.insertionrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertionrdbtn.Name = "insertionrdbtn";
            this.insertionrdbtn.Size = new System.Drawing.Size(111, 21);
            this.insertionrdbtn.TabIndex = 12;
            this.insertionrdbtn.Text = "Insertion sort";
            this.insertionrdbtn.UseVisualStyleBackColor = true;
            this.insertionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // mergerdbtn
            // 
            this.mergerdbtn.AutoSize = true;
            this.mergerdbtn.Location = new System.Drawing.Point(45, 151);
            this.mergerdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mergerdbtn.Name = "mergerdbtn";
            this.mergerdbtn.Size = new System.Drawing.Size(97, 21);
            this.mergerdbtn.TabIndex = 21;
            this.mergerdbtn.Text = "Merge sort";
            this.mergerdbtn.UseVisualStyleBackColor = true;
            this.mergerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // shellrdbtn
            // 
            this.shellrdbtn.AutoSize = true;
            this.shellrdbtn.Location = new System.Drawing.Point(227, 151);
            this.shellrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shellrdbtn.Name = "shellrdbtn";
            this.shellrdbtn.Size = new System.Drawing.Size(88, 21);
            this.shellrdbtn.TabIndex = 20;
            this.shellrdbtn.Text = "Shell sort";
            this.shellrdbtn.UseVisualStyleBackColor = true;
            this.shellrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // quickrdbtn
            // 
            this.quickrdbtn.AutoSize = true;
            this.quickrdbtn.Location = new System.Drawing.Point(227, 123);
            this.quickrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quickrdbtn.Name = "quickrdbtn";
            this.quickrdbtn.Size = new System.Drawing.Size(93, 21);
            this.quickrdbtn.TabIndex = 19;
            this.quickrdbtn.Text = "Quick sort";
            this.quickrdbtn.UseVisualStyleBackColor = true;
            this.quickrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // shakerrdbtn
            // 
            this.shakerrdbtn.AutoSize = true;
            this.shakerrdbtn.Location = new System.Drawing.Point(227, 95);
            this.shakerrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shakerrdbtn.Name = "shakerrdbtn";
            this.shakerrdbtn.Size = new System.Drawing.Size(102, 21);
            this.shakerrdbtn.TabIndex = 18;
            this.shakerrdbtn.Text = "Shaker sort";
            this.shakerrdbtn.UseVisualStyleBackColor = true;
            this.shakerrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // selectionrdbtn
            // 
            this.selectionrdbtn.AutoSize = true;
            this.selectionrdbtn.Location = new System.Drawing.Point(227, 66);
            this.selectionrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectionrdbtn.Name = "selectionrdbtn";
            this.selectionrdbtn.Size = new System.Drawing.Size(115, 21);
            this.selectionrdbtn.TabIndex = 17;
            this.selectionrdbtn.Text = "Selection sort";
            this.selectionrdbtn.UseVisualStyleBackColor = true;
            this.selectionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // heaprdbtn
            // 
            this.heaprdbtn.AutoSize = true;
            this.heaprdbtn.Location = new System.Drawing.Point(45, 123);
            this.heaprdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heaprdbtn.Name = "heaprdbtn";
            this.heaprdbtn.Size = new System.Drawing.Size(91, 21);
            this.heaprdbtn.TabIndex = 12;
            this.heaprdbtn.Text = "Heap sort";
            this.heaprdbtn.UseVisualStyleBackColor = true;
            this.heaprdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // bubblerdbtn
            // 
            this.bubblerdbtn.AutoSize = true;
            this.bubblerdbtn.Location = new System.Drawing.Point(45, 95);
            this.bubblerdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bubblerdbtn.Name = "bubblerdbtn";
            this.bubblerdbtn.Size = new System.Drawing.Size(101, 21);
            this.bubblerdbtn.TabIndex = 16;
            this.bubblerdbtn.Text = "Bubble sort";
            this.bubblerdbtn.UseVisualStyleBackColor = true;
            this.bubblerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // binaryinsertionrdbtn
            // 
            this.binaryinsertionrdbtn.AutoSize = true;
            this.binaryinsertionrdbtn.Location = new System.Drawing.Point(45, 66);
            this.binaryinsertionrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.binaryinsertionrdbtn.Name = "binaryinsertionrdbtn";
            this.binaryinsertionrdbtn.Size = new System.Drawing.Size(155, 21);
            this.binaryinsertionrdbtn.TabIndex = 12;
            this.binaryinsertionrdbtn.Text = "Binary insertion sort";
            this.binaryinsertionrdbtn.UseVisualStyleBackColor = true;
            this.binaryinsertionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // interchangerdbtn
            // 
            this.interchangerdbtn.AutoSize = true;
            this.interchangerdbtn.Location = new System.Drawing.Point(45, 38);
            this.interchangerdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.interchangerdbtn.Name = "interchangerdbtn";
            this.interchangerdbtn.Size = new System.Drawing.Size(132, 21);
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
            this.Loaisapxeppanel.Location = new System.Drawing.Point(405, 610);
            this.Loaisapxeppanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loaisapxeppanel.Name = "Loaisapxeppanel";
            this.Loaisapxeppanel.Size = new System.Drawing.Size(138, 107);
            this.Loaisapxeppanel.TabIndex = 21;
            // 
            // giamrdbtn
            // 
            this.giamrdbtn.AutoSize = true;
            this.giamrdbtn.Location = new System.Drawing.Point(28, 71);
            this.giamrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.giamrdbtn.Name = "giamrdbtn";
            this.giamrdbtn.Size = new System.Drawing.Size(62, 21);
            this.giamrdbtn.TabIndex = 12;
            this.giamrdbtn.TabStop = true;
            this.giamrdbtn.Text = "Giảm";
            this.giamrdbtn.UseVisualStyleBackColor = true;
            this.giamrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // tangrdbtn
            // 
            this.tangrdbtn.AutoSize = true;
            this.tangrdbtn.Location = new System.Drawing.Point(28, 44);
            this.tangrdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tangrdbtn.Name = "tangrdbtn";
            this.tangrdbtn.Size = new System.Drawing.Size(62, 21);
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
            this.dieukhienpanel.Location = new System.Drawing.Point(1129, 437);
            this.dieukhienpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dieukhienpanel.Name = "dieukhienpanel";
            this.dieukhienpanel.Size = new System.Drawing.Size(403, 142);
            this.dieukhienpanel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "5";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(113, 48);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(180, 39);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "00:00";
            // 
            // huybnt
            // 
            this.huybnt.Location = new System.Drawing.Point(288, 95);
            this.huybnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.huybnt.Name = "huybnt";
            this.huybnt.Size = new System.Drawing.Size(100, 28);
            this.huybnt.TabIndex = 8;
            this.huybnt.Text = "Hủy";
            this.huybnt.UseVisualStyleBackColor = true;
            this.huybnt.Click += new System.EventHandler(this.huybnt_Click);
            // 
            // dungbtn
            // 
            this.dungbtn.Location = new System.Drawing.Point(157, 95);
            this.dungbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dungbtn.Name = "dungbtn";
            this.dungbtn.Size = new System.Drawing.Size(100, 28);
            this.dungbtn.TabIndex = 9;
            this.dungbtn.Text = "Dừng";
            this.dungbtn.UseVisualStyleBackColor = true;
            this.dungbtn.Click += new System.EventHandler(this.dungbtn_Click);
            // 
            // batdaubtn
            // 
            this.batdaubtn.Location = new System.Drawing.Point(27, 95);
            this.batdaubtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batdaubtn.Name = "batdaubtn";
            this.batdaubtn.Size = new System.Drawing.Size(100, 28);
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
            this.khoitaopanel.Location = new System.Drawing.Point(1129, 587);
            this.khoitaopanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khoitaopanel.Name = "khoitaopanel";
            this.khoitaopanel.Size = new System.Drawing.Size(403, 141);
            this.khoitaopanel.TabIndex = 24;
            this.khoitaopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.khoitaopanel_Paint);
            // 
            // soluongNodetbx
            // 
            this.soluongNodetbx.Location = new System.Drawing.Point(220, 37);
            this.soluongNodetbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soluongNodetbx.Multiline = true;
            this.soluongNodetbx.Name = "soluongNodetbx";
            this.soluongNodetbx.Size = new System.Drawing.Size(53, 21);
            this.soluongNodetbx.TabIndex = 15;
            this.soluongNodetbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.soluongNodetbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nhaptaybtn
            // 
            this.nhaptaybtn.Location = new System.Drawing.Point(217, 103);
            this.nhaptaybtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nhaptaybtn.Name = "nhaptaybtn";
            this.nhaptaybtn.Size = new System.Drawing.Size(171, 30);
            this.nhaptaybtn.TabIndex = 6;
            this.nhaptaybtn.Text = "Nhập bằng tay";
            this.nhaptaybtn.UseVisualStyleBackColor = true;
            this.nhaptaybtn.Click += new System.EventHandler(this.nhaptaybtn_Click);
            // 
            // lbSoPhanTu
            // 
            this.lbSoPhanTu.AutoSize = true;
            this.lbSoPhanTu.Location = new System.Drawing.Point(109, 37);
            this.lbSoPhanTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoPhanTu.Name = "lbSoPhanTu";
            this.lbSoPhanTu.Size = new System.Drawing.Size(77, 17);
            this.lbSoPhanTu.TabIndex = 14;
            this.lbSoPhanTu.Text = "Số phần tử";
            // 
            // docfilebtn
            // 
            this.docfilebtn.Location = new System.Drawing.Point(27, 106);
            this.docfilebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.docfilebtn.Name = "docfilebtn";
            this.docfilebtn.Size = new System.Drawing.Size(164, 30);
            this.docfilebtn.TabIndex = 4;
            this.docfilebtn.Text = "Đọc file";
            this.docfilebtn.UseVisualStyleBackColor = true;
            // 
            // venutbtn
            // 
            this.venutbtn.Location = new System.Drawing.Point(217, 66);
            this.venutbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.venutbtn.Name = "venutbtn";
            this.venutbtn.Size = new System.Drawing.Size(171, 30);
            this.venutbtn.TabIndex = 5;
            this.venutbtn.Text = "Vẽ nút";
            this.venutbtn.UseVisualStyleBackColor = true;
            this.venutbtn.Click += new System.EventHandler(this.venutbtn_Click);
            // 
            // taongaunhienbtn
            // 
            this.taongaunhienbtn.Location = new System.Drawing.Point(27, 65);
            this.taongaunhienbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taongaunhienbtn.Name = "taongaunhienbtn";
            this.taongaunhienbtn.Size = new System.Drawing.Size(164, 30);
            this.taongaunhienbtn.TabIndex = 7;
            this.taongaunhienbtn.Text = "Ngẫu nhiên";
            this.taongaunhienbtn.UseVisualStyleBackColor = true;
            this.taongaunhienbtn.Click += new System.EventHandler(this.taongaunhienbtn_Click);
            // 
            // huypanel
            // 
            this.huypanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.huypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huypanel.Controls.Add(this.thoatbtn);
            this.huypanel.Controls.Add(this.xoamangbtn);
            this.huypanel.Controls.Add(this.lbHuy);
            this.huypanel.Location = new System.Drawing.Point(1129, 736);
            this.huypanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.huypanel.Name = "huypanel";
            this.huypanel.Size = new System.Drawing.Size(227, 64);
            this.huypanel.TabIndex = 25;
            // 
            // thoatbtn
            // 
            this.thoatbtn.Location = new System.Drawing.Point(115, 25);
            this.thoatbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(101, 28);
            this.thoatbtn.TabIndex = 14;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // xoamangbtn
            // 
            this.xoamangbtn.Location = new System.Drawing.Point(7, 25);
            this.xoamangbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoamangbtn.Name = "xoamangbtn";
            this.xoamangbtn.Size = new System.Drawing.Size(101, 28);
            this.xoamangbtn.TabIndex = 15;
            this.xoamangbtn.Text = "Xóa mảng";
            this.xoamangbtn.UseVisualStyleBackColor = true;
            this.xoamangbtn.Click += new System.EventHandler(this.xoamangbtn_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(405, 725);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(138, 75);
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
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // codeListBox
            // 
            this.codeListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.codeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 16;
            this.codeListBox.Location = new System.Drawing.Point(4, 33);
            this.codeListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.Size = new System.Drawing.Size(628, 320);
            this.codeListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code C++";
            // 
            // HienThiPanel
            // 
            this.HienThiPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HienThiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HienThiPanel.Controls.Add(this.codeListBox);
            this.HienThiPanel.Controls.Add(this.label2);
            this.HienThiPanel.Location = new System.Drawing.Point(552, 437);
            this.HienThiPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HienThiPanel.Name = "HienThiPanel";
            this.HienThiPanel.Size = new System.Drawing.Size(569, 363);
            this.HienThiPanel.TabIndex = 22;
            // 
            // ngonngupanel
            // 
            this.ngonngupanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ngonngupanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ngonngupanel.Controls.Add(this.btnVi);
            this.ngonngupanel.Controls.Add(this.btnEn);
            this.ngonngupanel.Controls.Add(this.lbNgonNgu);
            this.ngonngupanel.Location = new System.Drawing.Point(1365, 736);
            this.ngonngupanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngonngupanel.Name = "ngonngupanel";
            this.ngonngupanel.Size = new System.Drawing.Size(167, 64);
            this.ngonngupanel.TabIndex = 27;
            // 
            // btnVi
            // 
            this.btnVi.BackgroundImage = global::DoAnSapXep.Properties.Resources.vnflag;
            this.btnVi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVi.Location = new System.Drawing.Point(87, 25);
            this.btnVi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVi.Name = "btnVi";
            this.btnVi.Size = new System.Drawing.Size(44, 28);
            this.btnVi.TabIndex = 4;
            this.btnVi.UseVisualStyleBackColor = true;
            this.btnVi.Click += new System.EventHandler(this.btnVi_Click);
            // 
            // btnEn
            // 
            this.btnEn.BackgroundImage = global::DoAnSapXep.Properties.Resources.usaplag;
            this.btnEn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEn.Location = new System.Drawing.Point(36, 25);
            this.btnEn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(43, 28);
            this.btnEn.TabIndex = 3;
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // lbNgonNgu
            // 
            this.lbNgonNgu.AutoSize = true;
            this.lbNgonNgu.Location = new System.Drawing.Point(47, 5);
            this.lbNgonNgu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgonNgu.Name = "lbNgonNgu";
            this.lbNgonNgu.Size = new System.Drawing.Size(72, 17);
            this.lbNgonNgu.TabIndex = 0;
            this.lbNgonNgu.Text = "Ngôn Ngữ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.caiDatToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1549, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // caiDatToolStripMenuItem
            // 
            this.caiDatToolStripMenuItem.Name = "caiDatToolStripMenuItem";
            this.caiDatToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.caiDatToolStripMenuItem.Text = "CaiDat";
            this.caiDatToolStripMenuItem.Click += new System.EventHandler(this.caiDatToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1549, 831);
            this.Controls.Add(this.lbMangChuaSapXep);
            this.Controls.Add(this.ngonngupanel);
            this.Controls.Add(this.Loaisapxeppanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.thuattoanpanel);
            this.Controls.Add(this.huypanel);
            this.Controls.Add(this.khoitaopanel);
            this.Controls.Add(this.dieukhienpanel);
            this.Controls.Add(this.HienThiPanel);
            this.Controls.Add(this.chuasapxepPanel);
            this.Controls.Add(this.sapxepPanel);
            this.Controls.Add(this.DebugPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM MÔ PHỎNG THUẬT TOÁN SẮP XẾP v1.0";
            this.Load += new System.EventHandler(this.Mainform_Load);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button venutbtn;
        private System.Windows.Forms.Button taongaunhienbtn;
        private System.Windows.Forms.Button thoatbtn;
        private System.Windows.Forms.Button xoamangbtn;
        private System.Windows.Forms.TextBox soluongNodetbx;
        private System.Windows.Forms.Label lbTocDo;
        private TextBox yTuongTextBox;
        private Timer timer1;
        private Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox codeListBox;
        private Label label2;
        private Panel HienThiPanel;
        private Panel ngonngupanel;
        private Button btnVi;
        private Button btnEn;
        private Label lbNgonNgu;
        private TrackBar trackBar1;
        private Label label1;
        private ListBox daydangxepListbox;
        private Button nhaptaybtn;
        private Button docfilebtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem caiDatToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}

