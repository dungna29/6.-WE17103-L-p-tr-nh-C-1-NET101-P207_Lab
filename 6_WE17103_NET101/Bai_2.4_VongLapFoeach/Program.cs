using System;

namespace Bai_2._4_VongLapFoeach
{
    class Program
    {
        /*
         * Vòng lặp foreach
         * Cách gõ: fore + tab
         *
         * Công thức:
         *  foreach (var VARIABLE in COLLECTION)
            {
                
            }
            var: Kiểu dữ liệu đã học ở bài khai báo biến
            VARIABLE: tên biến có thể đặt tùy ý và nó đại diện cho kiểu dữ liệu.
            COLLECTION//Array: Phải là 1 tập hợp nhiều giá trị.
         */
        static void Main(string[] args)
        {
            string[] arrName = {"UDPM", "WEB", "MOB"};
            foreach (var x in arrName)
            {
                Console.WriteLine(x);
            }
        }
    }
}
