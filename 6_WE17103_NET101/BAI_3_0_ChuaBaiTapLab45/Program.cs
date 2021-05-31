using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_3_0_ChuaBaiTapLab45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
        }

        static void B2NhapArrSinhVien()
        {
            //Khai báo nơi lưu trữ dữ liệu
            String[] arrTen;
            int[] arrNs;
            String[] arrMsv;
            int size, flag = 1;
            //Triển khai
            Console.WriteLine("Mời bạn nhập kích thước mảng: ");
            size = Convert.ToInt32(Console.ReadLine());
            //Sau khi có số lượng do người dùng nhập thì bắt đầu khởi tạo mảng
            arrTen = new string[size];
            arrNs = new int[size];
            arrMsv = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Mời bạn nhập tên của index{0}: " + flag);
                arrTen[i] = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                arrNs[i] = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Mời bạn nhập mã sinh viên:");
                arrMsv[i] = Console.ReadLine();
                flag++;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Tên: {0} Năm sinh:{1} Tuổi: {2} Mã SV: {3}",arrTen[i], arrNs[i],2021 - arrNs[i], arrMsv[i]);
            }

        }

        static void B3NhapSinhVienSuDungList()
        {
            //Khai báo nơi lưu trữ dữ liệu
            List<string> lstTen = new List<string>();
            List<int> lstNs = new List<int>();
            List<string> lstMsv = new List<string>();
            int size, flag = 1;
            Console.WriteLine("Bạn muốn thêm bao nhiêu sv: ");
            size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Mời bạn nhập tên của index{0}: " + flag);
                lstTen.Add(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                lstNs.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Mời bạn nhập mã sinh viên:");
                lstMsv.Add(Console.ReadLine());
                flag++;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Tên: {0} Năm sinh:{1} Tuổi: {2} Mã SV: {3}", lstTen[i], lstNs[i], 2021 - lstNs[i], lstMsv[i]);
            }

        }
    }
}

