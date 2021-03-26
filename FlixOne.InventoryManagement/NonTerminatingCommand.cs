using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    /// <summary>
    /// Интерфейс команд не закрывающие программу
    /// </summary>
    internal abstract class NonTerminatingCommand : InventoryCommand
    {
        protected NonTerminatingCommand() : base(commandIsTerminating: false)
        {

        }

    }
    }
}
