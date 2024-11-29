using System;
//Bai 9 : Tim UCLN, BCNN
//22/11/2024
//Nguyen Ngoc Minh Nha
namespace Chuong6_Bai9;

internal class Chuong6_Bai9
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;      
        a = NhapVaoSoNguyen(a);
        b = NhapVaoSoNguyen(b);
        double bSCNN = BoiSoChungNhoNhat(a,b);
        double uSCLN = UocSoChungLonNhat(a,b);
        Console.WriteLine($"Boi so chung nho nhat cua {a} va {b} la {bSCNN}");
        Console.WriteLine($"Uoc so chung lon nhat cua {a} va {b} la {uSCLN}");
    }


    //Boi So Chung Nho Nhat
    static double BoiSoChungNhoNhat(int a, int b)
    {
        double bSCNN = 0;
        bSCNN = (a * b) / (UocSoChungLonNhat(a, b));
        return bSCNN;
    }
    //Uoc Chung Lon Nhat
    static double UocSoChungLonNhat(int a, int b)
    {
        double uSCLN = 0;
        //Tim Uoc chung lon nhat
        while (a != 0 && b != 0)
        {
            if (a >= b)
            {
                a = a % b;
            }
            else
            {
                b = b % a;
            }

        }
        uSCLN = a + b;
        return uSCLN;
    }
    //Nhap vao so nguyen
    static int NhapVaoSoNguyen(int n)
    {
        Console.Write("Nhap so nguyen duong: ");
        int.TryParse(Console.ReadLine(), out n);
        return n;
    }

}
