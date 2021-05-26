using System;
using System.Xml;

namespace Bai_2._3_ViTongHopVongLap
{
    class Program
    {
        /*
         * Luyện trên lớp bài về vòng lặp
         * Tạo 1 menu bào gồm các bài sau:
         *      1. Cho người nhập vào 1 bảng cửu chương và in ra. (Khó dùng do while hoặc While để in)
         *      2. In tất cả các bảng cửu chương.(Khó dùng do while hoặc While để in)
         *      3. In tất cả bảng cửu chương từ 1 đến 5 trong đó không in bảng nhân 2.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Viết 1 chương trình");
            Console.WriteLine("Mời bạn nhập vào điểm C#: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (Convert.ToInt32(temp)>=10)
            {
                Console.WriteLine("Dungna29");
            }

            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine("Xin chào các bạn đến với học lập trình");
            }

            //Chữa bài bỏ qua 1 bảng cửu chương
            for (int i = 1; i < 10; i++)
            {
                if (i == 7)//Bỏ qua lượt chạy i = 7
                {
                    continue;
                }
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}",i,j,i*j);
                }
            }
        }

        static void chuaBaiTheoKhoangBangCuuChuong()
        {
            int khoang1, khoang2;
            
            //Cách 1: Linh hoạt
            // if (khoang1 > khoang2)
            // {
            //     int temp = khoang1;
            //     khoang1 = khoang2;
            //     khoang2 = temp;
            // }

            //Cách 2: Yêu cầu khoảng 1 phải lớn 2 bắt buộc
            do
            {
                Console.WriteLine("Mời bạn nhập khoảng 1: ");
                khoang1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập khoảng 2: ");
                khoang2 = Convert.ToInt32(Console.ReadLine());
                if (!(khoang1 < khoang2))
                {
                    Console.WriteLine("Khoảng 1 không thể nhỏ hơn khoảng 2");
                }
            } while (!(khoang1 < khoang2));
            for (int i = khoang1; i <= khoang2; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }
        }
    }
}
