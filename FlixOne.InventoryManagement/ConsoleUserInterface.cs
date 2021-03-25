using System;

namespace FlixOne.InventoryManagement
{
    /// <summary>
    /// Взаимодействие пользователя с консолью
    /// </summary>
    public class ConsoleUserInterface
    {
        /// <summary>
        /// Чтнение сообщения с консоли
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns></returns>
        public string ReadValue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Вывод сообщения на консоль
        /// </summary>
        /// <param name="message">Сообщение</param>
        public void WriteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Вывод предупреждения на консоль
        /// </summary>
        /// <param name="message"></param>
        public void WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
        }
    }
}
