using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.States
{
    internal class Commited : State
    {
        public Commited(FoldersAndFiles.FoldersAndFiles f):base(sourceFile,history)
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
            sourceFile.ChangeState(new UnderReview(sourceFile));
            return "The file is under review";
        }
    }
}
