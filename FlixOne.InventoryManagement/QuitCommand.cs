using System;


namespace FlixOne.InventoryManagement
{
    /// <summary>
    /// Выход из программы
    /// </summary>
    public class QuitCommand : InventoryCommand
    {
        internal QuitCommand (IUserInterface userInterface) : base(true, userInterface) 
        { 
        }

        protected override bool InternalCommand()
        {
            Interface.WriteMessage("Thank you for using FlixOne Inventory Mamagement System");
            return true;
        }
    }
}
