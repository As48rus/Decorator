using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Decorator
{
    public class Stream : IStream
    {
        //Полей и свойств класса AbstractStream не существует
         
        string _fileName = @"text.txt";
        public TextForFile Read(TextForFile textFile)
        {
            using (StreamReader sr = new StreamReader(_fileName, Encoding.UTF8))
            {
                //int i = 0;
                //while(!sr.EndOfStream)
                //    textFile._txtFile[i++] = sr.ReadLine();
                textFile._text = sr.ReadToEnd();

            }
            if (!textFile._isMultyLine)
                textFile.ToMultyLine();

            return textFile;
        }

        public void Wrire(TextForFile textFile)
        {
            if (!textFile._isMultyLine)
                textFile.ToMultyLine();

            using (StreamWriter sw = new StreamWriter(_fileName, false, Encoding.UTF8))
            {

                for (int i = 0; i < textFile._txtFile.Length; i++)
                {
                    sw.WriteLine(textFile._txtFile[i]); 
                }
            }
        }

    }
}
