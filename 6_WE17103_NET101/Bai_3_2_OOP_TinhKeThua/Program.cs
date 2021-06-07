using System;

namespace Bai_3_2_OOP_TinhKeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khi kế thừa lớp con thừa hưởng các thuộc tính của cha và không cần phải khai báo lại
            ClassCha cha = new ClassCha();
            cha.inRaManHinh2();
            ClassCon con = new ClassCon();
            con.inRaManHinh2();



            con.Msv = "PH123";
            con.NamSinh = 2000;
            con.Ten ="Hoang";
            con.NganhHoc = "123";
        }
    }
}
