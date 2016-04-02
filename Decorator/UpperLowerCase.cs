using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class UpperLowerCase : DecoratorStream
    {
        public UpperLowerCase() { }
        public UpperLowerCase(AbstractStream stream) : base(stream)
        {
            //_stream = stream;
        }
        public override string[] Read()
        {
            base.Read();
            UpperLower();
            return _txtFile;
        }

        public override void Wrire(string text)
        {
            if(!_isMultyLine)
                ToMultyLine(text);
            UpperLower();
            base.Wrire(text);
        }

        public void UpperLower()
        {
            for (int i = 0; i < _txtFile.Length; i++)
            {
                _txtFile[i] = _txtFile[i].ToLower();
                char firsSymbol = _txtFile[i].First();
                firsSymbol = (char)(firsSymbol - 32);
                _txtFile[i].Remove(0);
                _txtFile[i] = firsSymbol + _txtFile[i];
            }
        }

    }
}
