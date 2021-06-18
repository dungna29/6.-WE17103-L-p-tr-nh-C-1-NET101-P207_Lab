using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_TAP_CHUA
{
    class Program
    {   //Toàn biến toàn cục sẽ được khai báo trên đầu
        private Student _student;//khai báo đối tượng
        private string _input;//khai báo
        private List<Student> _lstStudents = new List<Student>();//Khai báo để lưu nhiều Obj
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program p = new Program();
            p.TestAnhChiEm();

         
        }
        public void addNStudentsList()
        {
            do
            {
                Console.Write("Mời bạn nhập số lượng SV: ");
                _input = Console.ReadLine();
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _student = new Student();
                    Console.Write("Mời bạn nhập mã: ");
                    _student.Msv = Console.ReadLine();
                    Console.Write("Mời bạn nhập tên: ");
                    _student.Ten = Console.ReadLine();
                    _lstStudents.Add(_student);
                }
                Console.WriteLine("Bạn có muốn nhập tiếp hay không? 1/Có | 2/Không: ");
                _input = Console.ReadLine();
            } while (_input=="1");
        }

        void TestAnhChiEm()
        {
            while (true)
            {
                ClassThongTin c = new ClassThongTin();
                Console.Write("Mời bạn nhập tên: ");
                c.Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập năm sinh: ");
                c.NamSinh = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("Mời bạn nhập giới tính 1/Nam 2/Nữ: ");
                c.GioiTinh = Convert.ToInt32(Console.ReadLine());
                c.InRaManHinh();
            }
        }
    }
}
