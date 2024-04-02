using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal class UnderReview: State
    {
        public UnderReview(FoldersAndFiles.FoldersAndFiles f, Queue<State> history) : base(f, history)
        {

        }
        public override string Add()
        {
            return "The file already added";
        }

        public override string Commit()
        {
            return "The file already commited";
        }

        public override string Merge()
        {
            sourceFile.ChangeState(new Merged(sourceFile, history));
            return "The file have to request a review";
        }

        public override string RequestReview()
        {
            sourceFile.ChangeState(new UnderReview(sourceFile,history));
            return "The file is under review";
        }
    }
}
