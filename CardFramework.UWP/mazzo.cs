/*
  *  This code is distribuited under GPL 3.0 or, at your opinion, any later version
 *  CBriscola 1.1.3
 *
 *  Created by Giulio Sorrentino (numerone) on 29/01/23.
 *  Copyright 2023 Some rights reserved.
 *
 */

using System;
namespace org.altervista.numerone.framework
{
    public class Mazzo
    {
        protected UInt16[] carte;
        protected UInt16 numeroCarte;
        protected readonly ElaboratoreCarte elaboratore;
        protected String nome;
        protected void Mischia()
        {
            for (numeroCarte = 0; numeroCarte < elaboratore.GetNumeroCarte(); numeroCarte++)
                carte[numeroCarte] = elaboratore.GetCarta();
        }


        public Mazzo(ElaboratoreCarte e)
        {
            elaboratore = e;
            carte = new UInt16[40];
            Mischia();
        }
        public UInt16 GetNumeroCarte() { return numeroCarte; }
        public UInt16 GetCarta()
        {
            if (numeroCarte > elaboratore.GetNumeroCarte())
                throw new IndexOutOfRangeException();
            UInt16 c = carte[--numeroCarte];
            return c;
        }

        public String GetNome() { return nome; }
        public void SetNome(String s) { nome = s; }
    };
}