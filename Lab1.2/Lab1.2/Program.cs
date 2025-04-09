using System;

namespace Lab1._2
{
    class Program
    {
        // Hàm nhập mảng
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Hàm tính tổng mảng
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        // Bài 1: Tính tổng số chẵn
        public static int TongSoChan(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    tong += a[i];
            }
            return tong;
        }

        // Bài 2: Kiểm tra số nguyên tố
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0) return false;
            return true;
        }

        public static void HienThiSoNguyenTo(int[] a, int n)
        {
            Console.WriteLine("Các số nguyên tố trong mảng:");
            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(a[i]))
                    Console.WriteLine($"a[{i}] = {a[i]}");
            }
        }

        // Bài 3: Đếm số âm và dương
        public static void DemAmDuong(int[] a, int n)
        {
            int soAm = 0, soDuong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0) soAm++;
                else if (a[i] > 0) soDuong++;
            }
            Console.WriteLine($"Số âm: {soAm}, Số dương: {soDuong}");
        }

        // Bài 4: Tìm số lớn thứ hai
        public static int TimSoLonThuHai(int[] a, int n)
        {
            int max = int.MinValue, second = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    second = max;
                    max = a[i];
                }
                else if (a[i] > second && a[i] != max)
                {
                    second = a[i];
                }
            }
            return second;
        }

        // Bài 5: Hoán vị 2 số nguyên
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Bài 6: Sắp xếp mảng tăng dần
        public static void SapXepTang(ref float[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j])
                    {
                        float temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ----------- Phần mảng số nguyên -----------
            Console.Write("Nhập số phần tử mảng số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);

            Console.WriteLine($"Tổng các phần tử: {TinhTong(a, n)}");
            Console.WriteLine($"Tổng các số chẵn: {TongSoChan(a, n)}");
            HienThiSoNguyenTo(a, n);
            DemAmDuong(a, n);
            Console.WriteLine($"Số lớn thứ hai trong mảng: {TimSoLonThuHai(a, n)}");

            // ----------- Phần hoán vị 2 số -----------
            Console.Write("Nhập số nguyên a: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên b: ");
            int so2 = int.Parse(Console.ReadLine());
            Swap(ref so1, ref so2);
            Console.WriteLine($"Sau hoán vị: a = {so1}, b = {so2}");

            // ----------- Phần mảng số thực -----------
            Console.Write("Nhập số phần tử mảng số thực: ");
            int m = int.Parse(Console.ReadLine());
            float[] arrThuc = new float[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Thuc[{i}] = ");
                arrThuc[i] = float.Parse(Console.ReadLine());
            }

            SapXepTang(ref arrThuc);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (var x in arrThuc)
                Console.Write($"{x} ");
        }
    }
}
