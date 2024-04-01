using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.FoldersAndFiles
{
    internal class Folder:FoldersAndFiles
    {
        private List<FoldersAndFiles> children = new();
        public override List<FoldersAndFiles> Open()
        {
            return children;
        }
        public void Add(FoldersAndFiles f) 
        {
            children.Add(f);
        }
        public void Remove(FoldersAndFiles f)
        {
            children.Remove(f);
        }
        public List<FoldersAndFiles> GetChildren()
        {
            return children;
        }
    }
}
