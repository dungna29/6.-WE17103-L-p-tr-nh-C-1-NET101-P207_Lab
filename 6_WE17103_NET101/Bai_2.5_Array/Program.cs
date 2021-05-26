using System;

namespace Bai_2._5_Array
{/*
        * Phần 1: Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán;
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
    class Program
    {
        static void Main(string[] args)
        {
            //PHần 1: Khai báo biến
            //<Kiểu dữ liệu> <tên biến> = <giá trị>;
            int a = 5;
            a = 10;

            //Phần 2: Khai báo 1 mảng:
            int[] arrNumber1;
            arrNumber1 = new int[5];//Khởi tạo 1 mảng int có kích thước là 5

            string[] arrNames = new string[5];
            int[] arrYears = {2001, 2002, 2003};//Khởi tạo 1 mảng có 3 phần tử
            int[] arrYears1 = new int[] { 2001, 2002, 2003 };//Cách viết tường minh hơn

            var arrName2 = new string[5];
            var arrDiem = new double[5];

            //Phần 3: Gán gia trị
            //arrNumber1 = 5; Không xác định được gia trị sẽ được gán vào index nào
            arrNumber1[0] = 5;
            arrNumber1[1] = 55;
            arrNumber1[2] = 66;
            arrNumber1[0] = 10;

            //Phần 4: Lấy giá trị trong mảng
            //arrNumber1[0] = Giá trị của mảng tại index
            Console.WriteLine(arrNumber1[0]);
            Console.WriteLine(arrNumber1[1]);
            Console.WriteLine(arrNumber1[2]);
            Console.WriteLine(arrNumber1[3]);
            Console.WriteLine(arrNumber1[4]);
            //Console.WriteLine(arrNumber1[5]);//System.IndexOutOfRangeException: 

            for (int i = 0; i < arrNumber1.Length; i++)
            {
                Console.Write(arrNumber1[i] + " ");
            }

            Console.WriteLine();
            foreach (int x in arrNumber1)
            {
                Console.Write(x + " ");
            }

        }
    }
}
