using System;

namespace projetoOO
{
	public class HeroiHorda : Heroi
	{
		public HeroiHorda (string nome, int ptsVida) : base(nome, ptsVida)
		{
		}
	
		public override void LancarMagia ()
		{
			Console.WriteLine ("Caminho de chamas!!!");
		}

		public override void AtacarComArma() 
		{
			Console.WriteLine ("Golpe de machado!!!");
		}

		public override void ReduzirVida ()
		{
			this.ptsVida -= 0.8f;
		}
	
	}
}

