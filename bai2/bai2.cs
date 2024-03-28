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
                Console.Write($"Nhap phan tu thu: {i + 1}: ");
                int phanTu = int.Parse(Console.ReadLine());
                mang.Add(phanTu);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Vui long chi nhap so nguyen: ");
        }

        return mang;
    }

    static void Main(string[] args)
    {
        
        List<int> mangSoNguyen = NhapMangSoNguyen();
        List<int> mangSoLe = new List<int>();
        List<int> mangSoChan = new List<int>();
        foreach (int phanTu in mangSoNguyen)
        {
            if (phanTu % 2 == 0)
            {
                mangSoChan.Add(phanTu);
            }
            else
            {
                mangSoLe.Add(phanTu);
            }
        }

        Console.Write("Mang so le: ");
        foreach (int soLe in mangSoLe)
        {
            Console.Write($"{soLe} ");
        }
        Console.WriteLine();

        Console.Write("Mang so chan: ");
        foreach (int soChan in mangSoChan)
        {
            Console.Write($"{soChan} ");
        }
        Console.WriteLine();
    }
}