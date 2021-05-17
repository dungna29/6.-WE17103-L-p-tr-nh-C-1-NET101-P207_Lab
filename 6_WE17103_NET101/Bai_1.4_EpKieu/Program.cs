using System;
using System.Text;

namespace Bai_1._4_EpKieu
{
    class Program
    {
        #region Ép kiểu trong lập trình
        /*
         * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         *
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Ép kiểu từ String về số
            /*
             * Cho người dùng nhập vào 2 số và cộng 2 số đó
             */
            //Bước 1: Xác định số biến cần dùng
            int a, b, kq;
            //Bước 2: Triển khai
            Console.WriteLine("Mời bạn nhập số thứ 1: ");
            a = Int32.Parse(Console.ReadLine());//Ép kiểu bằng phương thức Parse()
            Console.WriteLine("Mời bạn nhập số thứ 2: ");
            b = Convert.ToInt32(Console.ReadLine());//Ép kiểu bằng class Convert
            //Thực hiện phép toán
            kq = a + b;
            Console.WriteLine("Số thứ 1 {0}",a);
            Console.WriteLine("Số thứ 2 {0}",b);
            Console.WriteLine("Kết quả = {0}", kq);
            Console.WriteLine("{0} + {1} = {2}",a,b,kq);
           
            //Phần 2: Chuyển đổi kiểu dữ liệu số
            int temp1 = 5;
            double temp2 = 8.9;
            //temp2 = temp1;//Gán lại giá trị từ int về double
            Console.WriteLine("Temp2 = " + temp2);
            //temp1 = temp2;//Không thể đổ dữ liệu từ kiểu dữ liệu lớn hơn sang kiểu dữ liệu nhỏ hơn.
            temp1 = (int) temp2;
            Console.WriteLine(temp1);
            /*
             Bài 1: Chương trình cho phép nhập họ và tên sinh viên, năm sinh, mã sinh viên từ bàn phím và xuất ra định dạng sau: 
             “Chào bạn <<họ và tên>> | <<Tuổi>> |<<năm sinh>>  | <<mã sinh viên>> 
             đến với chương trình Csharp1 đầu tiên.”

              Bài 2: Nhập 3 đầu điểm Địa, Toán, Văn sau đó tính điểm trung bình của 3 đầu điểm đó.
             */
        }
    }
}
