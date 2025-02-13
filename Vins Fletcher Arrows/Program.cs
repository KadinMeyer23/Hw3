namespace Vins_Fletcher_Arrows
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arrow aArrow = new Arrow(Arrowhead.obsidian,Fletching.goose,76);
            Console.WriteLine("Your Total Cost:"+ aArrow.cost());
        }
    }
}
