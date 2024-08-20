using System;namespace org.altervista.numerone.framework
{
    public class GiocatoreHelperCpu1 : GiocatoreHelperCpu
    {
        public GiocatoreHelperCpu1(ushort b) : base(b)
        {
        }

        public override ushort GetLivello()
        {
            return 2;
        }

        public override ushort Gioca(ushort x, Carta[] mano, ushort numeroCarte, Carta c, bool stessoSeme)
        {
            UInt16 carta=numeroCarte;
            UInt16 i = (UInt16)ElaboratoreCarteBriscola.r.Next(0, UInt16.MaxValue);
            if (!briscola.StessoSeme(c))
            {
                if ((i = getSoprataglio(mano, numeroCarte, c, true)) < numeroCarte)
                    carta = i;
                else
                    for (i = 0; i < (numeroCarte - 1) && carta==numeroCarte; i++)
                        if (briscola.StessoSeme(mano[i]))
                            carta = i;
            }
            if (carta == numeroCarte)
                if (stessoSeme)
                    carta = GetPrimaCartaConSeme(mano, numeroCarte, c);
                else
                    carta = 0;
            return carta;
        }
    }
}
