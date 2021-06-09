using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_3_Method_PhuongThuc
{
    class Void_PhuongThucKhongTraVe
    {
        /*
       *  Phương thức không trả về là : Void
       *   Công thức chung:
       *  <Phạm vi truy cập> <Kiểu phương thức> <Tên phương thức> (<Danh sách tham số>)
       *  {
       *          Body code
       *  }
       */

        //Phần 1: Phương thức trả về không tham số
        public void TinhTong()// () không tham số
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số thứ 1: ");
            a = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Mời bạn nhập số thứ 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tổng 2 số: " + (a + b));
        }
        //Phần 2: Phương thức không trả về có tham số
        // public void TinhTong() //Không thể đặt tên trùng với tên phương thức đã tồn tại
        // {
        //
        // }

        //Tính đa hình có nạp chồng phương trong file lý thuyết của thầy
      
        public void TinhTong(int a, int b)//int a, int b tham số của phương thức
        {
            Console.WriteLine("Tổng 2 số: " + (a + b));
        } 
        public void TinhTong(int a, int b, int c)//int a, int b tham số của phương thức
        {
            Console.WriteLine("Tổng 3 số: " + (a + b + c));
        }
        public void TinhTong(int a, int b, int c, int d)//int a, int b tham số của phương thức
        {
            Console.WriteLine("Tổng 4 số: " + (a + b + c + d));
        }

        //Ngoài ra tham số có thể bao gồm rất nhiều kiểu dữ liệu khác nhau và kể cả kiểu đối tượng
        public void method1(char a,int[] arrNumber, List<string> lstString)
        {
            foreach (var x in arrNumber)
            {
                Console.WriteLine(x);
            }
        }
    }
}
