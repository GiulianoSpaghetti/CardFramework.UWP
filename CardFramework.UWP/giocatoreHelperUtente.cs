/*
  *  This code is distribuited under GPL 3.0 or, at your opinion, any later version
 *  CBriscola 1.1.3
 *
 *  Created by Giulio Sorrentino (numerone) on 29/01/23.
 *  Copyright 2023 Some rights reserved.
 *
 */

using org.altervista.numerone.framework;
using System;
using System.Collections.Generic;

namespace org.altervista.numerone.framework

{
    public class GiocatoreHelperUtente : GiocatoreHelper
	{
		public GiocatoreHelperUtente()
		{
			;
		}
		public UInt16 Gioca(UInt16 i, Carta[] v, UInt16 numeroCarte)
		{
			if (i < numeroCarte)
				return i;
			else
				throw new ArgumentException("");
		}
		public UInt16 Gioca(UInt16 i, Carta[] v, UInt16 numeroCarte, Carta c, bool stessoSeme=false)
		{

            UInt16 carta = Gioca(i, v, numeroCarte);
			if (stessoSeme)
			{
				UInt16 j = 0;
				if (!c.StessoSeme(v[carta]) && !v[i].StessoSeme(Carta.GetCartaBriscola()))
				{
					for (j = 0; j<numeroCarte && !c.StessoSeme(v[j]); j++) ;
					if (j != numeroCarte)
					{
						throw new Exception("Operazione non valida");
						return (UInt16)Giocatore.Carta_GIOCATA.NESSUNA_Carta_GIOCATA;
					}
				}
			}
			return carta;
		}
		public void AggiornaPunteggio(ref UInt16 punteggioAttuale, Carta c, Carta c1)
		{
			punteggioAttuale = (UInt16)(punteggioAttuale + c.GetPunteggio() + c1.GetPunteggio());
		}
        public ushort Gioca(ushort i, Carta[] v, ushort numeroCarte, List<Carta> piatto)
        {
            throw new NotImplementedException();
        }
    };
}