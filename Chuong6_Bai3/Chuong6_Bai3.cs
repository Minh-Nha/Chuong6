using System;

namespace Chuong6_Bai3;
//Bai 3 : Tinh tong cac uoc so, dem cac uoc so
//Bai 4 : Kiem tra xem co phai so nguyen to khong
//Bai 5 : Kiem tra so chinh phuong
//Bai 6 : Kiem tra so hoan hao, Liet ke so hoan hao tu 1 den 1000
//Bai 7 : Kiem tra so doi xung, liet ke va dem so luong cac so doi xung
//Bai 8 : Viet ham tinh so hang thu n cua day fibonaci
//16/11/2024
//Nguyen Ngoc Minh Nha
internal class Chuong6_Bai3
{
    static void Main(string[] args)
    {
        int n = 0;
        n = NhapSoNguyenDuong();
        //Bai 3
        //Tong cac uoc so
        Console.WriteLine("Bai 3 : Tinh tong cac uoc so:");
        long tongUS = TinhTongCacUocSo(n);
        Console.WriteLine(tongUS);
        Console.WriteLine();

        //Dem cac uoc so
        Console.WriteLine("Dem cac uoc so:");
        int dem = DemCacUocSo(n);
        Console.WriteLine(dem);
        Console.WriteLine();

        //Bai 4
        //Kiem tra so nguyen to
        Console.WriteLine("Bai 4 : Kiem tra so nguyen to:");
        bool soNguyenTo = KiemTraSoNguyenTo(n);
        Console.WriteLine(soNguyenTo == true ? $"{n} La so nguyen to" : $"{n} Khong la so nguyen to");
        Console.WriteLine();

        //Bai 5
        //Kiem tra so chinh phuong 
        Console.WriteLine("Bai 5 : Kiem tra so chinh phuong:");
        bool soChinhPhuong = KiemTraSoChinhPhuong(n);
        Console.WriteLine(soChinhPhuong == true ? $"{n} La so chinh phuong" : $"{n} Khong la so chinh phuong");
        Console.WriteLine();

        //Bai 6
        //Kiem tra so hoan hao
        Console.WriteLine("Bai 6 : Kiem tra so hoan hao:");
        bool soHoanHao = KiemTraSoHoanHao(n);
        Console.WriteLine(soHoanHao == true ? $"{n} La so hoan hao" : $"{n} Khong la so hoan hao");
        Console.WriteLine();

        //Liet ke so hoan hao tu 1 den 1000
        Console.WriteLine("Liet ke cac so hoan hao tu 1 den 1000 : ");
        LietKeSoHoanHao();
        Console.WriteLine();
        Console.WriteLine();
        
        //Bai 7
        //Kiem tra so doi xung 
        Console.WriteLine("Bai 7 : Kiem tra so doi xung:");
        bool soDoiXung = KiemTraSoDoiXung(n);
        Console.WriteLine(soDoiXung == true ? $"{n} La so doi xung" : $"{n} Khong la so doi xung");
        Console.WriteLine();

        //Dem cac so doi xung
        Console.WriteLine("Liet ke va dem cac so doi xung tu 1 den 500: ");
        DemCacSoDoiXung();
        Console.WriteLine();

        //Bai 8
        //Tinh so hang thu n cua day fibonaci
        Console.WriteLine("Bai 8 : Tinh cac so hang thu n cua day fibonaci:");
        int soHangFibonaci = SoHangDayFibonaci(n);
        Console.WriteLine($"So hang thu {n} cua day fibonaci la {soHangFibonaci}");
        Console.WriteLine();

        

    }


    //Tinh so hang thu n cua day fibonaci
    static int SoHangDayFibonaci (int n)
    {
        int n1 = 0, n2 = 1, n3 = 0;
        if (n == 1 || n == 2)
        {
            return 1;
        }      
        for (int i = 2; i <= n; i++)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
        Console.WriteLine();
        return n3;
    }

    //Dem cac so doi xung
    static void DemCacSoDoiXung()
    {
        int dem = 0;
        for (int i = 1; i <= 500; i++)
        {
            if (KiemTraSoDoiXung(i))
            {
                Console.Write(i + " ");//Liet ke cac so doi xung
                dem++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"So luong cac so doi xung tu 1 den 500: {dem}");

    }

    //Kiem tra so doi xung
    static bool KiemTraSoDoiXung(int n)
    {
        int soCu = n;
        int soDaoNguoc = 0;
        while(n > 0)
        {
            int phanConLai = n % 10;
            soDaoNguoc = soDaoNguoc * 10 + phanConLai;
            n = n / 10;
        }
        return soCu == soDaoNguoc;
    }

    //Liet ke so hoan hao
    static void LietKeSoHoanHao()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (KiemTraSoHoanHao(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    //Kiem tra so hoan hao
    static bool KiemTraSoHoanHao(int n)
    {
        long tongUS = TinhTongCacUocSo(n) - n;
        return tongUS == n;
    }

    //Kiem tra so chinh phuong
    static bool KiemTraSoChinhPhuong(int n)
    {
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
    }

    //Kiem tra so nguyen to
    static bool KiemTraSoNguyenTo(int n)
    {
        int dem = DemCacUocSo(n);
        return dem == 2;
    }
    
    //Dem cac uoc so
    static int DemCacUocSo(int number)
    {
        int dem = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                dem++;
            }
        }
        return dem;
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
