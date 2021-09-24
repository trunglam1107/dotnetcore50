using System;
using MyLib;

namespace CS006_Method
{
    class Program
    {
        /// Tính bình phương của số thực double
        // static double BinhPhuong(double number)
        // {
        //     double ketqua = number * number;
        //     return ketqua;
        // }

        static void Main(string[] args)
        {

            // double a;
            // string sinput;

            // Console.Write("Nhập số a : ");
            // sinput = Console.ReadLine();
            // a = double.Parse(sinput);

            // double bp = BinhPhuong(a); // Gọi hàm
            // Console.WriteLine($"Bình phương của {a} là: " + bp);

            // CS006.XinChao();
            // CS006.XinChao();
            // CS006.XinChao();

            // string name ;
            // Console.Write("Vui lòng nhập tên : ");
            // name = Console.ReadLine();

            // CS006.ChaoMung(name);

            // double thetich;

            // thetich = CS006.TheTich(2);              // ~ CS006.TheTich(2,1,1)
            // Console.WriteLine(thetich);             // 2

            // thetich = CS006.TheTich(2, 10);           // ~ CS006.TheTich(2,10,1)
            // Console.WriteLine(thetich);             // 20

            // thetich = CS006.TheTich(1, 2, 3);
            // Console.WriteLine(thetich);             // 6

            // string fullname;

            // fullname = CS06.FullName("Nguyễn", "A");
            // Console.WriteLine(fullname);                        //Nguyễn A

            // fullname = CS06.FullName("ĐINH", "NAM", "HOÀNG");
            // Console.WriteLine(fullname);                        //ĐINH HOÀNG NAM

            // fullname = CS06.FullName(ten: "A", ho: "Nguyễn");              // Nguyễn A
            // fullname = CS06.FullName(tendem: "VĂN", ten: "B", ho: "PHẠM"); // PHẠM VĂN B
            // fullname = CS06.FullName(tendem: "VĂN", ho: "PHẠM", ten: "B"); // PHẠM VĂN B
            // fullname = CS06.FullName(ho: "PHẠM", tendem: "VĂN", ten: "B"); // PHẠM VĂN B


            //Ví dụ tham trị
            int a = 2;
            ViduThamTri(a);
            Console.WriteLine(a);

            
        }

        //Ví dụ tham trị:
        public static void ViduThamTri(int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }

        //Ví dụ tham chiếu:

        public static void ViduThamChieu(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
    }
}
