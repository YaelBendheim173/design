using SCS.Review;
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
         
        }
        public void SCSCommandRequest()
        {

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
    }
}
