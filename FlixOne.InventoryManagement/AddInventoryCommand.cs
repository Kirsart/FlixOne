using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    public class AddInventoryCommand : InventoryCommand, IParameterisedCommand
    {
        public string InventoryName { get; private set; }

        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
            {
                InventoryName = GetParameter("name");
            }
        }

        internal override bool InternalCommand()
        {
            throw new NotImplementedException();
        }
    }
}
