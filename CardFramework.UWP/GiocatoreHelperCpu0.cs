using System;

namespace org.altervista.numerone.framework
{
    public class GiocatoreHelperCpu0 : GiocatoreHelperCpu
    {
        public GiocatoreHelperCpu0(ushort b) : base(b)
        {
        }

        public override ushort GetLivello()
        {
            return 1;
        }

        public override UInt16 Gioca(UInt16 x, Carta[] mano, UInt16 numeroCarte, Carta c, bool stessoSeme)
        {
            UInt16 carta = numeroCarte;
            for (UInt16 i = 0; i < numeroCarte - 1 && carta == numeroCarte; i++)
                if (briscola.StessoSeme(mano[i]))
                    carta = i;

            if (carta == numeroCarte)
                if (stessoSeme)
                    carta = GetPrimaCartaConSeme(mano, numeroCarte, c);
                else
                    carta = 0;
            return carta;
        }
    }

}
