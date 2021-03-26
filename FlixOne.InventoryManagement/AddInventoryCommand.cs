using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    /// <summary>
    /// Добавление объекта
    /// </summary>
    internal class AddInventoryCommand : NonTerminatingCommand, IParameterisedCommand
    {
        public string InventoryName { get; private set; }

        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");
            return !string.IsNullOrWhiteSpace(InventoryName);
        }

        internal override bool InternalCommand()
        {
            throw new NotImplementedException();
        }
    }
}
