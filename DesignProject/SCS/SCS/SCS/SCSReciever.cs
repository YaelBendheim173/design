using SCS.FoldersAndFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.SCS
{
    internal class SCSReciever
    {
        private SCSReciever system;
        List<Branch> branchesList;
        private SCSReciever()
        {
            system = new SCSReciever();
        }
        public SCSReciever GetSystem()
        {
            if (system == null)
            {
                system = new SCSReciever();
            }
            return system;
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
            foldersAndFiles.State.history.Enqueue(state);
            return "The file has returned to its previous state";
        }
        public string RequestTheReview(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            foldersAndFiles.State.RequestReview();
            return "the file sent to review";

        }
        public string DeleteBranch(Branch branch) 
        {
            return "The branch deleted successfully";
        }
        public string Commit(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            foldersAndFiles.State.Commit();
            return "The commit was successfuly executed";
        }
        public Branch CreateBranch(Branch branch)
        {
            Branch newBranch = new Branch();
            newBranch = branch;
            return newBranch;
        }
    }
}
