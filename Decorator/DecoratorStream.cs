using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DecoratorStream : IStream
    {
        public IStream _stream;

        public DecoratorStream() { }

        public DecoratorStream(IStream stream)
        {
            _stream = stream;
        }

        public  void SetDecoratorStream(IStream stream)
        {
            _stream = stream;
        }

        public virtual TextForFile Read(TextForFile textFile)
        {
            if(_stream != null)
                _stream.Read(textFile);

            return textFile;
        }

        public virtual void Wrire(TextForFile textFile)
        {
            if (_stream != null)
                _stream.Wrire(textFile);
        }
    }
}
