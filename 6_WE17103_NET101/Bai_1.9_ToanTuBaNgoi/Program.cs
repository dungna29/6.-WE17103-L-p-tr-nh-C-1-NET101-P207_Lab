using System;
using System.Text;

namespace Bai_1._9_ToanTuBaNgoi
{
    class Program
    {
        /*
        * TOÁN TỬ 3 NGÔI
        * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
        */
        static void Main(string[] args)
        {
            //Lưu ý kiểu dữ liệu biến ảnh hưởng đến kết quả trả về
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string temp1 = 9 > 8 ? "Đúng" : "Sai";
            Console.WriteLine(temp1);
            int temp2 = 9 > 8 ? 1 : 0;
            bool temp3 = 9 > 8 ? true : false;
            double temp4 = 9 > 8 ? 1 : 0;
        }
    }
}
