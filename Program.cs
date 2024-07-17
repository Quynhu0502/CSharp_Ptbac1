using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Giải PT Bậc 1 ");
        double a, b;
        Console.WriteLine("Nhập hệ số a ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập hệ số b ");
        b = Convert.ToDouble(Console.ReadLine());
        string ketqua = PTBac1cach2(a,b);
        Console.WriteLine(ketqua);
        PTBac1cach1(a,b);
    }
    private static void PTBac1cach1(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0) Console.WriteLine("PT vô số nghiệm ");

            else  Console.WriteLine("PT vô nghiệm"); }
            else Console.WriteLine("Nghiệm của PT la1: " + (-b / a).ToString());  }

    private static string PTBac1cach2(double a, double b)
    {
        if (a == 0)

            if (b == 0)

                return "PT vô số nghiệm";

            else

                return "PT vô nghiệm";
        else
           return "Nghiệm của PT la: " + (-b / a).ToString();

    }
   
}










