using System;
using System.Collections;
using System.Text;

namespace Bai_2._8_ArrayList
{
    class Program
    {
        /*
         *  ArrayList
         *  Định nghĩa: Là một Collection giúp lưu trữ và quản lý một
                        danh sách các đối tượng theo kiểu mảng (truy
                        cập các phần tử bên trong thông qua chỉ số
                        index)
            Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                        linh hoạt và có thể tự điều chỉnh kích cỡ một
                        cách tự động.
            Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                        thêm thư viện System.Collections

            Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
         */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Array luôn phải khởi tạo kích thước của mảng mới đem ra sử dụng
            int[] arrNumbers = new int[5];

            //Phần 1: Khai báo và khởi tạo ArrayList
            ArrayList arrLstNumber1;//khai báo
            arrLstNumber1 = new ArrayList();//Khởi tạo 

            //Phần 2: Thêm giá trị vào ArrayList dùng phương thức add()
            arrLstNumber1.Add(1);
            arrLstNumber1.Add(1.9);
            arrLstNumber1.Add("FPT");
            arrLstNumber1.Add(true);
            arrLstNumber1.Add('a');

            //Phần 3: Lấy giá trị 
            Console.WriteLine(arrLstNumber1[2]);
            for (int i = 0; i < arrLstNumber1.Count; i++)
            {
                Console.Write(arrLstNumber1[i] + " ");
            }

            Console.WriteLine();

            //Phần 4: Xóa phần tử
            Console.WriteLine("=====Xóa phần tử=====");
            arrLstNumber1.RemoveAt(2);//RemoveAt dùng để xóa phần tử theo Index
            for (int i = 0; i < arrLstNumber1.Count; i++)
            {
                Console.Write(arrLstNumber1[i] + " ");
            }
            //Một vài phương thức hay sử dụng
            arrLstNumber1 = new ArrayList();
            arrLstNumber1.Clear();
        }
    }
}
