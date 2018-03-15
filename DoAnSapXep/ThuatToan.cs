using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnSapXep
{
    public class ThuatToan
    {
        
        public  static ListBox codeListBox;
        public static TextBox yTuongThuatToan;
        
        public static string[] ChuyenText(string doc)
        {
            string[] text;
            text = doc.Split('\n');//Cac string den xuong dong
            return text;
        }
        #region Selection Sort
        public static void SelectionSort(bool tang = true)
        {            
           string yTuong = 
@"Bước 1:Thiết lập MIN về vị trí 0
Bước 2: Tìm kiếm phần tử nhỏ nhất trong danh sách
Bước 3: Tráo đổi với giá trị tại vị trí MIN
Bước 4: Tăng MIN để trỏ tới phần tử tiếp theo
Bước 5: Lặp lại cho tới khi toàn bộ danh sách đã được sắp xếp";
            //Thêm yTuong vào yTuongThuatToan
            
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng:
            void SelecttionSort(int arr[], int N)
            {
                int min, i, j;
                for (i=0; i < N-1; i++)
                {
                    min = i;
                    for (j=i+1; j <N; j++)
                        if (a[j] < a[min])
                                min=j;
                    Swap(a[min], a[i]);   
                } 
            }");
            //thêm code vào codeListBox
            
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //Nếu sắp xếp giảm dần thì sửa lại
            if (!tang)
            {                
                codeListBox.Items[0] = "Sắp Giảm";
                codeListBox.Items[8] = "                        if (a[j] > a[min])";
            }
        }
        #endregion

        #region Insertion Sort
        public static void InsertionSort(bool tang = true)
        {
            string yTuong =
@"Bước 1: Kiểm tra nếu phần tử đầu tiên đã được sắp xếp. trả về 1
Bước 2: Lấy phần tử kế tiếp
Bước 3: So sánh với tất cả phần tử trong danh sách con đã qua sắp xếp
Bước 4: Dịch chuyển tất cả phần tử trong danh sách con mà lớn hơn giá trị để được sắp xếp
Bước 5: Chèn giá trị đó
Bước 6: Lặp lại cho tới khi danh sách được sắp xếp";
                // Thêm yTuong vào yTuongThuatToan
            
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng                  
void InsertionSort(int a[], int N)
{
    int pos, i;
    int x;
    for(i = 1; i < N; i++)
    {
        x = a[i]; pos = i - 1;
        while((pos >= 0) && (x < a[pos]))
        {
            a[pos + 1] = a[pos];
            pos--;
        }
        a[pos + 1] = x;
    }
}");
            // Thêm code vào codeListBox
            
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[9] = "        while((pos >= 0) && (x > a[pos]))";
            }
        }
        #endregion
    }
}
