using System;
using System.IO;
using System.Text;
using static System.Console;

namespace homeTask10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text;
            string word;
            int count = 0;

            string filePath = "test.txt";

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    Text = sr.ReadToEnd();
                }
            }

         string[] textArray = Text.Split(' ',  '-', '.', ',');
            WriteLine("Введите слово");
            word = Convert.ToString(ReadLine());

            for (int i = 0; i < textArray.Length - 1; i++)
            {
                if (textArray[i].Equals(word))
                {
                    count++;
                }
            }

            WriteLine($"Данное слово встречается {count} раз");
        }
    }
}
