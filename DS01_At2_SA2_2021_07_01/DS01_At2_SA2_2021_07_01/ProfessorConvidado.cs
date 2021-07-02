using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    class ProfessorConvidado:Professor
    {
        public DateTime Permanencia { get; set; }

        public ProfessorConvidado(DateTime Permanencia, 
            string Departamento, string Nome, int id):base(Departamento,Nome, id)
        {
            this.Permanencia = Permanencia;
        }

    }
}
