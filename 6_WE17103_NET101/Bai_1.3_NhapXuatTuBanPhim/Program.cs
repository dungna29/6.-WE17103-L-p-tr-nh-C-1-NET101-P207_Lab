using System;
using System.Text;

namespace Bai_1._3NhapXuatTuBanPhim
{
    class Program
    {
        /*
         * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Xuất dữ liệu ra màn hình cw + tab
            Console.Write("Chào các bạn ");
            Console.WriteLine(" đến với ngành UDPM .NET");
            Console.Write(" tại FPOLY");
            Console.WriteLine(" Năm 2021");

            //Tạo template mẫu
            string name = "Trang", year = "2000", school = "FPOLY";
            Console.WriteLine("Chào bạn: {0}, Sinh năm: {1}, Trường {2}",name,year,school);
            Console.WriteLine("Chào bạn: " + name + " Sinh Năm: " + year + " Trường " + school);

            //Phần 2: Nhập dữ liệu từ bàn phím
            string input1;//Khởi tạo 1 biến để hứng giá trị người dùng nhập vào
            Console.WriteLine("Mời bạn nhập tên: ");
            input1 = Console.ReadLine();//Gán giá trị người dùng nhập vào cho biến input1
            //Console.ReadLine() có kiểu dữ liệu là string
            Console.WriteLine("Chào mừng bạn {0} học C#1",input1);

            //Sử dụng Console.Read(); = kiểu số nguyên
            int input2;
            Console.WriteLine("Mời bạn nhập Console.Read(): ");
            input2 = Console.Read();
            Console.WriteLine("Mã ASII = " + input2);

            /*
             * Chương trình cho phép nhập họ và tên sinh viên, năm sinh, mã sinh viên từ bàn phím và xuất ra định dạng sau:
               “Chào bạn <<họ và tên>> | <<năm sinh>>  | <<mã sinh viên>> đến với chương trình lập trình đầu tiên.”               
             */
        }
    }
}
