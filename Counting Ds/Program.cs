namespace Counting_Ds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DCounter acounter = new DCounter();
            string sentence = "Dannie didnt do drugs during the full moon";
            Console.WriteLine(acounter.Counting_Ds(sentence));
           
        }
    }
}
