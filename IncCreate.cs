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
    }
}
