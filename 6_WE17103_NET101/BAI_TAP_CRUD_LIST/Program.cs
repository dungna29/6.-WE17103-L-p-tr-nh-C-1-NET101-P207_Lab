using System;

namespace BAI_TAP_CRUD_LIST
{
    class Program
    {
        /*
         * Biết cách Thêm - Sửa - Xóa  1 đối tượng SinhVien         
         */
        static void Main(string[] args)
        {
          //Program sẽ là nơi code Menu ở đây
          StudentService sv = new StudentService();
          do
          {
              Console.WriteLine("Menu Quản lý sinh viên");
              Console.WriteLine("1. Thêm");
              Console.WriteLine("2. Sửa");
              Console.WriteLine("3. Xóa");
              Console.WriteLine("4. Tìm kiếm");
              Console.WriteLine("5. Tìm kiếm theo ngành");
              Console.WriteLine("6. Thoát");
              Console.Write("Mời bạn chọn chức năng: ");
              string input = Console.ReadLine();
              switch (input)
              {
                    case "1":
                        sv.addNStudentsList();
                        break;
                    case "2":
                        sv.editStudentByMsvList();
                        break;
                    case "3":
                        sv.removeStudentByMsvList();
                        break;
                    case "4":
                        sv.findStudentByMsvList();
                        break;
                    case "5":
                        sv.findStudentByNganhList();
                        break;
                    default:
                        break;
              }
          } while (true);
        }
    }
}
