
namespace Class.Work;

public delegate string NewDelegate(List<object> list);
public class DelegateList
{
    public static   Func<List<object>, string> MaxMin=MinMax;
    public static string MinMax(List<object> list)
    {
        int max = 0;
        string str = "Min:";
        int min = list.Capacity;
        for (int i = 0; i < list.Count(); i++)
        {
            if (list[i].ToString().Length>max)
            {
                max = list[i].ToString().Length;
            }
            if (list[i].ToString().Length<min)
            {
                min = list[i].ToString().Length;
            }
        }

       str += min.ToString();
        str += "\n Max:";
        str += max.ToString();
      return str;

    }
}