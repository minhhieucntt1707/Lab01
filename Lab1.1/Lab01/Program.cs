using System;
using System.Text;
namespace lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo biến
            int x1, x2, y1, y2;
            //2. Nhập giá trị
            Console.WriteLine("Nhập điểm A(x1, y1):");
            Console.Write("- x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("- y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm B(x2, y2):");
            Console.Write("- x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("- y2: ");
            y2 = int.Parse(Console.ReadLine());
            //3. Tính khoảng cách
            double khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //4. Hiển thị kết quả
            Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({x2}, {y2}) = { khoangCach}");
        }

        //bai1: nhap ten va tuoi
        static void NhapTenVaTuoi(string[] args)
        {
            // Nhập tên
            Console.Write("Nhập tên của bạn: ");
            string ten = Console.ReadLine();

            // Nhập tuổi
            Console.Write("Nhập tuổi của bạn: ");
            int tuoi = int.Parse(Console.ReadLine());

            // In ra kết quả
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");

            Console.ReadKey(); // Giữ màn hình console
        }

        //Bai2: S HCN
        static void DienTichHCN(string[] args)
        {
            // Nhập chiều dài
            Console.Write("Nhập chiều dài: ");
            double chieuDai = double.Parse(Console.ReadLine());

            // Nhập chiều rộng
            Console.Write("Nhập chiều rộng: ");
            double chieuRong = double.Parse(Console.ReadLine());

            // Tính diện tích
            double dienTich = chieuDai * chieuRong;

            // In kết quả
            Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");

            Console.ReadKey();
        }

        //Bai3: Chuyen tu C sang F
        static void ChuyenDoi(string[] args)
        {
            // Nhập nhiệt độ Celsius
            Console.Write("Nhập nhiệt độ (độ C): ");
            double doC = double.Parse(Console.ReadLine());

            // Công thức chuyển sang độ F
            double doF = doC * 9 / 5 + 32;

            // In kết quả
            Console.WriteLine($"{doC} độ C = {doF} độ F");

            Console.ReadKey();
        }

        //Bai4:Kiem tra chan hay ko
        static void KiemTraChan(string[] args)
        {
            // Nhập số nguyên từ bàn phím
            Console.Write("Nhập vào một số nguyên: ");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra chẵn hay lẻ
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ.");
            }

            Console.ReadKey(); // Giữ màn hình console
        }

        //Bai5: tinh tong va tich 2 so nhap tu ban phim
        static void TinhTongTich(string[] args)
        {
            // Nhập số thứ nhất
            Console.Write("Nhập số thứ nhất: ");
            double so1 = double.Parse(Console.ReadLine());

            // Nhập số thứ hai
            Console.Write("Nhập số thứ hai: ");
            double so2 = double.Parse(Console.ReadLine());

            // Tính tổng
            double tong = so1 + so2;

            // Tính tích
            double tich = so1 * so2;

            // In kết quả
            Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
            Console.WriteLine($"Tích của {so1} và {so2} là: {tich}");

            Console.ReadKey(); // Giữ màn hình console
        }

        //Bai6:Kiem tra so duong am hay 0
        static void KiemTraAmDuong0(string[] args)
        {
            // Nhập số từ bàn phím
            Console.Write("Nhập vào một số: ");
            double so = double.Parse(Console.ReadLine());

            // Kiểm tra số
            if (so > 0)
            {
                Console.WriteLine($"{so} là số dương.");
            }
            else if (so < 0)
            {
                Console.WriteLine($"{so} là số âm.");
            }
            else
            {
                Console.WriteLine("Số bạn nhập là số 0.");
            }

            Console.ReadKey(); // Giữ màn hình console
        }

        //Bai7:Kiem tra nam nhuan
        static void KiemTraNam(string[] args)
        {
            // Nhập năm từ bàn phím
            Console.Write("Nhập vào một năm: ");
            int nam = int.Parse(Console.ReadLine());

            // Kiểm tra năm nhuận
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                Console.WriteLine($"{nam} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{nam} không phải là năm nhuận.");
            }

            Console.ReadKey(); // Giữ màn hình console
        }

        //Bai8:in bang cuu chuong
        static void BangCuuChuong(string[] args)
        {
            // In bảng cửu chương từ 1 đến 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Bảng cửu chương {i}:");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine(); // Xuống dòng giữa các bảng
            }

            Console.ReadKey(); // Giữ màn hình console
        }

        //Bai9: tinh giai thua  so nguyen n
        static void GiaiThua(string[] args)
        {
            // Nhập số nguyên dương n
            Console.Write("Nhập vào số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            long giaiThua = 1;

            if (n < 0)
            {
                Console.WriteLine("Không tính được giai thừa của số âm.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }

                Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
            }

            Console.ReadKey(); // Giữ màn hình console
        }

        //Bai10: Kiem tra so nguyen to
        static void KiemTraSoNguyenTo(string[] args)
        {
            // Nhập số nguyên n
            Console.Write("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());

            bool laSoNguyenTo = true;

            if (n < 2)
            {
                laSoNguyenTo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
            }

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}
