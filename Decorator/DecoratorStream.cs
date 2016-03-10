using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DecoratorStream : AbstractStream
    {
        protected AbstractStream _stream;

        public DecoratorStream() { }

        public DecoratorStream(AbstractStream stream)
        {
            _stream = stream;
        }

        public void SetDecoratorStream(AbstractStream stream)
        {
            _stream = stream;
        }

        public override string[] Read()
        {
            if(_stream != null)
                _stream.Read();

            return _txtFile;
        }

        public override void Wrire(string text)
        {
            if (_stream != null)
                _stream.Wrire(text);
        }
    }
}
