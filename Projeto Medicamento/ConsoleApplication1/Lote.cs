using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
        public DateTime Venc

        {
            get { return venc; }
            set { venc = value; }
        }

        public Lote() : this(0, 0, System.DateTime.MinValue)
        {

        }

        public Lote(int a, int b, DateTime c)
        {
            this.id = a;
            this.qtde = b;
            this.venc = c;
        }

        
        public String toString()
        {
            return "ID: " + this.id + " - Quantidade: " + this.qtde + " - Vencimento: " + this.venc.ToShortDateString();
        }

    }
}
