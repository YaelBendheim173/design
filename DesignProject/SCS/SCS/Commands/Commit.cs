using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Commands
{
    internal class Commit : Command
    {
        public Commit(SCSReciever scs):base(scs)
        {
            
        }
        public override void Execute(FoldersAndFiles.FoldersAndFiles file)
        {
            scs.Commit(file);
            
        }
    }
}
