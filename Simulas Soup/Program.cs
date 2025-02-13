namespace Simulas_Soup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Soup asoup = new Soup();

            

        Console.WriteLine("Menu\n -----------------\nType: Soup Stew Gumbo\nMain: mushrooms, chicken, carrots, potatoes \nSeasoning: spicy, salty, sweet ");
            Console.WriteLine("Enter Your Type: ");
            string souptype = Console.ReadLine();
            string sp = souptype.ToLower();
            Console.WriteLine("Enter Your Main: ");
            string Maintype = Console.ReadLine();
            string mt = Maintype.ToLower();
            Console.WriteLine("Enter Your Seasoning: ");
            string Seasoningtype = Console.ReadLine();
            string st = Seasoningtype.ToLower();
            asoup.order(sp, mt, st);

        }
    }
}
