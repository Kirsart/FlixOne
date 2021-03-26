
namespace FlixOne.InventoryManagement
{
    /// <summary>
    /// Общий класс родитель для команд
    /// </summary>
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;

        protected IUserInterface Interface { get; }

        protected InventoryCommand(bool commandIsTerminating, IUserInterface userInterface)
        {
            _isTerminatingCommand = commandIsTerminating;
            Interface = userInterface;
        }
 
        public (bool waswasSuccessful, bool shouldQuit) RunCommand()
        {
            if (this is IParameterisedCommand parameterisedCommand)
            {
                var allParametersCompleted = false;

                while (allParametersCompleted == false)
                {
                    allParametersCompleted = parameterisedCommand.GetParameters();
                }
            }
            return (InternalCommand(), _isTerminatingCommand);
        }

        internal string GetParameter(string parameterName)
        {
            return Interface.ReadValue($"Enter {parameterName}:");
        }

        internal abstract bool InternalCommand();
    }
}
