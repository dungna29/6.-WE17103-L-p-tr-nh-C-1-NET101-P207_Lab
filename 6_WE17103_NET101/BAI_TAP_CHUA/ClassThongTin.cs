using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_CHUA
{
    class ClassThongTin
    {
        private int namSinhBanThan = 1995;
        private int gioiTinh;//1 - Nam 2 - Nữ
        private int namSinh;
        private string ten;

        public ClassThongTin()
        {
            
        }

        public ClassThongTin(int namSinhBanThan, int gioiTinh, int namSinh, string ten)
        {
            this.namSinhBanThan = namSinhBanThan;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.ten = ten;
        }

        public int NamSinhBanThan
        {
            get => namSinhBanThan;
        }

        public int GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public void InRaManHinh()
        {
            //1995 < 1994
            //Anh - Chị - EM - Bạn
            string temp = (gioiTinh == 1) && (namSinhBanThan > namSinh) ? "Anh" :
                (gioiTinh == 2) && (namSinhBanThan > namSinh) ? "Chị" :
                (namSinhBanThan == namSinh) ? "Bạn" : "Em";
            Console.WriteLine("Chào {0} {1}", temp,ten);
        }
    }
}
