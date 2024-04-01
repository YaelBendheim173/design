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
        List<ISubscriber> subscribers;
        public UserInvoker()
        {
            commandsQueue = new Queue<Commands.Command>();
            commandsList = new List<Commands.Command>();
            subscribers = new List<ISubscriber>();
        }
        public void DoJob()
        {
            while (commandsQueue.Count > 0)
            {
                Command command = commandsQueue.Dequeue();
                commandsList.Add(command);
                Console.WriteLine(command);
            }
        }
        public void SCSCommandRequest(Command command)
        {
            commandsQueue.Enqueue(command);
        }
        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void UnSubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        public void NotifySubscribers(FoldersAndFiles.FoldersAndFiles f)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update(f);
            }
        }
        //public void CreateBranch(Branch branch)
        //{
        //    branch.Clone();
        //}
        //public void DeleteBranch(Branch branch)
        //{
            
        //}
    }
}
