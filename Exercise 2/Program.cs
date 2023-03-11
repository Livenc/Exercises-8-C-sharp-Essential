namespace Exercise_2;
class Program
{
   
        static class MyClass
        {
           static public void Print(string stroka, int color )
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ResetColor();
        
        }
        public enum TextColor : int
        {
            Black,
            Red,
            Green,
            Yellow,
            Blue,
            Magenta,
            Cyan,
            White
        }
    }
    
    static void Main(string[] args)
    {


        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Выберите цвет:");
        foreach (MyClass.TextColor color in Enum.GetValues(typeof(MyClass.TextColor)))
        {
            Console.WriteLine($"{(int)color}. {color}");
        }
        int colorInp = Convert.ToInt32(Console.ReadLine());
       
        MyClass.Print(inputString, colorInp);
        Console.ReadKey();
    }
}

