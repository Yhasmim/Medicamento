using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;
        private bool existe;

        public Boolean Existe
        {
            get { return this.existe; }
            set { existe = value; }
        }

        public List<Medicamento> ListaMedicamentos
        {
            get { return this.listaMedicamentos; }
        }

        public Medicamentos()
        {
            this.listaMedicamentos = new List<Medicamento>();

        }

        public void Adicionar(Medicamento a)
        {
            ListaMedicamentos.Add(a);

        }


        public bool Deletar(Medicamento a)
        {
            bool deletado = false;

            Lote lotinho = new Lote();

            foreach (Medicamento medicamentinho in listaMedicamentos)
            {
                if (lotinho.Qtde == 0)
                {
                    ListaMedicamentos.Remove(a);
                    deletado = true;
                }
            }
            return deletado;
        }

        public Medicamento Pesquisar(Medicamento a)
        {
            Medicamento resultMedic = new Medicamento();

            foreach (Medicamento medic in listaMedicamentos)
            {
                if (medic.Equals(a))
                {
                    resultMedic = medic;
                    existe = true;
                }
            }
            return resultMedic;
        }

    }
}
