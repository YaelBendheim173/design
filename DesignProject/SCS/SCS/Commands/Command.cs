using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Commands
{
    internal abstract class Command
    {
        protected SCSReciever scs;
        public FoldersAndFiles.FoldersAndFiles file;
        public Command(FoldersAndFiles.FoldersAndFiles file)
        {
            this.file = file;
            scs=SCSReciever.GetSystem();
        }
        public abstract void Execute();
    }
}
