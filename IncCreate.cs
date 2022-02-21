using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole
{
    class IncCreate
    {
        public List<string> Create()
        {
            var app = new nameLoad();
            string[] input = app.nameLoading();

            List<string> output3 = new List<string>();
            for (int i = 0; i < input.Length; i++)
            { 
            string inputing = input[i];
            string[] output = inputing.Split(' ');
                var res1 = output[0][0];
                var res2 = output[1][0];
                string output2 = res1 + ". " + res2;
                output3.Add(output2);
            }
            return output3;
        }
        public void Write2()
        {
            Console.WriteLine("Chcete podle jména(J), příjmení(p) nebo oboje(O)");
            string HAHAH = Console.ReadLine();
            Console.WriteLine("Jaké písmeno??????????");
            string BAHAHAH = Console.ReadLine();
            var app = new nameLoad();
            string[] input = app.nameLoading();

            List<string> output3 = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string inputing = input[i];
                string[] output = inputing.Split(' ');
                var res1 = output[0][0];
                var res2 = output[1][0];
                string output2 = res1 + ". " + res2;
                output3.Add(output2);
            }
            if (HAHAH == "J")
            {
                string ano = "";
                for (int i = 0; i < output3.Count; i++)
                {
                    ano = output3[i];
                    if (ano.Substring(0,1) == BAHAHAH)
                    {
                        Console.WriteLine(output3[i]);
                    }
                }
                
            }
            if (HAHAH == "p")
            {
                string ano = "";
                for (int i = 0; i < output3.Count; i++)
                {
                    ano = output3[i];
                    if (ano.Substring(3, 1) == BAHAHAH)
                    {
                        Console.WriteLine(output3[i]);
                    }
                }
            }
            if (HAHAH == "O")
            {
                for (int i = 0; i < output3.Count; i++)
                {
                    if (output3[i] == BAHAHAH)
                    {
                        Console.WriteLine(output3[i]);
                    }
                }
            }
        }
    }
}
