using System.Formats.Asn1;

namespace Class.Work;
public  delegate void MyDelegate (int n1, int n2);
public class Mathematics
{
    public static  MyDelegate _delSum = Sum;
    public static MyDelegate _delDivide = Divide;
    public static MyDelegate _delSubstract= Substract;
    public static MyDelegate _delMultiply = Multiply;
    public static void Sum(int n1,int n2)
    {
        Console.WriteLine(n1+n2);
    }

    public static void Substract(int n1, int n2)
    {
        Console.WriteLine(   Math.Abs(n1 - n2));
    }
    public static void Divide(int n1, int n2)
    {
        Console.WriteLine(   Math.Abs(n1 / n2));
    }

    public static void Multiply(int n1, int n2)
    {
        Console.WriteLine(   Math.Abs(n1 * n2));
    }
}