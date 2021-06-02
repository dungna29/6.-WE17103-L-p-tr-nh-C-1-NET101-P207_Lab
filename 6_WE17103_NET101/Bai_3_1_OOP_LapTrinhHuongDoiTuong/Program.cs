﻿using System;
using System.Text;

namespace Bai_3_1_OOP_LapTrinhHuongDoiTuong
{
    class Program
    {
        #region Lập trình hướng đối tượng - OOP
        /*
         * Đối tượng là gì?: Sinh Viên, Giáo Viên, Con Người...., Chó, Mèo, Cá.... Máy tính, Màn Hình, Chuột, Bàn phím..... Hoa, Cây, Cỏ, Hoa Hồng.....(Danh từ)
         *
         * Thông tin của đối tượng giúp miêu tả đối tượng đó một cách tường minh hơn nhưng trong ngành khoa học máy tính không gọi là thông tin của đối tượng mà gọi là thuộc tính. Ví dụ: Bút(Loại bút, Mầu sắc, Hãng nào, Chiều dài.....)
         *
         * Hành động của đối tượng thì phải là động từ và nó ám chỉ các hành động của một đối tượng ngoài thế giới thực.
         *
         * Định nghĩa Dungna: Lập trình hướng đối tượng (OOP - Object Oriented Programing) là đưa các đối tượng có trong thế giới thực vào trong lập trình để thao tác với các đối tượng đó như (thêm, sửa, xóa.....) hoặc thao tác với các thuộc tính của đối tượng đó. Ngoài ra các hành động của đối tượng trong lập trình sẽ chính là các Method(Phương thức) giúp thực hiện một hành động nào đó.
         *
         *2. 4 Tính chất của OOP:
           + Đa hình (Polymorphism): Nó thể hiện rõ nhất khi gọi đến một phương thức của đối tượng giống nhau nhưng kết quả của phương thức đó có thể khác nhau.
               - Nạp chồng (Overloading): Nạp chồng phương thức cùng tên cùng kiểu phương thức nhưng khác tham số truyền vào. Khi đưa đúng số lượng tham số truyền vào sẽ gọi đúng phương thức cần được thực hiện.
               - Ghi đè (Overriding): Ghi đè phương thức có cùng tên cùng tham số giữa lớp cha và lớp con. Các phương thức của lớp con kế thừa từ lớp cha từ kiểu phương thức, tên, tham số truyền vào nhưng tại các lớp con có thể viết lại code hành động khác theo nghiệp vụ của nó với phương thức được kế thừa.
           + Thừa kế (Inheritance): Cho phép định nghĩa một lớp đối tượng dựa trên các thuộc tính có sẵn của một lớp đã có.
           + Đóng gói (Encapsulation):Tức là trạng thái của đối tượng được bảo vệ không cho các truy cập từ code bên ngoài như thay đổi trong thái hay nhìn trực tiếp. Việc cho phép môi trường bên ngoài tác động lên các dữ liệu nội tại của một đối tượng theo cách nào là hoàn toàn tùy thuộc vào người viết mã. Đây là tính chất đảm bảo sự toàn vẹn, bảo mật của đối tượng Trong C#, tính đóng gói được thể hiện thông qua phạm vi truy cập (access modifier). Ngoài ra, các lớp liên quan đến nhau có thể được gom chung lại thành package.
               - Có hai loại modifier trong: access modifiers và non-access modifiers.
               * Có 4 kiểu của java access modifiers:
               - private
               - (Mặc định)
               - protected
               - public
               * non-access modifiers chẳng hạn static, abstract, synchronized, native, volatile, transient, v.v..
           + Trừu tượng (Abstraction): Trừu tượng có nghĩ là tổng quát hóa một cái gì đó lên. không cần chú ý chi tiết bên trong.
               - Tính trừu tượng là một tiến trình ẩn các chi tiết trình triển khai và chỉ hiển thị tính năng tới người dùng. Tính trừu tượng cho phép bạn loại bỏ tính chất phức tạp của đối tượng bằng cách chỉ đưa ra các thuộc tính và phương thức cần thiết của đối tượng trong lập trình.
               - Tính trừu tượng giúp bạn tập trung vào những cốt lõi cần thiết của đối tượng thay vì quan tâm đến cách nó thực hiện.
               - Trong C#, chúng là sử dụng abstract class và abstract interface để có tính trừu tượng.
           3. Khái niệm
           - Class: Chúng ta có thể xem lớp như một khuôn mẫu (template) của đối tượng (Object). Trong đó bao gồm dữ liệu của đối tượng (fields hay properties) và các phương thức(methods) tác động lên thành phần dữ liệu đó gọi là các phương thức của lớp. Class là từ khóa để khai báo lớp. 
           - Đối tượng (Object): được xem là một thực thể trong thế giới thực.
           - Object bao gồm: Thuộc tính (Attribute/Method)
           - Attribute: Các thuộc tính của đối tượng
           - Phương thức:  Phương thức hay còn gọi là hàm thành viên Một phương thức là một nhóm lệnh cùng nhau thực hiện một tác vụ
           - Từ khóa this trong C# là một biến tham chiếu được sử dụng để tham chiếu tới đối tượng của lớp hiện tại.
         */


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Tôi là người chưa được học OOP
            //Yêu cầu lưu trữ 500 sinh viên - Tên, Năm Sinh, Quê quán
            string ten, quequan;
            int namsinh;

            //Phần 1: Khai báo và khởi tạo đối tượng cần phải biết tên đối tượng
            SinhVien sv1;//Khai báo
            sv1 = new SinhVien();//Khởi tạo 1 đối tượng
            SinhVien sv2 = new SinhVien("PH00555", "Dũng", 1999, "UDPM");

            //Phần 2: Gán giá trị cho đối tượng sử dụng Contructor có thâm số hoặc chấm các thuộc tính
            sv1.Msv = "PH99999";
            sv1.Ten = " Chsarp";

            //Phần 3 Lấy giá trị của thuộc tính bằng phương thức hoặc Property
            sv2.inRaManHinh();
            Console.WriteLine(sv1.Msv + " " + sv1.Ten);

        }
    }
}
