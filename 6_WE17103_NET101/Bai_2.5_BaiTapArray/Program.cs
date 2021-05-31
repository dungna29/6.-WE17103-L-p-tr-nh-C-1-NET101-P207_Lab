using System;
using System.Text;

namespace Bai_2._5_BaiTapArray
{
    class Program
    { /*
        Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
        
        Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điểm thông báo Trượt hoặc đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bài 1:
            int[] arrNumbers;//Khai báo
            Console.WriteLine("Mời bạn nhập số lượng: ");
            arrNumbers = new int[Convert.ToInt32(Console.ReadLine())];//Khởi tạo
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine("Mời bạn nhập vào Index " + i +" : ");
                arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("=====Bạn đã hoàn thành việc nhập  dữ liệu=====");
            Console.WriteLine("Dãy số chẵn bạn vừa nhập là: ");
            foreach (var x in arrNumbers)
            {
                if (x %2 == 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine("Dãy số lẻ bạn vừa nhập là: ");
            foreach (var x in arrNumbers)
            {
                if (x % 2 != 0)
                {
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
