using System;
using System.Text;

namespace Bai_1._2_BienLaGi
{
    class Program
    {
        /*
   * Bài 1.1 Khai báo biến
   * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến
   * được khở tạo trong bộ nhớ ảo(RAM) khi chương trình khởi chạy.
   *
   * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
   *      Khai báo nhiều biến có cùng kiểu dữ liệu trên cùng 1 dòng:
   *      <Kiểu dữ liệu> <Tên Biến1> = <Giá trị>, <Tên Biến2> = <Giá trị>, <tên biến n>;
   * 1. <Kiểu dữ liệu>
   *  + Số nguyên:sbyte, byte, long, int
   *  + Sô thực: float, double, decimal
   *  + Chuỗi hoặc ký tự: string, char 
   *  + Logic: bool
   *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
   * 2. <Tên Biến>
   *  + Quy tắc:
   *      - Tên biến phải có nghĩa
   *      - Có phân biệt chữ hoa chữ thường
   *      - Không bắt đầu bởi số, không dùng từ khóa
   *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
   *  + Khai báo tên biến với 2 từ trở lên:
   *      - Cách 1: normal = firstname
   *      - Cách 2: CamelCase = FirstName, firstName
   *      - Cách 3: Under_Score = first_name, first_Name
   *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
   *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
   *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
   *      - int _year = 1989;
   * 3.<Giá trị>
   *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
   *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
   *
   */
        //Khai báo biến ra bên ngoài được gọi là khai báo biến toàn cục
         int _namSinh = 1989;//Khai báo biến toàn cục
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Chuỗi
            string ten1;//Khai báo 1 biến có kiểu dữ liệu string và không khởi tạo giá trị ban đầu
            string ten2 = "Trịnh Văn Bô";//Khai báo 1 biến có kiểu dữ liệu string và có không khởi tạo giá trị ban đầu
            string ten3, ten4, ten5 = "C#1";

            //Gán giá trị cho biến dùng toán tử =
            ten1 = "FPT POLY";

            //2. Số nguyên
            int year1 = 2021;
            byte year2 = 200;
            long year3 = 2020;

            //3. Số thực
            float diemCsharp1 = 6.5f;
            double diemCsharp2 = 9.9;

            //4. Kiểu ký tự
            char c1 = '1';
            char c2 = 'a';
            char c3 = '%';

            //5. Logic 
            bool temp1 = true;
            bool temp2 = false;

            //6. var
            var temp3 = "a";//String
            var temp4 = 2021;//int
            var temp5 = true;//bool
            var temp6 = '5';//char
            var temp7 = 9.6;//double3
            //var temp8;//Phải khởi tạo giá trị cho kiểu dữ liệu var ngay khi sử dụng

            /*
             * Bài tập: Tự triển khai các kiểu dữ liệu trên và in nó ra màn hình 10 phút. 13h15.
             * cw + tab
             */
          

        }
    }
}
