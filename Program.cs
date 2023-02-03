using Class.Work;

public class Program
{
    static void Main(string[] args)
    {
        List<object> list = new List<object>();
        list.Add("wewe");
        list.Add("wewewe");
        list.Add("wewewdfvwe");
        list.Add("wewewdwefwee");
        list.Add("w");
        list.Add("we");
        Console.WriteLine( DelegateList.MaxMin(list));
    }
}