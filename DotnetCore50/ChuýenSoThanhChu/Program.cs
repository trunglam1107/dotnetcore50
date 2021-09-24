using System;
using XTL;

namespace ChuýenSoThanhChu
{
    class Program
    {
        static void Main(string[] args)
        {
            var snumber = Utils.NumberToText(566776768989);
            //năm trăm sáu mươi sáu tỷ bảy trăm bảy mươi sáu triệu bảy trăm sáu mươi tám nghìn chín trăm tám mươi chín đồng chẵn

            Console.WriteLine(snumber);
            Console.WriteLine();
            Console.WriteLine();

            // Kiểm tra ngẫu nhiên 1000 số
            int ntest = 1000;
            Random rn = new Random();
            for (int i = 0; i < ntest; i++)
            {
                var number = rn.NextDouble() * rn.Next(1, Int32.MaxValue);
                var text = XTL.Utils.NumberToText(number);
                var ntext = number.ToString("###,###,###,###,###");
                Console.WriteLine($"{ntext, 20} --> {text}");
            }
        }
    }
}
