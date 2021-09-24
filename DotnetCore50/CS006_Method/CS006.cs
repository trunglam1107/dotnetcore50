using System;

namespace MyLib
{
    public class CS006
    {
        public static void XinChao()
        {
            Console.WriteLine("Xin chào đây là phương thức.");
        }

        public static void ChaoMung(string name)
        {
            Console.WriteLine($"Xin chào bạn {name}");
        }

        // Phương thức khai báo có 3 tham số, hai tham số cuối mặc định
        // Nếu gọi hàm không có chỉ ra tham số cuỗi thì nó lấy giá trị mặc định này
        public static double TheTich(double cao, double dai = 1, double rong = 1)
        {
            return cao * dai * rong;
        }

        public static string FullName(string ho, string ten, string tendem = "")
        {
            return ho + (tendem != "" ? " " + tendem : "") + " " + ten;
        }


        /*
            Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu : 
            -tham trị là cách thức mặc định, ta đã sử dụng ở phần trên. 
            Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ, 
            còn bản thân biến bên ngoài không hề ảnh hưởng.
            -tham chiếu thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, 
            nên nó có tác động trực tiếp đến biến này bên ngoài. 
            Để sử dụng được tham chiếu thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref
        */

        
    }
}