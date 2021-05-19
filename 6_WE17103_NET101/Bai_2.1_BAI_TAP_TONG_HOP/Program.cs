using System;
using System.Text;

namespace Bai_2._1_BAI_TAP_TONG_HOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Bài 1: Viết 1 chương trình máy tính cộng 2 số sử dụng menu switch case gồm các chức năng sau:
             *  - Phép cộng
             *  - Phép trừ
             *  - Phép nhân
             *  - Phép chia
             *
             * Bài 2: Viết 1 chương trình gồm 2 chức năng có sử dụng switch case:
             *      1. Tính tuổi - dựa trên năm sinh người dùng nhập vào.
             *      2. Nhập thông tin của sinh viên Poly gồm các thông tin sau:  Tên, Năm Sinh, Ngành Học --> In ra: Tên, Năm Sinh, Ngành Học, Tuổi
             *
             * Bài 3: Viết 1 chương trình: (2 cách giải)
             *  + Khai báo 1 biến cố định năm sinh của bản thân (int a = 2000)
             *  + Cho người dùng nhập vào thông tin sau: Tên, Giới tính(1- Nam và 0 - Nữ, Năm sinh)
             *  + Khi in ra màn hình dựa vào tuổi người nhập vào và giới tính thì in ra như sau:
             *  + Nếu là NAM lớn tuổi thì in ra CHÀO ANH + TÊN + TUỔI + GIỚI TÍNH
             *  + Nếu là NAM ít tuổi thì in ra CHÀO EM + TÊN + TUỔI + GIỚI TÍNH
             *  + Nếu là NỮ lớn tuổi thì in ra CHÀO CHỊ + TÊN + TUỔI + GIỚI TÍNH
             *  + Nếu là NỮ ít tuổi thì in ra CHÀO EM + TÊN + TUỔI + GIỚI TÍNH
             *  + NẾU Bằng tuổi thì in ra CHÀO BẠN + TÊN + TUỔI + GIỚI TÍNH
             */
            do
            {
                string ten;
                int namSinhBanThan = 1989,namsinh,gioitinh;
                Console.WriteLine("Mời bạn nhập tên: ");
                ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập giới tính (1-NAM | 0-NỮ): ");
                gioitinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                namsinh = Convert.ToInt32(Console.ReadLine());
                string anh = (gioitinh == 1) && (namSinhBanThan > namsinh) ? "Anh" : null;
                string chi = (gioitinh == 0) && (namSinhBanThan > namsinh) ? "Chị" : null;
                Console.WriteLine("Chào {0} {1}",(anh == null && chi == null)?"Em":anh!=null?"Anh":"Chị",ten);
            } while (true);
        }
    }
}
