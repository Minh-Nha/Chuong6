namespace Chuong6_Bai11;
//Bai 11 : In n so chinh phuong dau tien
//22/11/2024
//Nguyen Ngoc Minh Nha
internal class Chuong6_Bai11
{
    static void Main(string[] args)
    {
        int n = 0;
        n = NhapSoNguyenDuong();

        // In ra N số chính phương đầu tiên
        Console.WriteLine($"{n} so chinh phuong đau tien la:");
        InNSoChinhPhuongDauTien(n);
    }

    //IN N So Chinh Phuong Dau Tien
    static void InNSoChinhPhuongDauTien(int n)
    {
        int dem = 0;
        for (int i = 1; dem < n; i++)
        {
            if (KiemTraSoChinhPhuong(i))
            {
                Console.Write(i + " ");
                dem++;
            }
        }
        Console.WriteLine(); 
    }

    //Kiem tra so chinh phuong
    static bool KiemTraSoChinhPhuong(int n)
    {
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
    }

    //Kiem tra so nguyen duong
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
