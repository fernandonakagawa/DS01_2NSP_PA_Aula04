using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    abstract class Pessoa:IPessoa
    {
        public static int NumeroPessoas = 0;
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int NumeroAcessos { get; protected set; }
        public Pessoa(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
            NumeroPessoas++;
        }
        public Pessoa(string Nome)
        {
            this.Id = NumeroPessoas++;
            this.Nome = Nome;
        }

        public abstract void AcessarInstituicao();
    }
}
