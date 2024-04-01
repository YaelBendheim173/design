using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal class ReadyToMerge : State
    {
        public ReadyToMerge(FoldersAndFiles.FoldersAndFiles f) : base(f)
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
            sourceFile.ChangeState(new Merged(sourceFile));
            return "The file was merged";
        }

        public override string RequestReview()
        {
            return "The file dont need check";
        }
    }
}
