using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_OOP_TinhKeThua
{
    class ClassCha
    {
        //Tại lớp cha sẽ có các thuộc tính chung 
        private string msv;
        private string ten;
        private int namSinh;

        public ClassCha()
        {
            
        }

        public ClassCha(string msv, string ten, int namSinh)
        {
            this.msv = msv;
            this.ten = ten;
            this.namSinh = namSinh;
        }

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

        public void inRaManHinh1()
        {

        }
        //Có từ khóa vitual để giúp cho thằng con khi kế thừa lại có thể ghi đè phương thức
        public virtual void inRaManHinh2()
        {
            Console.WriteLine("Đây là inRaManHinh2() từ lớp cha");
        }
    }
}
