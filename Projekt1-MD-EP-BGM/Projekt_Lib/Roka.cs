using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Lib
{
    public class Roka
    {
        public int Telitettseg { get; private set; }
        private const int maxtelitettseg = 10;

        public Roka()
        {
            Telitettseg = maxtelitettseg;
        }
        public void Eves(Nyulak nyul)
        {
            Telitettseg += 3;
            if (Telitettseg > maxtelitettseg)
                Telitettseg = maxtelitettseg;
        }




    }



}
