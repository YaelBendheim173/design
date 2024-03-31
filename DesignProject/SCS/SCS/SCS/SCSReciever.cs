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
        public void Merge()
        {

        }
        public void UndoTheCommit() 
        { 

        }
        public void RequestTheReview()
        {

        }
        public void DeleteBranch() 
        { 

        }
        public void Commit()
        {

        }
        public void CreateBranch()
        {

        }
    }
}
