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
        

        #region Insertion Sort
        public static void InsertionSort(bool tang = true)
        {
            string yTuong =
@"Giả sử có một dãy a0, a1,... ,an-1 trong đó i phần tử đầu tiên a0, a1,... ,ai-1 đã có thứ tự.
Tìm cách chèn phần tử ai vào vị trí thích hợp của đoạn đã được sắp để có dãy mới a0, a1,... ,ai trở nên có thứ tự. Vị trí này chính là vị trí giữa hai phần tử ak-1 và ak thỏa ak-1 < ai < ak(1≤k≤i).";
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

        #region Selection Sort
        public static void SelectionSort(bool tang = true)
        {
            string yTuong =
 @"Chọn phần tử nhỏ nhất trong N phần tử trong dãy hiện hành ban đầu.
Đưa phần tử này về vị trí đầu dãy hiện hành.
Xem dãy hiện hành chỉ còn N-1 phần tử của dãy hiện hành ban đầu.
    Bắt đầu từ vị trí thứ 2;
    Lặp lại quá trình trên cho dãy hiện hành... đến khi dãy hiện hành chỉ còn 1 phần tử.";
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
                codeListBox.Items[8] = "             if (a[j] > a[min])";
            }
        }
        #endregion

        #region Shaker Sort
        public static void ShakerSort(bool tang = true)
        {
            string yTuong =
@"Trong mỗi lần sắp xếp, duyệt mảng theo 2 lượt từ 2 phía khác nhau:
    Lượt đi: đẩy phần tử nhỏ về đầu mảng.
    Lượt về: đẩy phần tử lớn về cuối mảng.
Ghi nhận lại những đoạn đã sắp xếp nhằm tiết kiệm các phép so sánh thừa.";
            
            //thêm ytuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng
void ShakerSort(int a[], int N)
{
    int j, left, right, k;
    left = 0; right = N - 1, k = N - 1;
    while(left < right)
    {
    for(j = right; j > left; j--)
        if(a[j] < a[j - 1])
        {
            Swap(a[j], a[j - 1]);
            k = j;
        }
    left = k;
    for(j = left; j < right; j++)
        if(a[j + 1] < a[j])
        {
            Swap(a[j], a[j + 1]);
            k = j;
        }
    right = k;
    }
}");
            //thêm code vào codeListBox
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            // nếu sắp giảm thì sửa lại
            if(!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[8] = "        if(a[j] > a[j - 1])";
                codeListBox.Items[15] = "        if(a[j + 1] > a[j])";
            }
        }
        #endregion

        #region Quick Sort
        public static void QuickSort(bool tang = true)
        {
            string yTuong =
@"Giải thuật QuickSort sắp xếp dãy a1, a2 ..., aN dựa trên việc phân hoạch dãy ban đầu thành 3 phần :
Phần 1:Gồm các phần tử  có giá trị bé hơn x
Phần 2: Gồm các phần tử  có giá trị bằng  x 
Phần 3: Gồm các phần tử  có giá trị lớn hơn x
Với x là giá trị của một phần tử  tùy ý trong dãy ban đầu.";
            //Thêm yTuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng   
void QuickSort(int a[], int left, int right)
{
    int i, j, x;
    x = a[(left + night)/2];
    i = left, j = right;
    do
    {
        while(a[i] < x)
            i++;
        while(x < a[j])
            j--;
        if(i <= j)
        {
            Swap(a[i], a[j]);
            i++, j--;
        }            
    }while(i <= j);
    if(left < j)
        QuickSort(a, left, j);
    if(i < right)
        QuickSort(a, i, right);
}");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[8] = "        while(a[i] > x)";
                codeListBox.Items[10] = "        while(x > a[j])";
            }
        }
        #endregion

        #region Shell Sort
        public static void ShellSort(bool tang = true)
        {
            string yTuong =
@"Cải tiến của phương pháp chèn trực tiếp (Insertion Sort).
Phân hoạch dãy thành các dãy con.
Sắp xếp các dãy con theo phương pháp chèn trực tiếp.
Dùng phương pháp chèn trực tiếp sắp xếp lại cả dãy.";
            //Thêm yTuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng
void ShellSort (int a[], int N)
{
    for (int gap = N / 2; gap > 0; gap /= 2)
    {
        for (int i = gap; i < N; i++)
        {
            for (int j = i; j >= gap && a[j] < a[j - gap]; j -= gap)
            {
                Swap(a[j], a[j - gap]);
            }
        } 
    }
}");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            //if (!tang)
            //{

            //}
        }
        #endregion

        #region Interchange Sort
        public static void InterchangeSort(bool tang = true)
        {
            string yTuong =
@"Xuất phát từ đầu dãy, tìm tất các các nghịch thế chứa phần tử này, triệt tiêu chúng bằng cách đổi chỗ 2 phần tử trong cặp nghịch thế. Lặp lại xử lý trên với phần tử kế trong dãy.";
            //Thêm yTuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng
void InterchangeSort( int a[], int N)
{
    int i, j;
    for(i = 0; i < N - 1; i++)
        for(j = i + 1; j < N; j++)
            if( a[j] < a[i] )
                Swap( a[i], a[j]);
}
");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[6] = "            if( a[j] > a[i] )";
            }
        }
        #endregion

        #region Binary Insertion Sort
        public static void BinaryInsertionSort(bool tang = true)
        {
            string yTuong =
@"Cải tiến của giải thuật InsertionSort. Giải thuật chèn nhị phân cho phép giảm số lần so sánh, nhưng không làm giảm số lần dời chỗ.";
            //Thêm yTuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng
void BinaryInsertionSort(int a[], int N)
{
   int left, right, m, i , pos;
   int x;
   for(int i = 1; i < N ; i++)
   {
      x = a[i]; left = 0; right = i - 1;
      while(left <= right)
      {
         m = (left + right)/2;
         if(x < a[m]) right = m - 1;
         else left = m + 1;                    
      }
      for(pos = i - 1; pos >= left; pos--)
         a[pos+1] = a[pos];
      a[left] = x;
    }
}");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[11] = "         if(x > a[m]) right = m - 1;";
            }
        }
        #endregion

        #region Bubble Sort
        public static void BubbleSort(bool tang = true)
        {
            string yTuong =
@"Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đúng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i. 
Lặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét.";
            //Thêm yTuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng                
void BubbleSort(int a[], int N)
{
   int i,j;
   for(i = 0; i < N - 1; i++)
      for(j = N - 1; j > i; j--)
        if(a[j] < a[j - 1])
            Swap(a[j], a[j - 1]);
}
");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[6] = "       if(a[j] > a[j - 1])";
            }
        }
        #endregion

        #region Heap Sort
        public static void HeapSort(bool tang = true)
        {
            string yTuong =
@"Heap Sort tận dụng được các phép so sánh ở bước i-1, mà thuật toán sắp xếp chọn trực tiếp (Selectin Sort) không tận dụng được.
Để làm được điều này Heap sort thao tác dựa trên cây.";
            //Thêm yTuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"Sắp tăng    
void HeapSort(int a[], int N)
{
    CreateHeap(a,N - 1);
    int r;
    r = N - 1;
    while(r >= 0)
    {
        Swap(a[0], a[r]);
        r--;
        if(r > 0 )
            Shift(a,0,r);
    }
}

void CreateHeap(int a[], int N)
{
    int l;
    l = N/2 - 1;
    while(l >= 0)
    {
        Shift(a,l,N - 1);
        l--;
    }
}

void Shift(int a[], int l, int r)
{
    int i = l;
    int j = 2*i + 1;
    while(j <= r)
    {
        if(j < r && a[j] < a[j+1]) 
            j++;
        if(a[i] < a[j])
        {
            Swap(a[i], a[j]);
            i = j; 
            j = 2*i + 1;
        }
        else return;
    }
}");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {

            }
        }
        #endregion

        #region Merge Sort
        public static void MergeSort(bool tang = true)
        {
            string yTuong =
@"
";
            //Thêm yTuong vào yTuongThuatToan
            yTuongThuatToan.Clear();
            yTuongThuatToan.Text = yTuong;

            string[] code = ChuyenText(
@"
");
            //thêm code vào codeListBox 
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            //nếu sắp giảm thì sửa lại
            //if (!tang)
            //{

            //}
        }
        #endregion
    }
}
