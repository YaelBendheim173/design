using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Commands
{
    internal class Merge: Command
    {
        public Merge(SCSReciever scs) : base(scs)
        {

        }
        public override void Execute(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            scs.Merge(foldersAndFiles);
        }
    }
}
