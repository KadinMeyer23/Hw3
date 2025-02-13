namespace LengthMultiplier
{
    public class Program
    {
        static void Main(string[] args)
        {
            LengthMulti aMulti = new LengthMulti();
            int[] Arrayofnums = [1, 2, 3, 4, 5, 6];
            int[] results  = aMulti.lengthmultiplier(Arrayofnums);

            foreach (int i in results) {Console.WriteLine(i);}
        }
    }
}
