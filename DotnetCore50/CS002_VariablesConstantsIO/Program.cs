using System;

namespace CS002_VariablesConstantsIO
{
    class Program
    {
        static void Main(string[] args)
        {

            // int seconds = 60;                    //khai báo biến số nguyên
            // double so_pi = 3.14;                 //khai báo biến số thực
            // bool deltaIsSezo = true;             //Khai báo biến logic
            // char chooseAction = 'S';            //Khai báo biến kiểu ký tự
            // string msgResult = "Kết quả giải:"; // khai báo biến chuỗi


            // Console.ForegroundColor = ConsoleColor.DarkMagenta;                 //Đặt màu chữ
            // Console.WriteLine("XIN CHÀO - CHƯƠNG TRÌNH NHẬP XUẤT DỮ LIỆU");     //In dòng chữ
            // Console.ResetColor();                                               //Reset màu

            // Console.Write("Giá trị biến so_pi là : ");                          //In dòng chữ
            // Console.WriteLine(so_pi);                                           //In giá trị biến
            // Console.WriteLine();

            //Nhập liệu trong c#

            // string userLogin;
            // Console.WriteLine("Vui lòng nhập tk : ");
            // userLogin = Console.ReadLine();

            // Console.WriteLine($"Tài khoản của bạn là : {userLogin}");

            //Chương trình tính tổng tích thương chia lấy dư 2 số 
            int a , b;
            string sinput;

            Console.Write("Nhập số a : ");
            sinput = Console.ReadLine();
            a = int.Parse(sinput);

            Console.Write("Nhập số b : ");
            sinput = Console.ReadLine();
            b = Convert.ToInt32(sinput);

            Console.WriteLine($"Tổng của {a} + {b} = {a + b}");
            Console.WriteLine($"Hiệu của {a} - {b} = {a - b}");
            Console.WriteLine($"Nhân của {a} * {b} = {a * b}");
            Console.WriteLine($"Chia của {a} / {b} = {a / b}");
            Console.WriteLine($"Chia lấy dư của {a} % {b} = {a % b}");
        }
    }
}
