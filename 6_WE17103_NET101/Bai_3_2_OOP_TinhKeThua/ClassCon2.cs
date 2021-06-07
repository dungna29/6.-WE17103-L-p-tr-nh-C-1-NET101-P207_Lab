using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_OOP_TinhKeThua
{
    class ClassCon2 :ClassCha
    {
        private string thuocTinhDangRiengCuaClassCon2;

        public ClassCon2()
        {
            
        }

        public ClassCon2(string msv, string ten, int namSinh, string thuocTinhDangRiengCuaClassCon2) : base(msv, ten, namSinh)
        {
            this.thuocTinhDangRiengCuaClassCon2 = thuocTinhDangRiengCuaClassCon2;
        }

        public string ThuocTinhDangRiengCuaClassCon2
        {
            get => thuocTinhDangRiengCuaClassCon2;
            set => thuocTinhDangRiengCuaClassCon2 = value;
        }

        public override void inRaManHinh2()
        {
            base.inRaManHinh2();
        }
    }
}
