using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vins_Fletcher_Arrows
{

    public enum Arrowhead { steel, wood, obsidian }

    public enum Fletching { plastic, turkey, goose }
    public class Arrow
    {
        //declare Variables
        private Arrowhead currentarrowhead;
        private Fletching currentfletching;
        private int length = -10000;

        //Gets and Sets
        public Arrowhead CurrentArrowhead { get { return currentarrowhead; } set { currentarrowhead = value; } }
        public Fletching CurrentFletching { get { return currentfletching; } set { currentfletching = value;   } }
        public int Length { get { return length; } set { length = value; } }

        
        //Constructor
        public Arrow(Arrowhead aArrowhead, Fletching afletching, int alength) {
            CurrentArrowhead = aArrowhead;
            CurrentFletching = afletching;

            if (alength > 60 && alength < 100)
            {
                Length = alength;
                
            }
            else { Length = -10000; }
        
        
        }

        //Methods

        public int Get_Length() {
            return Length;
        }
        public Arrowhead Get_ArrowHead() { return CurrentArrowhead; }


        public Fletching Get_Fletching() { return CurrentFletching; }


        public double cost() {
            double total = 0;
            //steel costs 10 gold, wood costs 3 gold, and obsidian costs 5 gold

            if (Get_ArrowHead() == Arrowhead.steel) { total += 10; }
            else if (Get_ArrowHead() == Arrowhead.wood) { total += 3; }
            else if (Get_ArrowHead() == Arrowhead.obsidian) { total += 5; }

            //For fletching, plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold

            if (Get_Fletching() == Fletching.plastic) { total += 10; }
            else if (Get_Fletching() == Fletching.turkey) { total += 5; }
            else if (Get_Fletching() == Fletching.goose) { total += 3; }

            double arrowlencost = Get_Length() * .05;
            total += arrowlencost;

            return total; }

        

    }
}
