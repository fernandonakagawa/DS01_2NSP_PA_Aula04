using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    interface IPessoa
    {
        const int FALTAS_MAXIMAS = 25;
        string Nome { get; set; }
        int Id { get; }
        abstract void AcessarInstituicao();

    }
}
