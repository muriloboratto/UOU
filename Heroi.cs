using System;

namespace projetoOO
{
	public abstract class Heroi
	{
		protected string nome;
		protected float ptsVida;

		public Heroi (string nome, float ptsVida)
		{
			this.nome = nome;
			this.ptsVida = ptsVida;
		}

		public abstract void LancarMagia ();
		
		public abstract void AtacarComArma ();

		public virtual void ReduzirVida() 
		{
			this.ptsVida--;
		}

		public virtual void AumentarVida() 
		{
			this.ptsVida++;
		}

		public string GetNome() 
		{
			return this.nome;
		}

		public float GetPtsVida() 
		{
			return this.ptsVida;
		}
	}
}

