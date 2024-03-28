class Program
{
    static List<int> NhapMangSoNguyen()
    {
        List<int> mang = new List<int>();

        try
        {
            Console.Write("Nhap so luong phan tu mang: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                int phanTu = int.Parse(Console.ReadLine());
                mang.Add(phanTu);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Vui long chi nhap so nguyen.");
        }

        return mang;
    }

    static bool KiemTraSoNguyenTo(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static int TinhTongCacSoNguyenTo(List<int> mangSoNguyen)
    {
        int tong = 0;

        foreach (int phanTu in mangSoNguyen)
        {
            if (KiemTraSoNguyenTo(phanTu))
                tong += phanTu;
        }

        return tong;
    }

    static void Main(string[] args)
    {
        
        List<int> mangSoNguyen = NhapMangSoNguyen();
        int tong = TinhTongCacSoNguyenTo(mangSoNguyen);
        Console.WriteLine($"Tong cac so nguyen to trong mang: {tong}");
    }
}