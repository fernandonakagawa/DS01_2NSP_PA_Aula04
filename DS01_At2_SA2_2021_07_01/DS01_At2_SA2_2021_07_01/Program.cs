using System;

namespace DS01_At2_SA2_2021_07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Gustavo", "DS", new DateTime(2000, 12, 12), 1);
            Aluno a2 = new Aluno("Fernando", "TI", new DateTime(1999, 01, 01), 2);
            Aluno a3 = new Aluno("Rodrigo", "DS", new DateTime(1998, 02, 02), 3);
            CadastroAluno c = new CadastroAluno();
            c.Incluir(a1);
            c.Incluir(a2);
            c.Incluir(a3);
            Console.WriteLine(c.NumeroPessoas);
            c.Excluir(2);
            Console.WriteLine(c.NumeroPessoas);
            Console.WriteLine(c.CursoDoAluno(a1));

            //Pessoa p1 = new Pessoa(4,"Victor");
            //c.Incluir(p1);
            //Console.WriteLine(c.CursoDoAluno(p1));

            Console.WriteLine(ConversaoDeUnidadesDeTemperatura.CelsiusParaFahrenheit(1.5f));

            //ConversaoDeUnidadesDeTemperatura.xyz(); X
            ConversaoDeUnidadesDeTemperatura obj = new ConversaoDeUnidadesDeTemperatura();
            obj.xyz();
            //obj.CelsiusParaFahrenheit(1.5f); X

            Professor prof1 = new Professor("Depto de TI", "Juliana", 5);
            c.Incluir(prof1);

            //Pessoa p2 = new Pessoa("Lucas");
            //Console.WriteLine($"{p2.Nome} id = {p2.Id}");
            a3.AcessarInstituicao();
            prof1.AcessarInstituicao();
            ProfessorConvidado pc1 = new ProfessorConvidado(new DateTime(2021, 08, 21),
                "Depto de TI", "Arthur", 7);
            pc1.AcessarInstituicao();
            Console.WriteLine(pc1.NumeroAcessos);

        }
    }
}
