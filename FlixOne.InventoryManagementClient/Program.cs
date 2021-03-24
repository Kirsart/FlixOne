using System;

namespace FlixOne.InventoryManagementClient
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Greeting();

            GetCommand("?").RunCommand(out bool shouldQuit);

            while (!shouldQuit)
            {
                Console.WriteLine(" > ");
                var input = Console.ReadLine();
                var command = GetCommand(input);

                var wasSuccessful = command.RunCommand(out shouldQuit);

                if (!wasSuccessful)
                {
                    Console.WriteLine("Enter ? to view options");
                }
            }

            Console.WriteLine("CatalogService has completed.");
        }
    }
}
