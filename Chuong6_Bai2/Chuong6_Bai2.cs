namespace Chuong6_Bai2;
//Bai 2: Viet MENU lua chon 
//16/11/2024
//Nguyen Ngoc Minh Nha
internal class Chuong6_Bai2
{
    static void Main(string[] args)
    {
        int n1 = 0;
        char choice;
        n1 = NhapSoNguyenDuong();
        Console.WriteLine(n1);
        Console.WriteLine("*****************************************");
        Console.WriteLine("(A) Tong cac so le nho hon hay bang n ");
        Console.WriteLine("(B) Tich cac boi so cua 3 va nho hon hoac bang n ");
        Console.WriteLine("(C) 1 + 1/2 + 1/3 + 1 + ... + 1/n-1");
        Console.WriteLine("(D) 2 * 4 * 6 * ... 2n");
        Console.WriteLine("(E) N! = 1 * 2 * ... *n");
        Console.WriteLine("*****************************************");
        Console.WriteLine("Nhap lua chon cua ban: ");
        char.TryParse(Console.ReadLine(), out choice);
        //processing
        switch (choice)
        {
            case 'a':
            case 'A':
                double sum1 = TongCacSoLe(n1);
                Console.WriteLine(sum1);
                break;
            case 'b':
            case 'B':
                double sum2 = TichCacBoiSoCua3(n1);
                Console.WriteLine(sum2);
                break;
            case 'c':
            case 'C':
                double sum3 = PhuongThucC(n1);
                Console.WriteLine(sum3);
                break;
            case 'd':
            case 'D':
                double sum4 = PhuongThucD(n1);
                Console.WriteLine(sum4);
                break;
            case 'e':
            case 'E':
                double sum5 = TinhLuyThua(n1);
                Console.WriteLine(sum5);
                break;
            default:
                Console.WriteLine("Nhap sai lua chon vui long nhap lai");
                break;
        }

    }


    //Cac ham do nguoi dung dinh nghia
    //1 * 2 * .... * n
    static double TinhLuyThua(int num)
    {
        double sum = 1;
        for (int i = 1; i <= num; i++)
        {
            sum *= i;
        }
        return sum;

    }
    //2 * 4 * 6 * ... 2n
    static double PhuongThucD(int num)
    {
        double sum = 1;
        for (int i = 1; i <= num; i++)
        {
            sum *= (2 * i);
        }
        return sum;
    }
    //1 + 1/2 + 1/3 + .... 1/n-1
    static double PhuongThucC(double num)
    {
        double sum = 0;
        for (double i = 1; i < num; i++)
        {
            sum += 1 / i;
        }
        return sum;

    }
    //Tich Cac Boi So Cua 3 Nho Hon Hay Bang N
    static double TichCacBoiSoCua3(int num)
    {
        double sum = 1;
        for (int i = 3; i <= num; i++)
        {
            if (i % 3 == 0)
            {
                sum *= i;
            }
        }
        return sum;
    }
    //Tong Cac So Le Nho Hon Hay Bang N
    static double TongCacSoLe(int num)
    {
        double sum = 0;
        for (int i = 1; i <= num; i += 2)
        {
            sum += i;
        }
        return sum;
    }

    static int NhapSoNguyenDuong()
    {
        int num = 0;
        do
        {
            Console.Write("Nhap so nguyen duong ");
            int.TryParse(Console.ReadLine(), out num);

        } while (num <= 0);
        return num;
    }



}
