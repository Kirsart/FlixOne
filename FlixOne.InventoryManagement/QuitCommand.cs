using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    public class QuitCommand : InventoryCommand
    {
        public QuitCommand () : base(false) { }

        internal override bool InternalCommand()
        {
            Console.WriteLine("Thank you for using FlixOne Inventory Mamagement System");
            return true;
        }
    }
}
