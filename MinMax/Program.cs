namespace MinMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            Findingminmax aminmax = new Findingminmax();
            int []ArrayofNums = [3, 7, 1, 19, 40];
            int[] result = aminmax.FindingMinMax(ArrayofNums);
            Console.WriteLine("["+result[0]+","+ result[1]+"]");
        }
    }
}
