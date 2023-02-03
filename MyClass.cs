/*namespace Class.Work;
public  delegate  bool MyDelegate();

public  class MyClass
{
    public static MyDelegate Start=Print;
    public static MyDelegate Do=Bool;
    public static MyDelegate Delegate = D2;
    public static bool Print()
    {
        //Delegate.Invoke();//D2
        Console.WriteLine("Start");
        return true;
    }
    public static bool Bool()
    {
        //Do.Invoke();//Bool
        Console.WriteLine("Do");
        return false;
    }
    public static bool D2()
    {
        Start.Invoke();//Print
        Console.WriteLine("Delegate");
        return false;
    }
    public static void PrintD( MyDelegate d,MyDelegate s,MyDelegate f)
    {
        s.Invoke();
        d.Invoke();
        f.Invoke();

    }
}*/