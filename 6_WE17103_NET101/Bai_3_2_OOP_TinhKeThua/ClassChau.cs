using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_OOP_TinhKeThua
{
    class ClassChau:ClassCon
    {
        private string thuocTinhChau;

        public ClassChau()
        {
            
        }

        public ClassChau(string msv, string ten, int namSinh, string nganhHoc, string thuocTinhChau) : base(msv, ten, namSinh, nganhHoc)
        {
            this.thuocTinhChau = thuocTinhChau;
        }

        public string ThuocTinhChau
        {
            get => thuocTinhChau;
            set => thuocTinhChau = value;
        }

        public override void inRaManHinh2()
        {
            base.inRaManHinh2();
        }
    }
}
