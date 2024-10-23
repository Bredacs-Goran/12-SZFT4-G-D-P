using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Lib
{
    public enum Fuvek
    {
        Fukezdemeny,
        Fuvecske,
        Fucsomo
    }

    public record Fu(Fuvek Statusz)
    {
        public Fu();

        public Fuvek Statusz { get; private set; } = Statusz;

        public void Noves()
        {
            if (Statusz == Fuvek.Fukezdemeny)
            {
                Statusz = Fuvek.Fuvecske;
            }
            else if (Statusz == Fuvek.Fuvecske)
            {
                Statusz = Fuvek.Fucsomo;
            }
        }
        public void Megevett()
        {
            if (Statusz == Fuvek.Fucsomo)
            {
                Statusz = Fuvek.Fuvecske;
            }
            else if (Statusz == Fuvek.Fuvecske)
            {
                Statusz = Fuvek.Fukezdemeny;
            }
        }

        private static object GetDebuggerDisplay()
        {
            throw new NotImplementedException();
        }
    }

}
