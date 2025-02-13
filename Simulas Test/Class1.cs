using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulas_Test
{
public class Chest
    {

        public enum ChestState
        {
            Locked,
            Unlocked,
            Open,
            Closed
        }

        private ChestState currentState;

        public Chest()
        {
            
            currentState = ChestState.Locked;
        }

        public void Lock()
        {
            if (currentState == ChestState.Unlocked || currentState == ChestState.Closed)
            {
                currentState = ChestState.Locked;
                Console.WriteLine("The chest is now locked.");
            }
            else
            {
                Console.WriteLine("Invalid transition. The chest cannot be locked in the current state.");
            }
        }

        public void Unlock()
        {
            if (currentState == ChestState.Locked)
            {
                currentState = ChestState.Unlocked;
                Console.WriteLine("The chest is now unlocked.");
            }
            else
            {
                Console.WriteLine("Invalid transition. The chest is already unlocked or open.");
            }
        }

        public void Open()
        {
            if (currentState == ChestState.Unlocked)
            {
                currentState = ChestState.Open;
                Console.WriteLine("The chest is now open.");
            }
            else if (currentState == ChestState.Closed)
            {
                Console.WriteLine("The chest must be unlocked first.");
            }
            else
            {
                Console.WriteLine("Invalid transition. The chest cannot be opened in the current state.");
            }
        }

        public void Close()
        {
            if (currentState == ChestState.Open)
            {
                currentState = ChestState.Closed;
                Console.WriteLine("The chest is now closed.");
            }
            else
            {
                Console.WriteLine("Invalid transition. The chest is not open.");
            }
        }

        public void ShowState()
        {
            Console.WriteLine($"Current chest state: {currentState}");
        }
    }



}

