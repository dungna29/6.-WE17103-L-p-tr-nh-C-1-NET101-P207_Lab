using System;
using System.Text;

namespace Bai_1._8_CauLenh_Else_If
{
    class Program
    {
        /*
      * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện khác nhau và thực hành động tương ứng với từng điều kiện. Else If phải luôn True thì mới thực hiện hành động bên trong nó.
      *
      * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong điều kiện đó mà thôi.
      *
      * Công thức:
      *   if (true)
         {
             //Thực hiện 1 hành động nếu If đúng
         }else if (<Điều kiện 1>)
         {
             //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
         }else if (<Điều kiện 2>)
         {
             //Tương tự
         }else
         {
             //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
         }
      */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            double diemChsarp = 9;
            if (diemChsarp>=9 && diemChsarp<=10)
            {
                Console.WriteLine("Xuất Sắc");
            }else if (diemChsarp >=8 && diemChsarp <9)
            {
                Console.WriteLine("Giỏi");
            }else if (diemChsarp >= 7 && diemChsarp < 8)
            {
                Console.WriteLine("Khá");
            }else if (diemChsarp >= 5 && diemChsarp < 7)
            {
                Console.WriteLine("Trung bình");
            }
            else
            {
                Console.WriteLine("Mời bạn học lại Csharp1");
            }
        }
    }
}
