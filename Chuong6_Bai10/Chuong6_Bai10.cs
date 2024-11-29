namespace Chuong6_Bai10;
//Bai 10 : Dem cac so hoan hao nho hon hoac bang n
//22/11/2024
//Nguyen Ngoc Minh Nha
internal class Chuong6_Bai10
{
    static void Main(string[] args)
    {
        int n = 0;
        int demSHH = 0;
        n = NhapSoNguyenDuong();
        demSHH = DemSoHoanHao(n);
        Console.WriteLine($"Dem cac so hoan hao nho hon hoac bang {n}: ");
        Console.WriteLine(demSHH);
    }

    //Dem so hoan hao
    static int DemSoHoanHao(int n)
    {
        int dem = 0;
        for (int i = 1; i <= n; i++)
        {
            if (KiemTraSoHoanHao(i))
            {
                dem++;
            }
        }
        return dem;
    }

    //Kiem tra so hoan hao
    static bool KiemTraSoHoanHao(int n)
    {
        long tongUS = TinhTongCacUocSo(n) - n;
        return tongUS == n;
    }

    //Tinh tong cac uoc so
    static long TinhTongCacUocSo(int number)
    {
        long tongUS = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                tongUS += i;
            }
        }
        return tongUS;
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
