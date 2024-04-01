using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Commands
{
    internal class UndoTheCommit : Command
    {
        public UndoTheCommit(SCSReciever scs) : base(scs)
        {

        }
        public override void Execute(FoldersAndFiles.FoldersAndFiles foldersAndFiles)
        {
            scs.UndoTheCommit(foldersAndFiles); 
        }
    }
}
