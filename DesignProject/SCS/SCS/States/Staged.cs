using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal class Staged: State
    {
        public Staged(FoldersAndFiles.FoldersAndFiles f) : base(f)
        {

        }
        public override string Add()
        {
            return "The file already added";
        }

        public override string Commit()
        {
            sourceFile.ChangeState(new Commited(sourceFile));
            return "The file already commited";
        }

        public override string Merge()
        {
            return "The file have to request a review";
        }

        public override string RequestReview()
        {
            sourceFile.ChangeState(new UnderReview(sourceFile));
            return "The file is under review";
        }
    }
}
