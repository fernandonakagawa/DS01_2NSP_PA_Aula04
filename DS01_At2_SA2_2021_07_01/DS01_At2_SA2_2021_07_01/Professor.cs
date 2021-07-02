using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    class Professor:Pessoa
    {
        public string Departamento { get; set; }

        public Professor(string Departamento, string Nome, int id):base(id,Nome)
        {
            this.Departamento = Departamento;
        }

        public override void AcessarInstituicao()
        {
            this.NumeroAcessos++;
            Console.WriteLine($"Bem vindo professor(a) {this.Nome}!");
        }
    }
}
