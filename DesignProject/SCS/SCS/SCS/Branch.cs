using SCS.FoldersAndFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.SCS
{
    internal class Branch
    {
        private List<FoldersAndFiles.FoldersAndFiles> files = new();
        public void Add(FoldersAndFiles.FoldersAndFiles f)
        {

        }
        public void Remove(FoldersAndFiles.FoldersAndFiles f)
        {

        }
        public List<FoldersAndFiles.FoldersAndFiles> GetFiles()
        {
            return files;
        }
    }
}
