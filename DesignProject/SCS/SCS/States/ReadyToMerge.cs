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
        public override void Add()
        {
            throw new NotImplementedException();
        }

        public override void Commit()
        {
            throw new NotImplementedException();
        }

        public override void Merge()
        {
            throw new NotImplementedException();
        }

        public override void RequestReview()
        {
            throw new NotImplementedException();
        }
    }
}
