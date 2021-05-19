using System;
using System.Text;

namespace Bai_2._0_CauLenh_Switch_Case
{
    class Program
    {
        /*
         * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
         *
         * Công thức: sw + tab
         *
         *  switch (<Biểu thức>)
            {
                case <giá trị 1>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break; 
                case <giá trị 2>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                .......
                case <giá trị n>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                default:
                    Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                    break;
            }
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Ví dụ 1: Lựa chọn người dùng có kiểu int
            int choice1 = 3;
            switch (choice1)//Truyền vào switch
            {
                case 1:
                    //Thực hiện 1 hành động khi vào case1
                    Console.WriteLine("Món ăn số 1");
                    break;
                case 2:
                    //Thực hiện 1 hành động khi vào case2
                    Console.WriteLine("Món ăn số 2");
                    break; 
                case 3:
                    //Thực hiện 1 hành động khi vào case3
                    Console.WriteLine("Món ăn số 3");
                    break;
                default:
                    //Khi không vào trường hợp nào thì sẽ vào đây
                    Console.WriteLine("Món ăn bạn chọn không tồn tại");
                    break;
            }

            //Ví dụ 2: Lựa chọn người dùng có kiểu string
            string choice2 = "a";
            switch (choice2)
            {
                case "a":
                    break;
                case "b":
                    break;
                case "c":
                    break;
                default:
                    break;
            }
            //Ví dụ 3: Lựa chọn người dùng có kiểu char
            char choice3 = '+';
            switch (choice3)
            {
                case '+':
                    break;
                case '-':
                    break;
                case 'x':
                    break;
                case ':':
                    break;
                default:
                    break;
            }

        }
    }
}
