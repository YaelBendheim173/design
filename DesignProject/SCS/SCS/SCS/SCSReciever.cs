using SCS.FoldersAndFiles;
using SCS.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SCS.SCS
{
    internal class SCSReciever
    {
        private static SCSReciever system;
        public List<Branch> branchesList;
        List<ISubscriber> subscribers;
        private SCSReciever()
        {
            branchesList = new List<Branch>();
            branchesList.Add(new Branch());
            subscribers = new List<ISubscriber>();
        }
        public static object locker;

        static SCSReciever()
        {
            locker = new object();
        }
        public static SCSReciever GetSystem()
        {
            if (system == null)
            {
                lock (locker)
                {
                    if (system == null)
                    {
                        system = new SCSReciever();
                    }
                }
            }
            return system;
        }
        public string Add(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            foldersAndFiles.State.Add();
            return "The file added successfuly";
        }
        public string Merge(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            foldersAndFiles.State.Merge();
            return "The merge was successfully executed";
        }
        public string MergeBranch(Branch branch)
        {
            return "The merge was successfully executed";
        }
        public string UndoTheCommit(FoldersAndFiles.FoldersAndFiles foldersAndFiles) 
        {
            foldersAndFiles.State.history.Dequeue();
            States.State state = foldersAndFiles.State.history.Dequeue();
            foldersAndFiles.ChangeState(state);
            return "The file has returned to its previous state";
        }
        public string RequestTheReview(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            foldersAndFiles.State.RequestReview();
            return "the file sent to review";

        }
        public string DeleteBranch(Branch branch) 
        {
            branchesList.Remove(branch);
            return "The branch deleted successfully";
        }
        public string Commit(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            foldersAndFiles.State.Commit();
            return "The commit was successfuly executed";
        }
        public string CreateBranch(Branch branch)
        {
            Branch newBranch = new Branch();
            newBranch.Clone(branch);
            branchesList.Add(newBranch);
            return "The branch added successfuly";
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
