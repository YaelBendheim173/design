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
        public Command(SCSReciever scs)
        {
            this.scs = scs;
        }
        public abstract void Execute();
    }
}
