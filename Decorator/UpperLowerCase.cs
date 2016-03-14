using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class UpperLowerCase : DecoratorStream
    {
        public UpperLowerCase(IStream stream) : base(stream)
        {
        }
        public override TextForFile Read(TextForFile textFile)
        {
            base.Read(textFile);
            if (!textFile._isMultyLine)
                textFile.ToMultyLine();

            UpperLower(textFile);
            return textFile;
        }

        public override void Wrire(TextForFile textFile)
        {
            if(!textFile._isMultyLine)
                textFile.ToMultyLine();
            UpperLower(textFile);
            base.Wrire(textFile);
        }

        public void UpperLower(TextForFile textFile)
        {
            for (int i = 0; i < textFile._txtFile.Length; i++)
            {
                textFile._txtFile[i] = textFile._txtFile[i].ToLower();
                char firsSymbol = textFile._txtFile[i].First();
                firsSymbol = (char)(firsSymbol - 32);
                textFile._txtFile[i] = textFile._txtFile[i].Remove(0,1);
                textFile._txtFile[i] = firsSymbol + textFile._txtFile[i];
            }
        }

    }
}
