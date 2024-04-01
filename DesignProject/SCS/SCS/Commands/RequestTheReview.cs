using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Commands
{
    internal class RequestTheReview : Command
    {
        public RequestTheReview(SCSReciever scs) : base(scs)
        {

        }
        public override void Execute(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            scs.RequestTheReview(foldersAndFiles);
        }
    }
}
