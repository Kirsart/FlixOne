using System;

namespace FlixOne.InventoryManagement
{

    internal class HelpCommand : NonTerminatingCommand
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
