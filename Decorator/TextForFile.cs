using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TextForFile
    {
        public string[] _txtFile { get; set; }
        public string _text { get; set; }
        public bool _isMultyLine = false;

        public void ToMultyLine()
        {
            _txtFile = _text.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < _txtFile.Length - 1; i++)
                _txtFile[i] += ".";

            _isMultyLine = true;
        }

    }
}
