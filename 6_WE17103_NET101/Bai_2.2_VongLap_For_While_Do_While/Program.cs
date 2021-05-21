using System;
using System.Text;

namespace Bai_2._2_VongLap_For_While_Do_While
{
    class Program
    {
        #region Định nghĩa Vòng Lặp

        #region 1. Vòng lặp for
        /*
        * Vòng lặp for
        *
        * Cách gõ: for + tab
        * Công thức:
        *  for (int i = 0; i < UPPER; i++)
           {
               //Thực hiện 1 hành động lặp lại 1 công việc nào đó.
           }
           int i = 0: Điểm bắt đầu của vòng lặp
           i < UPPER: Điều kiện để ngắt vòng lặp
           i++: Tăng i lên 1
        */


        #endregion

        #region 2. While
        /*
         * Bài 2.0 Vòng lặp:
         *
         * Định nghĩa chung cho tất cả vòng lặp:
         * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
         *
         * Các loại vòng lặp: while, do..while, for, foreach
         *
         * Từ khóa sử dụng trong vòng lặp:
         *
         * break - ngắt vòng lặp
         * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
         *
         * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
         * + Cách dùng: wh + tab
         *
         * + Công thức:
         *  while (true)
            {
                //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
            }
         */


        #endregion

        #region 3. Vòng lặp do..While

        /*
          * Bài 2.1 Vòng lặp do..While khác với vòng lặp while đó là sẽ thực hiện hành động 1 lần kể cả khi while(False). Điều kiện kiện để chạy vòng lặp vẫn là While(true)
          *
          * Cách gõ: do + tab
          *
          * Công thức:
          *  do
             {
                 //Thực hiện ít nhất 1 lần nếu While False             
             } while (false);
          */

        #endregion
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Công thức chung dùng vòng lặp:
             * 1 . Điều kiện để vòng lặp chạy là điều kiện luôn đúng
             * 2 . Điểm bắt đầu chạy của vòng lặp hoặc là khởi tạo điểm bắt đầu.
             * 3 . Bước nhẩy để giúp đạt điều kiện dừng vòng lặp.
             */
            //Vòng lặp for: for + tab
            Console.WriteLine("====Vòng lặp for===");    
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("Chào mừng các bạn đến với ngành UDPM " + i);
            // }
            Console.WriteLine("");

            //Vòng lặp while(true): wh + tab
            Console.WriteLine("====Vòng lặp While===");
            // int i = 0;
            // while (i < 5)
            // {
            //     Console.WriteLine("Chào mừng các bạn đến với ngành UDPM " + i);
            //      i++;
            // }

            //Tham khảo với bài này
            bool flag = true;
            int count = 0;
            while (flag)
            {
                Console.WriteLine("Chào mừng các bạn đến với ngành UDPM " + count);
                if (count>5)
                {
                    flag = false;
                }
                count++;
            }

            //Vòng lặp do...while(true): do + tab
            Console.WriteLine("===Vòng lặp do while===");
            int i = 0;
            do
            {
                Console.WriteLine("Chào mừng các bạn đến với ngành UDPM " + i);
                     i++;

            } while (i < 5);


            //Continue và break
            //break: Dùng để ngắt vòng lặp trong điều kiện
            //Continue là bỏ qua đoạn code phía sau để tiến hành lần lặp tiếp theo
            for (int j = 0; j < 5; j++)
            {
                if (j == 2)
                {
                    break;
                }

                Console.WriteLine("Bạn đang học continue: ");
            }
        }
    }
}
