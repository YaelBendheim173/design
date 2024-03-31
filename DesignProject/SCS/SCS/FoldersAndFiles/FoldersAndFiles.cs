using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.FoldersAndFiles
{
    internal abstract class FoldersAndFiles
    {
        private States.State state;
        public FoldersAndFiles()
        {
            state = new States.Druft();
        }
        public abstract void Open();
        public void ChangeState(States.State state)
        {
            this.state = state;
        }
    }
}
