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
        public UndoTheCommit(FoldersAndFiles.FoldersAndFiles file) : base(file)
        {

        }
        public override void Execute()
        {
            scs.UndoTheCommit(file); 
        }
    }
}
