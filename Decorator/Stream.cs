using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Decorator
{
    public class Stream : AbstractStream
    {
        //Полей и свойств класса AbstractStream не существует
         
        string _fileName = @"text.txt";
        public override string[] Read()
        {
            using (StreamReader sr = new StreamReader(_fileName, Encoding.UTF8))
            {
                int i = 0;
                while(!sr.EndOfStream)
                    _txtFile[i++] = sr.ReadLine();

                return _txtFile;
            }
        }

        public override void Wrire(string text)
        {
            //if (!_isMultyLine)
            //    ToMultyLine(text);

            using (StreamWriter sw = new StreamWriter(_fileName, false, Encoding.UTF8))
            {

                for (int i = 0; i < _txtFile.Length; i++)
                {
                    sw.WriteLine(_txtFile[i]); 
                }
            }
        }

    }
}
