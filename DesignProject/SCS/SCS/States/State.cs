using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal abstract class State
    {
        protected FoldersAndFiles.FoldersAndFiles sourceFile;
        public State(FoldersAndFiles.FoldersAndFiles f)
        {
            sourceFile = f;
        }
        public abstract void Add();
        public abstract void Commit();
        public abstract void RequestReview();
        public abstract void Merge();
    }
}
