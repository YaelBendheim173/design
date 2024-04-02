﻿using SCS.SCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Commands
{
    internal class RequestTheReview : Command
    {
        public RequestTheReview(FoldersAndFiles.FoldersAndFiles file) : base(file)
        {
            scs.NotifySubscribers(file);
        }
        
        public override void Execute()
        {
            scs.RequestTheReview(file);
        }
    }
}
