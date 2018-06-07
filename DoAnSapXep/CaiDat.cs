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
    public partial class CaiDat : Form
    {
        // public
        public TextBox _txbLabelFont;
        public TextBox _txbFontChu;

        public CaiDat()
        {
            TextBox txbLabelFont= new TextBox();
            TextBox txbFontChu= new TextBox();

            InitializeComponent();

            txbKichCoNode.Text = ThamSo.KichCoNode.ToString();
            txbKhoangCachGiuaCacNode.Text = ThamSo.KhoangCachCacNode.ToString();

            btnMauNenNode.BackColor = ThamSo.mauNen;
            btnMauNodeDaSapXep.BackColor = ThamSo.mauNodeHTSX;
            btnMauNodeDangXet.BackColor = ThamSo.mauNodeDangSX;

            txbSoLuongPhanTuMacDinh.Text = Properties.Settings.Default.soLuongPhanTuMacDinh.ToString();

            _txbLabelFont = txbLabelFont;
            _txbFontChu = txbFontChu;
         
            labelFontDialog.Font = txbLabelFont.Font;
            chuFontDialog.Font = txbChuFont.Font;

            txbLabelFont.Text = string.Format("{0} {1}", txbLabelFont.Font.Name, txbLabelFont.Font.Size);
            txbChuFont.Text = string.Format("{0} {1}", txbChuFont.Font.Name, txbChuFont.Font.Size);

        }

        private void btnMauNenNode_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                button.BackColor = colorDialog1.Color;
            }
        }

        private void btnMauNodeDangXet_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                button.BackColor = colorDialog1.Color;
            }
        }

        private void btnMauNodeDaSapXep_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                button.BackColor = colorDialog1.Color;
            }
        }

      

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int kichCoNode, khoanCachGiuaCacNode, soLuongPhanTuMacDinh;
            bool rs = int.TryParse(txbKichCoNode.Text, out kichCoNode);
            if (rs = false || (kichCoNode < 30 || kichCoNode > 50))
            {
                MessageBox.Show("Kích cỡ Node phải là số nguyên và thuộc khoản từ 30 đến 50!", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rs = int.TryParse(txbKhoangCachGiuaCacNode.Text, out khoanCachGiuaCacNode);
            if (rs = false || (khoanCachGiuaCacNode < 1 || khoanCachGiuaCacNode > 100))
            {
                MessageBox.Show("Khoảng cách giữa các Node phải là số nguyên và thuộc khoản từ 1 đến 100!", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rs = int.TryParse(txbSoLuongPhanTuMacDinh.Text, out soLuongPhanTuMacDinh);
            if (rs = false || (soLuongPhanTuMacDinh < 1 || soLuongPhanTuMacDinh > ThamSo.SoLuongPhanTuMax))
            {
                MessageBox.Show("Số lượng phần tử mặc định phải là số nguyên và thuộc khoản từ 1 đến " + ThamSo.SoLuongPhanTuMax + " !", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Properties.Settings.Default.kichCoNode = ThamSo.KichCoNode = kichCoNode;
            Properties.Settings.Default.khoangCachGiuaCacNode = ThamSo.KhoangCachCacNode = khoanCachGiuaCacNode;

            Properties.Settings.Default.mauNenNode = ThamSo.mauNen = btnMauNenNode.BackColor;
            Properties.Settings.Default.mauNodeHoanTatSapXep = ThamSo.mauNodeHTSX = btnMauNodeDaSapXep.BackColor;
            Properties.Settings.Default.mauNodeDangSapXep = ThamSo.mauNodeDangSX = btnMauNodeDangXet.BackColor;

            Properties.Settings.Default.labelFont = txbLabelFont.Font = labelFontDialog.Font;
            Properties.Settings.Default.chuFont = txbChuFont.Font = chuFontDialog.Font;

            Properties.Settings.Default.soLuongPhanTuMacDinh = soLuongPhanTuMacDinh;


            Properties.Settings.Default.Save();
            this.Close();
        }

        private void txbFormForn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = labelFontDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                Font font = labelFontDialog.Font;
                txbLabelFont.Text = string.Format("{0} {1}", font.Name, font.Size);

            }
        }

        private void txbLabelChu_Click(object sender, EventArgs e)
        {
            DialogResult dialog = labelFontDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                Font font = labelFontDialog.Font;
                txbLabelFont.Text = string.Format("{0} {1}", font.Name, font.Size);

            }
        }

        private void txbLabelFont_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
