namespace PosNegZero
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            PNZ pnz = new PNZ(num);
            pnz.check();
        }
    }
}