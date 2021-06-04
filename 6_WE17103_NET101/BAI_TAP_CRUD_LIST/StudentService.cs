using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_CRUD_LIST
{
    //Class này sẽ là nơi code các chức năng của đối tượng
    class StudentService
    {
        //Toàn biến toàn cục sẽ được khai báo trên đầu
        private Student _student;//khai báo đối tượng
        private string _input;//khai báo
        private List<Student> _lstStudents;//Khai báo để lưu nhiều Obj
        private Student[] _arrStudents;//Khai báo mảng obj

        public StudentService()
        {
            _lstStudents = new List<Student>();//Khởi tạo List đối tượng để sử dụng khi class StudentService được khởi tạo
            _student = new Student("PH001", "Dũng", 2000, "UDPM");
            _lstStudents.Add(_student);
            _student = new Student("PH002", "Hoàng", 2001, "WEB");
            _lstStudents.Add(_student);
            _student = new Student("PH003", "Nhung", 2002, "UDPM");
            _lstStudents.Add(_student);
            _student = new Student("PH004", "Vương", 2003, "MOB");
            _lstStudents.Add(_student);
        }

        #region Phần 1: Thêm Sửa Xóa với Mảng Tham khảo

        //Chức năng thêm đối tượng vào mảng
        public void addStudentToArray()
        {
            Console.Write("Mời bạn nhập số lượng SV: ");
            _input = Console.ReadLine();
            _arrStudents = new Student[Convert.ToInt32(_input)];
            for (int i = 0; i < _arrStudents.Length; i++)
            {
                _arrStudents[i] = new Student();//Bắt buộc phải khởi tạo đối tượng Student mới sử dụng được.
                Console.Write("Mời bạn nhập mã: ");
                _arrStudents[i].Msv = Console.ReadLine();
                Console.Write("Mời bạn nhập tên: ");
                _arrStudents[i].Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập Năm sinh: ");
                _arrStudents[i].NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập Ngành: ");
                _arrStudents[i].NganhHoc = Console.ReadLine();
            }
        }
        public void findStudentsArray()
        {
            Console.Write("Mời bạn nhập mã cần tìm: ");
            _input = Console.ReadLine();
            foreach (var x in _arrStudents)
            {
                if (x.Msv == _input)
                {
                    x.inRaManHinh();
                }

            }
        }

        public void getStudentsArray()
        {
            foreach (var x in _arrStudents)
            {
                x.inRaManHinh();
            }
        }


        #endregion

        #region Phần 2: Làm việc đối tượng với List

        //Thêm 1 đối tượng do người dùng nhập
        public void add1Student()
        {
            _student = new Student();
            Console.Write("Mời bạn nhập mã: ");
            _student.Msv = Console.ReadLine();
            Console.Write("Mời bạn nhập tên: ");
            _student.Ten = Console.ReadLine();
            Console.Write("Mời bạn nhập Năm sinh: ");
            _student.NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập Ngành: ");
            _student.NganhHoc = Console.ReadLine();
            _student.inRaManHinh();//In 1 đối tượng sau khi nhập
        }

        //Thêm nhiều đối tượng vào List
        public void addNStudentsList()
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
                Console.Write("Mời bạn nhập Năm sinh: ");
                _student.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập Ngành: ");
                _student.NganhHoc = Console.ReadLine();
                _lstStudents.Add(_student);//Sau khi nhập 1 xong đối tượng tiến hành thêm đối tượng vào List
            }
        }
        public void editStudentByMsvList()
        {
            Console.Write("Mời bạn nhập số mã SV cần sửa: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Msv == _input)
                {
                    Console.WriteLine("Bạn  muốn sửa thông tin gi?");
                    Console.WriteLine("1. Sửa tên");
                    Console.WriteLine("2. Sửa năm sinh");
                    Console.WriteLine("3. Sửa ngành học");
                    Console.WriteLine("Mời bạn chọn chức năng: ");
                    _input = Console.ReadLine();
                    switch (_input)
                    {
                        case "1":
                            Console.WriteLine("Mời bạn nhập lại tên: ");
                            _lstStudents[i].Ten = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Mời bạn nhập lại năm sinh: ");
                            _lstStudents[i].NamSinh = Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Mời bạn nhập lại ngành: ");
                            _lstStudents[i].NganhHoc = Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void findStudentByNganhList()
        {
            Console.Write("Mời bạn nhập ngành cần tìm: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].NganhHoc == _input)
                {
                    _lstStudents[i].inRaManHinh();
                }
            }
        }
        public void findStudentByMsvList()
        {
            Console.Write("Mời bạn nhập số mã SV cần tìm: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Msv == _input)
                {
                    _lstStudents[i].inRaManHinh();
                }
            }
        }
        public void removeStudentByMsvList()
        {
            Console.Write("Mời bạn nhập số mã SV cần xóa: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Msv == _input)
                {
                    _lstStudents.RemoveAt(i);
                    Console.WriteLine("Chúc mừng xóa thành công");
                }
            }
        }

        public void getListStudents()
        {
            foreach (var x in _lstStudents)
            {
                x.inRaManHinh();
            }
        }

        #endregion
    }
}
