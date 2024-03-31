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
        public abstract string Add();
        public abstract string Commit();
        public abstract string RequestReview();
        public abstract string Merge();
    }
}
