using System;
using System.Text;

namespace StudentnamesAsNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] names = System.IO.File.ReadAllLines(@"D:\PU-IntroCSharp-2018-1801681067\STDB2 PUIntroHomeworks - 1801681067\week6H6\StudentNames.txt");
            int nameValue = 0;
            char smileyFace = '\u263a';
            foreach (string name in names)
            {
                foreach (char ch in name)
                {
                    nameValue = nameValue + ch;

                }
                if (nameValue > 1500) Console.WriteLine("{0} student's sum of names is {1} {2}", name, nameValue, smileyFace);
                else Console.WriteLine("{0} student's sum of names is {1}", name, nameValue);
                nameValue = 0;


            }
        }
    }
}
