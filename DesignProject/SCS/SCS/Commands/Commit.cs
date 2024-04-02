﻿using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Commands
{
    internal class Commit : Command
    {
        public Commit(FoldersAndFiles.FoldersAndFiles file) :base(file)
        {
            
        }
        public override void Execute()
        {
            scs.Commit(file);
            
        }
    }
}
