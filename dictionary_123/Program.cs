using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_123
{
    class Program
    {
        static void Main(string[] args)
        {
            FreqClass freq = new FreqClass();

            Dictionary<string, int> result = freq.FreqCount(@"c:\test\file.txt");


            FileStream stream = new FileStream(@"c:\test\result.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, Encoding.Default);
          

            foreach (string word in result.Keys)
            {

                writer.WriteLine(word + ": " + result[word]);

            }

            writer.Close();
            stream.Close();

        }
    }
}
