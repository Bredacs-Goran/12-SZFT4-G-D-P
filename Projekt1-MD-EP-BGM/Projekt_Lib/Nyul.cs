namespace Projekt_Lib
{
    public class Nyul
    {
        public int Telitettseg { get; private set; }
        private const int maxtelitettseg = 5;

        public Nyul()
        {
            Telitettseg = maxtelitettseg;
        }

        public void Eves(Fu fu)
        {
            string taplalek = fu.Statusz();
            if (taplalek = Fukezdemeny && Telitettseg + taplalek <= maxtelitettseg)
            {
                Telitettseg += taplalek;
                fu.Evett();
            }
        }


    }
}
