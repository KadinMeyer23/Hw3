using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulas_Soup
{
    public class Soup
    {

        public enum type { soup, stew, gumbo }
        private type currenttype;
        public enum Main_Ingredient { mushrooms, chicken, carrots, potatoes }
        private Main_Ingredient Currentmain;
        public enum Seasoning { spicy, salty, sweet }
        private Seasoning CurrentSeason;


        public void order(string souptype,string Maintype,string Seasoningtype)
        {
            

            if (souptype == "soup")
            {
                currenttype = type.soup;
            }
            else if (souptype == "stew") { currenttype = type.stew; }
            else if (souptype == "gumbo") { currenttype = type.gumbo; }
            


            


            if (Maintype == "mushrooms")
            {
                Currentmain = Main_Ingredient.mushrooms;
            }
            else if (Maintype == "chicken") { Currentmain = Main_Ingredient.chicken; }
            else if (Maintype == "carrots") { Currentmain = Main_Ingredient.carrots; }
            else if (Maintype == "potatoes") { Currentmain = Main_Ingredient.potatoes; }
            




            

            if (Seasoningtype == "spicy") { CurrentSeason = Seasoning.spicy; }
            else if (Seasoningtype == "salty") { CurrentSeason = Seasoning.salty; }
            else if (Seasoningtype == "sweet") { CurrentSeason = Seasoning.sweet; }
            

            var order = (CurrentSeason, Currentmain, currenttype);
            Console.Write(order);

        }


    }
}
