using System;

namespace org.altervista.numerone.framework
{

    public class GiocatoreHelperCpu2 : GiocatoreHelperCpu
    {
        public GiocatoreHelperCpu2(ushort b) : base(b)
        {
        }

        public override ushort GetLivello()
        {
            return 3;
        }

        public override ushort Gioca(ushort x, Carta[] mano, ushort numeroCarte, Carta c, bool stessoSeme)
        {
            UInt16 i = (UInt16)ElaboratoreCarteBriscola.r.Next(0, UInt16.MaxValue);
            if (!briscola.StessoSeme(c))
            {
                if ((i = getSoprataglio(mano, numeroCarte, c, true)) < numeroCarte)
                    return i;
                if (c.GetPunteggio() > 0 && (i = GetBriscola(mano, numeroCarte)) < numeroCarte)
                {
                    if (c.GetPunteggio() > 4)
                        return i;
                    if (mano[i].GetPunteggio() > 0)
                        if (ElaboratoreCarteBriscola.r.Next() % 10 < 5)
                            return i;
                }
            }
            else
            {
                if (ElaboratoreCarteBriscola.r.Next() % 10 < 5 && (i = getSoprataglio(mano, numeroCarte, c, false)) < numeroCarte)
                    return i;
            }
            if (stessoSeme)
                i = GetPrimaCartaConSeme(mano, numeroCarte, c);
            if (i >= numeroCarte)
                i = 0;
            return i;
        }
    }
}
