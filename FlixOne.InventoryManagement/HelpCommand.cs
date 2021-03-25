using System;

namespace FlixOne.InventoryManagement
{
    public class HelpCommand : NonTerminatingCommand
    {

        internal override bool InternalCommand()
        {
            Console.WriteLine("USAGE:");
            Console.WriteLine("\taddinventory (a)");

            Console.WriteLine("Examples:");

            return true;
        }
    }
}
