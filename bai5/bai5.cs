class Program
{
    static List<int> NhapMangSoNguyen()
    {
        List<int> mang = new List<int>();

        try
        {
            
            Console.Write("Nhap so luong phan tu cua mang: ");
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

    static bool KiemTraSoArmstrong(int number)
    {
        int originalNumber, remainder, result = 0, n = 0;
        originalNumber = number;

        for (originalNumber = number; originalNumber != 0; originalNumber /= 10, ++n) ;

        originalNumber = number;

        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            result += (int)Math.Pow(remainder, n);
            originalNumber /= 10;
        }

        if (result == number)
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
       
        List<int> mangSoNguyen = NhapMangSoNguyen();

        
        foreach (int phanTu in mangSoNguyen)
        {
            if (KiemTraSoArmstrong(phanTu))
                Console.WriteLine($"{phanTu} la so Armstrong.");
            else
                Console.WriteLine($"{phanTu} khong la so Armstrong.");
        }
    }
}