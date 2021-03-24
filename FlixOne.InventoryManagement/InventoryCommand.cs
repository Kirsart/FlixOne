using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    public abstract class InventoryCommand
    {
        public readonly bool _isTerminatingCommand;
        internal InventoryCommand(bool commandIsTerminating)
        {
            _isTerminatingCommand = commandIsTerminating;
        }

        public (bool waswasSuccessful, bool shouldQuit) RunCommand()
        {
            return (InternalCommand(), _isTerminatingCommand);
        }

        internal abstract bool InternalCommand();
    }
}
