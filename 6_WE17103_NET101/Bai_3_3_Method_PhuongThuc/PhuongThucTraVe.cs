using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_3_Method_PhuongThuc
{
    class PhuongThucTraVe
    {

        /*
         *  Phương thức trả về là :
         *   Công thức chung:
         *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
         *  {
         *          Body code
         *          return <Kiểu trả về của phương thức>
         *  }
         */

        //Phương thức trả về không tham số
        /*
         * Hướng dẫn sử dụng:
         *      1. Phương thức phải có kiểu trả về là các kiểu dữ liệu...
         *      2. Phải Sử dụng return <giá trị hoặc tập giá trị> đúng với kiểu dữ liệu
         */
        // public void TinhTong()// () không tham số
        // {
        //     int a, b;
        //     Console.WriteLine("Mời bạn nhập số thứ 1: ");
        //     a = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Mời bạn nhập số thứ 2: ");
        //     b = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Tổng 2 số: " + (a + b));
        // }

        //Phần 1: Phương thức trả về không tham số
        public int TinhTong()
        { 
            int a, b;
            Console.WriteLine("Mời bạn nhập số thứ 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số thứ 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            return a+b;//Trả về tổng 2 số đúng kiểu dữ liệu của phương thức
        }
        //Phương thức trả về kiểu mảng
        public string[] getYears1600_2021()
        {
            //Tạo 1 mảng từ năm 1600 đến 2021
            string[] arrYears = new string[2021-1600];
            int temp = 1600;
            for (int i = 0; i < arrYears.Length; i++)
            {
                arrYears[i] = Convert.ToString(temp);
                temp++;
            }

            return arrYears;
        }
        //Phương thức trả về có tham số tương tự như bên VOID
    }
}
