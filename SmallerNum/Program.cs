namespace SmallerNum
{
    public class Program
    {
        static void Main(string[] args)
        {
           smallnum asmall = new smallnum();
            string[] listofnums = ["17", "15"];
            Console.WriteLine(asmall.find_smallernum(listofnums));
        }
    }
}
