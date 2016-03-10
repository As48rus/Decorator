using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Translater : DecoratorStream
    {
        public Translater() { }
        public Translater(AbstractStream stream) : base(stream)
        {

        }
        public override string[] Read()
        {
            base.Read();
            //Translate();
            return _txtFile;
        }

        public override void Wrire(string text)
        {
            //Translate();
            base.Wrire(text);
        }

        private void Translate()
        {
            throw new NotImplementedException();
        }
    }
}
