namespace Chuong6_Bai12;
//Bai 12 : Liet ke fibonacci voi de quy
//22/11/2024
//Nguyen Ngoc Minh Nha
internal class Chuong6_Bai12
{
    static void Main(string[] args)
    {
        int n = 0;
        n = NhapSoNguyenDuong();
        //Liet ke fibonacci voi de quy
        LietKeFibonacci(n);

    }



    //In day fibonacci voi n phan tu
    static void LietKeFibonacci(int n )
    {
        Console.WriteLine($"Day Fibonacci voi {n} phan tu la:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
        Console.WriteLine();
    }
    //Ham de quy tinh fibonacci
    static int Fibonacci(int n)
    {
        if (n == 0) return 0;       // Trường hợp cơ sở: F(0) = 0
        if (n == 1) return 1;       // Trường hợp cơ sở: F(1) = 1
        return Fibonacci(n - 1) + Fibonacci(n - 2); // Đệ quy: F(n) = F(n-1) + F(n-2)
    }

    //Nhap so nguyen duong
    static int NhapSoNguyenDuong()
    {
        int num = 0;
        do
        {
            Console.Write("Nhap so nguyen duong : ");
            int.TryParse(Console.ReadLine(), out num);

        } while (num <= 0);
        return num;
    }
}
