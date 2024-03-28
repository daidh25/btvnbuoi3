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

       
        mangSoNguyen.Sort();
        Console.Write("Mang tang dan: ");
        foreach (int phanTu in mangSoNguyen)
        {
            Console.Write($"{phanTu} ");
        }
        Console.WriteLine();

       
        mangSoNguyen.Reverse();
        Console.Write("Mảng giảm dần: ");
        foreach (int phanTu in mangSoNguyen)
        {
            Console.Write($"{phanTu} ");
        }
        Console.WriteLine();
    }
}