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
        public Translater(IStream stream) : base(stream)
        {

        }
        public override TextForFile Read(TextForFile textFile)
        {
            base.Read(textFile);
            if (!textFile._isMultyLine)
                textFile.ToMultyLine();

            //Translate(textFile);
            return textFile;
        }

        public override void Wrire(TextForFile textFile)
        {
            if (!textFile._isMultyLine)
                textFile.ToMultyLine();

            //Translate(textFile);
            base.Wrire(textFile);
        }

        private void Translate(TextForFile textFile)
        {
            throw new NotImplementedException();
        }
    }
}
