using System;

namespace projetoOO
{
	public class UoU
	{
		public static void Main ()
		{
			
			//Heroi da Alianca
			Heroi Cavaleiro = new HeroiAlianca ("Zadur", 100);
			Console.WriteLine (Cavaleiro.GetNome () + " " + Cavaleiro.GetPtsVida ());

			Console.WriteLine ("Reduzindo vida de " + Cavaleiro.GetNome () + "...");
			Cavaleiro.ReduzirVida ();
			Console.WriteLine (Cavaleiro.GetNome () + " " + Cavaleiro.GetPtsVida ());

			Console.WriteLine ("Aumentando vida de " + Cavaleiro.GetNome () + "...");
			Cavaleiro.AumentarVida ();
			Console.WriteLine (Cavaleiro.GetNome () + " " + Cavaleiro.GetPtsVida ());
            Console.WriteLine ("\n");

			//Heroi da Horda
			Heroi Ogro = new HeroiHorda ("Zodar", 100);
			Console.WriteLine (Ogro.GetNome () + " " + Ogro.GetPtsVida ());

			Console.WriteLine ("Reduzindo vida de " + Ogro.GetNome () + "...");
			Ogro.ReduzirVida ();
			Console.WriteLine (Ogro.GetNome () + " " + Ogro.GetPtsVida ());

			Console.WriteLine ("Aumentando vida de " + Ogro.GetNome () + "...");
			Ogro.AumentarVida ();
			Console.WriteLine (Ogro.GetNome () + " " + Ogro.GetPtsVida ());
            Console.WriteLine ("\n");
		
			//Demonstrando polimorfismo
			Cavaleiro.AtacarComArma ();
			Ogro.AtacarComArma ();

			Cavaleiro.LancarMagia ();
			Ogro.LancarMagia ();

		}
	}
}

