using System;

namespace projetoOO
{
	public class HeroiAlianca : Heroi
	{
		public HeroiAlianca (string nome, int ptsVida) : base (nome, ptsVida)
		{

		}

		public override void LancarMagia ()
		{
			Console.WriteLine ("Força Rutilante!!!");
		}

		public override void AtacarComArma() 
		{
			Console.WriteLine ("Golpe de espada!!!");
		}

		public override void AumentarVida ()
		{
			this.ptsVida += 0.2f;
		}
	}
}

