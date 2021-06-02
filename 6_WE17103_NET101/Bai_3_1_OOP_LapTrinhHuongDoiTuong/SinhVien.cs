using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3_1_OOP_LapTrinhHuongDoiTuong
{
    //1. Đối tượng là danh từ và viết hoa chữ cái đầu của từ
    class SinhVien
    {
        //Phần 1: Liệt kê toàn bộ các thuộc tính mà đối tượng phải có
        private string msv;
        private string ten;
        private int namSinh;
        private string nganhHoc = "UDPM";
        //Phần 2: Contructor
        /*
         * 1 - Contructor giống với tên đối tượng
         * 2 - Contructor là thành phần được chạy vào đầu tiên khi khởi tạo đối tượng.
         * 3 - Khi mới học mỗi đối tượng luôn có 2 Contructor 1 là có tham số 2 là không tham số.
         */
        //Contructor không tham số: ctor + tab
        public SinhVien()
        {
            // Console.WriteLine("Đây là text in ra từ contructor");
        }
        /*
         Nếu bạn nào dùng resharper ctorf + tab
         Đối với các bạn không cài resharper muốn gọi contructor có tham số:
            1. Chuột phải vào Class đối tượng chọn Quick Actions....
            2. Generate Contructor và bấm ok
         */
        public SinhVien(string msv, string ten, int namSinh, string nganhHoc)
        {
            this.msv = msv;
            this.ten = ten;
            this.namSinh = namSinh;
            this.nganhHoc = nganhHoc;
        }

        //Phần 3: Triển khai property của thuộc tính
        /*
         * Bôi đen vào các thuộc tính đang có hiện tại của lớp sau đó chuột phải --> Quick Actions....
         * Chọn Encapsulate fields
         *
         */
        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }

        /*
         * Phần 4: Các phương thức của đối tượng
         */
        public void inRaManHinh()
        {
            Console.WriteLine("{0} {1} {2} {3}",msv,ten,namSinh,nganhHoc);
        }
    }
}
