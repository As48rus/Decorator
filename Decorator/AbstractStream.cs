using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AbstractStream
    {
        public string[] _txtFile { get; set; }
        public abstract void Wrire(string text);
        public abstract string[] Read();
        protected bool _isMultyLine = false;
        protected void ToMultyLine(string text)
        {
            _txtFile = text.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < _txtFile.Length - 1; i++)
                _txtFile[i] += ".";

            _isMultyLine = true;
        }
    }
}
