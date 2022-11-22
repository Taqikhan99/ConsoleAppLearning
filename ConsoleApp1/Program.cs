public class Program
{
    public static int get5Times(int num)
    {
        return num * 5;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Num1: " + num1);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num1 + " x " + i + " = " + num1 * i);
        }


        Console.WriteLine("Hope you enjoyed the lesson!");

        int fiveTimesNo = get5Times(num1);
        Console.WriteLine(fiveTimesNo);

        
    }
    
}