namespace Simulas_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Chest chest = new Chest();

            while (true)
            {

                Console.WriteLine("Enter a command (lock, unlock, open, close, state, or exit): ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "lock":
                        chest.Lock();
                        break;
                    case "unlock":
                        chest.Unlock();
                        break;
                    case "open":
                        chest.Open();
                        break;
                    case "close":
                        chest.Close();
                        break;
                    case "state":
                        chest.ShowState();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command. Please enter a valid command.");
                        break;
                }
            }
        }
    }
}
