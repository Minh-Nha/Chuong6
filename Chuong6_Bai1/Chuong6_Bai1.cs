namespace Chuong6_Bai1;

internal class Chuong6_Bai1
{
    static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 20;
        int n3 = 10;
        //cach 1
        n1 = NhapSoNguyenDuong();
        Console.WriteLine(n1);
        //cach 2
        NhapSoNguyenDuong2(out n2);
        Console.WriteLine(n2);
        //Cach 3
        NhapSoNguyenDuong3(ref n3);
        Console.WriteLine(n3);
    }


    //
    static void NhapSoNguyenDuong3(ref int num)
    {

        do
        {
            Console.Write("Nhap so nguyen duong 3");
            int.TryParse(Console.ReadLine(), out num);

        } while (num <= 0);
        //Console.WriteLine($"num trong = {num}");
    }

    static void NhapSoNguyenDuong2(out int num)
    {

        do
        {
            Console.Write("Nhap so nguyen duong 2");
            int.TryParse(Console.ReadLine(), out num);

        } while (num <= 0);
        //Console.WriteLine($"num trong = {num}");
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
