using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.FoldersAndFiles
{
    internal abstract class FoldersAndFiles
    {
        
        public States.State State { get; set; }
        public FoldersAndFiles()
        {
            State = new States.Druft(this,new Queue<States.State>());
        }
        public abstract List<FoldersAndFiles> Open();
        public void ChangeState(States.State state)
        {
            this.State = state;
        }  
    }
}
