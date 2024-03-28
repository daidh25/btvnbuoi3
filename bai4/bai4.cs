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

    static void Main(string[] args)
    {
        List<int> mangSoNguyen = NhapMangSoNguyen();
        int tongSoChan = 0;
        int tongSoLe = 0;
        foreach (int phanTu in mangSoNguyen)
        {
            if (phanTu % 2 == 0)
            {
                tongSoChan += phanTu;
            }
            else
            {
                tongSoLe += phanTu;
            }
        }

        
        Console.WriteLine($"Tong cac so chan: {tongSoChan}");
        Console.WriteLine($"Tong cac so le: {tongSoLe}");
    }
}