using System;
using System.Text;

namespace Bai_2._7_ThuatToanNoiBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int[] arrNumbers = { 9, 8, 7, 6 };
            //Lần chạy i = 0
            // i = 0 => 9 && j = 1 => 8 ==> 9 > 8 ==> 8 9 7 6
            // i = 0 => 8 && j = 2 => 7 ==> 8 > 7 ==> 7 9 8 6
            // i = 0 => 7 && j = 3 => 7 ==> 6 > 7 ==> 6 9 8 7

            //Lần chạy i = 1
            // i = 1 => 9 && j = 2 => 8 ==> 9 > 8 ==> 6 8 9 7
            // i = 1 => 8 && j = 3 => 8 ==> 7 > 8 ==> 6 7 9 8

            //Lần chạy i = 2
            // i = 2 => 9 && j = 3 => 8 ==> 9 > 8 ==> 6 7 8 9

            // for (int i = 0; i < arrNumbers.Length-1; i++)
            // {
            //     for (int j = i + 1; j < arrNumbers.Length; j++)
            //     {
            //         if (arrNumbers[i] > arrNumbers[j])
            //         {
            //             int temp = arrNumbers[i];
            //             arrNumbers[i] = arrNumbers[j];
            //             arrNumbers[j] = temp;
            //         }
            //     }
            // }

            for (int i = 0; i < arrNumbers.Length - 1; i++)
            {
                Console.WriteLine("Lần chay thứ: " + i);
                foreach (var x in arrNumbers)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("");
                for (int j = i + 1; j < arrNumbers.Length; j++)
                {
                    Console.Write("Điều kiện {0} > {1} \n", arrNumbers[i], arrNumbers[j]);
                    if (arrNumbers[i] > arrNumbers[j])
                    {
                        int temp = arrNumbers[i];
                        arrNumbers[i] = arrNumbers[j];
                        arrNumbers[j] = temp;
                        Console.Write("Hoán vị của:{0} & {1} \n", arrNumbers[i], arrNumbers[j]);
                        foreach (int x in arrNumbers)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine("");
                    }
                }
            }

            Console.WriteLine("Sau khi sắp xếp: ");
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}
