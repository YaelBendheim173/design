using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal class Merged : State
    {
        public Merged(FoldersAndFiles.FoldersAndFiles f, Queue<State> history) : base(f,history)
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
            return "The file have to request a review";
        }

        public override string RequestReview()
        {
            sourceFile.ChangeState(new UnderReview(sourceFile, history));
            return "The file is under review";
        }
    }
}
