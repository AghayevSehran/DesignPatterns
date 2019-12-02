using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> entries
            = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(
                Environment.NewLine, entries);
        }
        /* SIngle responsibility
        public void Save(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }
        public static Journal Load(string fileName)
        {

        }
        public void Load(Uri uri)
        {
        }
        */

    }
    public class Persistence
    {
        public void SaveToFle(Journal j, string fileName, bool overwrite)
        {
            if (overwrite || !File.Exists(fileName))
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(j.ToString());
                }
                    
            }
        }
    }
    //A class should have one and only one reason to change, 
    //meaning that a class should have only one job.
    internal class Program
    {
        private static void Main(string[] args)
        {
            Journal j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);


            Persistence p = new Persistence();
            string fileName = @"C:\journal.txt";
            p.SaveToFle(j, fileName, true);
            Process.Start(fileName);
            Console.ReadKey();
        }
    }
}
