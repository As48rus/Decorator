using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IStream stream = new Stream();
            TextForFile textFile = new TextForFile();
            args = new string[5];
            /*
            Console.WriteLine("Текст для обработки:\n");
            args[0] = Console.ReadLine();
            

            Console.WriteLine("\n\nПорядок обработки:\n1 - Форматирование текста\n2 - Превод\n3 - Чтение из файла\n4 - Запись в файл\n0 - Закончить");


            int y = 0;
            while(args[y] != "0")
                args[++y] = Console.ReadLine();
            */

            ////////////////////////////////////////////////
            args[0] = "давно выяснено, что при оценке дизайна И композиции читаемый текст мешает сосредоточиться. используют потому, Xто тот беспечивает более или Mенее стAндартное заполнение шаблона, а также реальное распределение букв и пробелов в абзацах, котор";
			args[1] = "1";
            args[2] = "2";
            args[3] = "3";
            args[4] = "0";
            ///////////////////////////////////////////////
            textFile._text = args[0];

			for (int i = 1; i < 4; i++)
            {
                if(args[i] == "1")
                {
                    stream = new UpperLowerCase(stream);
                    continue;
                }

                if (args[i] == "2")
                {
                    stream = new Translater(stream);
                    continue;
                }

                if (args[i] == "3")
                {
                    stream.Read(textFile);
                    break;
                }

                if (args[i] == "4")
                {
                    stream.Wrire(textFile);
                    break;
                }
            }

            if(textFile._txtFile != null)
            {
                for (int i = 0; i < textFile._txtFile.Length; i++)
                    Console.WriteLine(textFile._txtFile[i]);
                Console.ReadLine();
            }
        }
    }
}
