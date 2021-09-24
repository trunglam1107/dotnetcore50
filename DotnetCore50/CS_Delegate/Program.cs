using System;


// delegate(type) bien = phuongthuc 

namespace CS_Delegate
{
    class Program
    {
        public delegate void ShowLog(string message);

        public delegate int HamTinh(int a , int b);


        // Phương thức tương đồng với ShowLog (tham số, kiểu trả về)
        static public void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        }

        // Phương thức tương đồng với ShowLog (tham số, kiểu trả về)
        static public void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Waring: {0}", s));
            Console.ResetColor();
        }


        static public int Plus2Num(int num1 , int num2){
            // Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            return num1 + num2;
        }

        static public int Tru2Num(int num1 , int num2){
            // Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            return num1 - num2;
        }

        static public int Nhan2Num(int num1 , int num2){
            // Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            return num1 * num2;
        }

        static public int Chia2Num(int num1 , int num2){
            // Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            return num1 / num2;
        }

        public static int a, b ;
        public static string sinput;

        public static void Nhap2SoTinhToan(){
            

            Console.Write("Nhập số a : ");
            sinput = Console.ReadLine();
            a = int.Parse(sinput);

            Console.Write("Nhập số b : ");
            sinput = Console.ReadLine();
            b = int.Parse(sinput);
        }

        public static void HamTinh01(){

            Nhap2SoTinhToan();

            HamTinh pt;
            pt = Plus2Num;
            Console.WriteLine( $" {a} + {b} = {pt(a,b)}");
            pt = Tru2Num;
            Console.WriteLine( $" {a} - {b} = {pt(a,b)}");
            pt = Nhan2Num;
            Console.WriteLine( $" {a} * {b} = {pt(a,b)}");
            pt = Chia2Num;
            Console.WriteLine( $" {a} / {b} = {pt(a,b)}");
        }

        public static void HamTinh02(){

            Nhap2SoTinhToan();


            HamTinh pt2  = null ; 

            pt2 += Plus2Num;
            pt2 += Tru2Num;
            pt2 += Nhan2Num;
            pt2 += Chia2Num;
            Console.WriteLine( $" {a} + {b} = {pt2(a,b)}");
            Console.WriteLine( $" {a} - {b} = {pt2(a,b)}");
            Console.WriteLine( $" {a} * {b} = {pt2(a,b)}");
            Console.WriteLine( $" {a} / {b} = {pt2(a,b)}");
        }
        

        static void Main(string[] args)
        {
            // ShowLog showLog;

            // showLog = Info;         // showLog gán bằng phương thức Info
            // showLog("Thông báo");   // Thi hành delegate chính là thi hành Info

            // showLog = Warning;      // showLog gán bằng phương thức Warning
            // showLog("Thông báo");   // Thi hành delegate chính là thi hành Info

            // Console.WriteLine();

            

            HamTinh02();

            



        }
    }
}
