using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface IStream
    {
        void Wrire(TextForFile textFile);
        TextForFile Read(TextForFile textFile);
    }
}
