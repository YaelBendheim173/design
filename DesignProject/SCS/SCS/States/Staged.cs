using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal class Staged: State
    {
        public Staged(FoldersAndFiles.FoldersAndFiles f, Queue<State> history) : base(f, history)
        {

        }
        public override string Add()
        {
            return "The file already added";
        }

        public override string Commit()
        {
            sourceFile.ChangeState(new Commited(sourceFile, history));
            return "The file already commited";
        }

        public override string Merge()
        {
            return "The file have to request a review";
        }

        public override string RequestReview()
        {
            sourceFile.ChangeState(new UnderReview(sourceFile,history));
            return "The file is under review";
        }
    }
}
