using System;
using System.Text;

namespace Bai_1._7_CauLenh_Else
{
    class Program
    {
        /*
       * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
       * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
       *
       * Cấu trúc: 
       * if (true)
          {
              Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
          }
          else
          {
              Nếu không thỏa mãn IF thì mặc định là vào ELSE
          }
       */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            double diemCsharp1 = 4.9;
            if (diemCsharp1 >=5)
            {
                Console.WriteLine("Chúc mừng bạn đã qua môn C#1");
            }
            else
            {
                Console.WriteLine("Chúc mừng bạn đã mất 700k");
            }
            /*
            * Viết 1 chương trình nhập điểm GPA C#1
            * Nếu điểm từ 9 đến 10 = Xuất sắc
            * Nếu điểm từ 7 đến 9 = giỏi
            * Nếu điểm từ 6 đến 7 = khá
            * Nếu điểm từ 6 đến 7 = khá
            * Nếu điểm từ 5 đến 6 = Yếu
            * Nếu điểm từ 4 đến 0 = Học lại
            *   - Không được sử dụng else if hoặc chỉ if không để giải bài này mà phải dùng if else
             * + 1 điểm thẳng vào khi đi thi C#1
            */
        }
    }
}
