namespace Exercise_3;
class Program
{
    public enum Post
    {
        meneger = 140,
        bugalter = 156,
        rabochii = 176
    }
    public class Accauntant
    {
         public bool AskForBonus(Post post, int hour)
        {
            if ((int)post >= hour)
            {
                return true;
            }
            else
            {
              return  false;
            }
        }
    }
    static void Main(string[] args)
    {
        Accauntant accauntant = new Accauntant();
        foreach (Post post in Enum.GetValues(typeof(Post)))
        {
            Console.WriteLine($"{(int)post}. {post}");
        }
        int postid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input hours : ");
        int hour = Convert.ToInt32(Console.ReadLine());
        bool premii = accauntant.AskForBonus((Post)postid, hour);
        Console.WriteLine($"pologena premia = {premii}");
        Console.ReadKey();
    }
}

