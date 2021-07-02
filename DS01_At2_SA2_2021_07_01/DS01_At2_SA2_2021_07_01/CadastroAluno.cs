using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    class CadastroAluno: CadastroGenerico
    {
        public string CursoDoAluno(Aluno a)
        {
            return a.Curso;
        }

        //sobreescrita, sobreposição 
        public override void Incluir(Pessoa p)
        {
            if(p is Aluno)
            {
                base.Incluir(p);
                Console.WriteLine($"Aluno {p.Nome} incluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Apenas é possível incluir Alunos!");
            }
        }
        public void Incluir(Aluno a)
        {
            base.Incluir(a);
        }

    }
}
