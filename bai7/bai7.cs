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

    static void TinhTongLeVaChan(List<int> mang, ref int tongLe, ref int tongChan)
    {
        foreach (int phanTu in mang)
        {
            if (phanTu % 2 == 0)
            {
                tongChan += phanTu;
            }
            else
            {
                tongLe += phanTu;
            }
        }
    }

    static void Main(string[] args)
    {
        List<int> mangSoNguyen = NhapMangSoNguyen();
        int tongLe = 0;
        int tongChan = 0;
        TinhTongLeVaChan(mangSoNguyen, ref tongLe, ref tongChan);
        Console.WriteLine($"Tong cac so le: {tongLe}");
        Console.WriteLine($"Tong cac so chan: {tongChan}");
    }
}