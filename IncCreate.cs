using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole
{
    class IncCreate
    {
        public string[] Create()
        {
            var app = new nameLoad();
            string[] input = app.nameLoading();
            List<string> outp = new List<string>();
            string res = "";
            for (int i = 0; i < input.Length; i++)
            { 
            string inputing = input[i];
            string[] output = inputing.Split(' ');
                for (int i2 = 0; i2 < output.Length - 1; i2++)
                {

                    string outputing = output[i2];
                    res = outputing.Substring(0, 1);
                    string outputi = output[i2 + 1];
                    string res2 = outputi.Substring(0, 1);
                }

            }
            return input;
        }
    }
}
