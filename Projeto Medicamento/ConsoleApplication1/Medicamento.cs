using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string lab;
        private Queue<Lote> loteMedics;

        public Queue<Lote> LoteMedics
        {
            get { return this.loteMedics; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }


        public string Laboratorio
        {
            get { return this.lab; }
            set { this.lab = value; }
        }

        public Medicamento()
        {
            this.loteMedics = new Queue<Lote>();
        }

        public Medicamento(int a, string b, string c)
        {
            this.id = a;
            this.nome = b;
            this.lab = c;

        }

        public int QtdeDisponivel()
        {
            Medicamento medic = new Medicamento(id, "1", "1");
            Int32 qtdeMedic = 0;

            Console.WriteLine("Informe qual é o ID do medicamento");
            id = Convert.ToInt32(Console.ReadLine());

            foreach (Lote lotezinho in loteMedics)
            {
                if (medic.Id.Equals(medic.Id))
                {
                    qtdeMedic += lotezinho.Qtde;
                }
            }

            return qtdeMedic;

        }

        public void Comprar(Lote a)
        {
            loteMedics.Enqueue(a);
        }

        public bool Vender(int a,Lote r)
        {
            int  id = 0;
            int quant = a;
            Lote lotezinho = new Lote();
            bool vendido = false;

            Console.WriteLine("Informe qual é o ID do medicamento");
            id = int.Parse(Console.ReadLine());

            Medicamentos medicamentos = new Medicamentos();

           
            foreach (Lote lot in loteMedics)
            {
                r.Qtde -= a;
                if (r.Qtde == 0)
                {
                    loteMedics.Enqueue(lot);

                }
            }
            vendido = true;

            return vendido;
        
        }

        public string toString()
        {
            return "ID: " + this.id + " - Nome: " + this.nome + " - Laboratório: " + this.lab;
        }

        public override bool Equals(object obj)
        {
            Medicamento p = (Medicamento)obj;
            return this.id.Equals(p.id);
        }

    }
}
