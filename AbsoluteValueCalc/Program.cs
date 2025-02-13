namespace AbsoluteValueCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            AbsCalc acalc  = new AbsCalc();
            int[] arrayofnums = { 1, -2, 3, -4 , 5, -6, 7, 8 };
            Console.WriteLine(acalc.Find_AbsCalc(arrayofnums));
        }
    }
}
