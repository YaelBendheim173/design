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
        public Merge(FoldersAndFiles.FoldersAndFiles file) : base(file)
        {

        }
        
        public override void Execute()
        {
            scs.Merge(file);
        }
    }
}
