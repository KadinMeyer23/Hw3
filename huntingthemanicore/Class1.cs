using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace huntingthemanicore
{
    public class manigame
    {

        public void huntmani() {

            int Manticore = 10;
            int City = 15;
            int i = 1;
            int cannon = 0;
            Console.WriteLine("Player 1: Enter the Distance the Manticore is From the City: ");
            int distance = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            Console.WriteLine("Player 2: Your Turn");

            while (Manticore > 0 && City > 0) {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("Status: Round: " + i + " City: " + City + "/15 Manticore " + Manticore + "/10 ");

                if (i % 3 == 0 && i % 5 == 0) { cannon = 10; }
                else if (i % 3 == 0 || i % 5 == 0) { cannon = 3; }
                else { cannon = 1; }

                Console.WriteLine("The cannon is expected to deal " + cannon + " damage");
                Console.WriteLine("Enter desired cannon range: ");
                int p2distance = Convert.ToInt32(Console.ReadLine());

                if (p2distance > distance) {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("That Round OVERSHOT the target"); }
                else if (p2distance < distance) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That Round UNDERSHOT the target"); }
                else if (p2distance == distance) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round was a DIRECT HIT");
                    Manticore -= cannon;
                }

                if (Manticore <= 0) { Console.WriteLine("The Manticore has been destroyed, The City Wins!!"); }
                else if (City <= 0){ Console.WriteLine("The City has been destoryed, the Manticore Wins!!"); }

                City--;
                i++;
            }
        
        
        
        
        
        }
    }
}
