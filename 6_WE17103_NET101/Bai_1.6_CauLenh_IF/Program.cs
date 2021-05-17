using System;
using System.Text;

namespace Bai_1._6_CauLenh_IF
{
    class Program
    {
        /*
         * Bài 1.5 Câu điều kiện rẽ nhánh IF
         * ĐƯợc sử dụng để lập điều kiện và sẽ thực thi 1 hành động nào đó nếu thỏa mãn điều kiện.
         *
         * Công thức IF: if + tab            
         *   if (<Điều kiện>)
            {
                If phải luôn đúng
                Một hành động được thi khi thỏa mãn điều kiện
            }
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            if (true)
            {
                Console.WriteLine("Thực hiện hành động 1");
            }

            if (false)
            {
                Console.WriteLine("Thực hiện hành động 2");
            }

            if (8>9 && 9>8)//Trường hợp này mệnh đề if = false
            {
                Console.WriteLine("Thực hiện hành động 3");
            }
            if (8>9 || 9>8)//Trường hợp này mệnh đề if = true
            {
                Console.WriteLine("Thực hiện hành động 4");
            }
        }
    }
}
