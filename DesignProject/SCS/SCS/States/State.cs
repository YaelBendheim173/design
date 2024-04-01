using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal abstract class State
    {
        public Queue<State> history;
        protected FoldersAndFiles.FoldersAndFiles sourceFile;
        public State(FoldersAndFiles.FoldersAndFiles sourceFile, Queue<State> history)
        {
            sourceFile = sourceFile;
            this.history = history;
            this.history.Enqueue(this);

        }
        public abstract string Add();
        public abstract string Commit();
        public abstract string RequestReview();
        public abstract string Merge();
    }
}
