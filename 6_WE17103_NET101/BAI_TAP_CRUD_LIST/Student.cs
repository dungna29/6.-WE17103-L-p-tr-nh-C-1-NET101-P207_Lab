using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_CRUD_LIST
{
    class Student
    {
        private string msv;
        private string ten;
        private int namSinh;
        private string nganhHoc;

        public Student()
        {

        }

        public Student(string msv, string ten, int namSinh, string nganhHoc)
        {
            this.msv = msv;
            this.ten = ten;
            this.namSinh = namSinh;
            this.nganhHoc = nganhHoc;
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

        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine($"{Msv} | {Ten} | {NamSinh} | {2021 - NamSinh} | {NganhHoc}");
        }
    }
}
