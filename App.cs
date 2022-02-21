using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole
{
    class App
    {
        public void Run()
        {
            var app = new nameLoad();
            app.nameLoading();
            var app2 = new IncCreate();
            app2.Create();
        }
    }
}
