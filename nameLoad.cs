using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole
{
    public class nameLoad
    {
        public string[] nameLoading()
        {
            using var sr = new StreamReader("inpuit.txt");
            string line = sr.ReadToEnd();
            string[] output = line.Split("\r\n");
            return output;
        }
        public void Write()
        {
            string[] input = nameLoading();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
                i++;
            }
        }
    }
}
