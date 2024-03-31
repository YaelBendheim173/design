using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Review
{
    internal interface ISubscriber
    {
        public void Update(FoldersAndFiles.FoldersAndFiles f);
    }
}
