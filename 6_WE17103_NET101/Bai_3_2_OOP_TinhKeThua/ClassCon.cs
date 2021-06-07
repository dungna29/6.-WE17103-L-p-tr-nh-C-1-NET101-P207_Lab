using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_OOP_TinhKeThua
{
    //Trong java và C# là đơn kế thừa
    class ClassCon: ClassCha//Kế thừa thông qua dấu :
    {
        //Là các thuộc tính đăng trưng riêng để miêu tả đối tượng
        private string nganhHoc = "UDPM";

        public ClassCon()
        {
            
        }
        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public ClassCon(string msv, string ten, int namSinh, string nganhHoc) : base(msv, ten, namSinh)
        {
            this.nganhHoc = nganhHoc;
            //this dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            // base dùng để tham chiếu để các thuộc tính hoặc phương thức của lớp cha
        }

        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }

        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.
        public override void inRaManHinh2()//Ghi đè phương thức của cha
        {
            //base.inRaManHinh2();
            Console.WriteLine("Lớp con đã thay đổi text");

            
        }
    }
}
