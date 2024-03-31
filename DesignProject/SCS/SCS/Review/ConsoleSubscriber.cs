using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCS.Review
{
    internal class ConsoleSubscriber:ISubscriber
    {
        public void Update(FoldersAndFiles.FoldersAndFiles f)
        {
            PrintToConsole(f);
        }
        public void PrintToConsole(FoldersAndFiles.FoldersAndFiles f)
        {

        }
    }
}
