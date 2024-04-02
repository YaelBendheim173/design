using SCS.Commands;
using SCS.Review;
using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS
{
    internal class UserInvoker
    {
        Queue<Commands.Command> commandsQueue;
        List<Commands.Command> commandsList;
        
        public UserInvoker()
        {
            commandsQueue = new Queue<Commands.Command>();
            commandsList = new List<Commands.Command>();
            
        }
        public void DoJob()
        {
            while (commandsQueue.Count > 0)
            {
                Command command = commandsQueue.Dequeue();
                command.Execute();
                commandsList.Add(command);
                Console.WriteLine(command);
            }
        }
        public void SCSCommandRequest(Command command)
        {
            commandsQueue.Enqueue(command);
        }
        
    }
}
