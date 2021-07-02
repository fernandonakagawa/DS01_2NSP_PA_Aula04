using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    class Aluno:Pessoa
    {
        
        public string Curso { get; set; }
        public DateTime DataNasc { get; set; }

        public Aluno(string Nome, string Curso, DateTime DataNasc, 
            int Id):base(Id, Nome)
        {
            this.Curso = Curso;
            this.DataNasc = DataNasc;
        }

        public override void AcessarInstituicao()
        {
            this.NumeroAcessos++;
            Console.WriteLine($"Bem vindo aluno(a) {this.Nome}!");
        }
    }
}
