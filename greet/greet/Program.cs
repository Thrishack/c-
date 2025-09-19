namespace GreetPerson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            String name = Console.ReadLine();
            Greet g = new Greet(name);
            g.greet();
        }
    }
}