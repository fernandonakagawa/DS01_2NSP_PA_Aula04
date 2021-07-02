using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    class CadastroGenerico
    {
        public List<Pessoa> Pessoas { get; private set; }
        public int NumeroPessoas { 
            get
            {
                return this.Pessoas.Count;
            } 
        }

        public CadastroGenerico()
        {
            this.Pessoas = new List<Pessoa>();
        }

        public virtual void Incluir(Pessoa p)
        {
            this.Pessoas.Add(p);
        }
        public void Excluir(int id)
        {
            Pessoa p = Busca(id);
            if (p != null) this.Pessoas.Remove(p);
        }
        public Pessoa Busca(int id)
        {
            foreach(Pessoa p in this.Pessoas)
            {
                if (p.Id == id) return p;
            }
            return null;
        }
    }
}
