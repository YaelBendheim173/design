using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.FoldersAndFiles
{
    internal class File:FoldersAndFiles
    {

        public override List<FoldersAndFiles> Open()
        {
            List<FoldersAndFiles> lst =new List<FoldersAndFiles>();
            lst.Add(this);
            return lst;
        }
        public void Update()
        {

        }
        
    }
}
