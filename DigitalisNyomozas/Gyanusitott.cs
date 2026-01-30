using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Gyanusitott
	{
		private Szemely szemely;
		private int gyanusitottsag;
		private string statusz;

		public Gyanusitott(Szemely szemely, int gyanusitottsag, string statusz)
		{
			this.szemely = szemely;
			this.gyanusitottsag = 0;
			this.statusz = statusz;
		}

		public int Gyanusitottsag { get => gyanusitottsag; set => gyanusitottsag = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Szemely Szemely { get => szemely; set => szemely = value; }



	}
}
