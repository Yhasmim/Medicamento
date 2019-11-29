using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static Medicamento minhaListaMedicamento = new Medicamento();
        static Medicamentos minhaListaMedicamentos = new Medicamentos();
        static Lote lotParc = new Lote();
      
        static void Main(string[] args)
        {
            int op;
            do
            {

                Console.WriteLine("+=================================================================+");
                Console.WriteLine("| 0. Finalizar processo                                           |");
                Console.WriteLine("| 1. Cadastrar medicamento                                        |");
                Console.WriteLine("| 2. Consultar medicamento (sintético: Informar dados)            |");
                Console.WriteLine("| 3. Consultar medicamento (analítico: Informar dados + Lotes)    |");
                Console.WriteLine("| 4. Comprar medicamento (Cadastrar lote)                         |");
                Console.WriteLine("| 5. Vender medicamento (Abater do lote mais antigo)              |");
                Console.WriteLine("| 6. Listar medicamentos (Informar dados sintéticos)              |");
                Console.WriteLine("+=================================================================+");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

                #region OPCAO 1
                if (op == 1)
                {
                    Console.Clear();
                    //Entrada

                    //Variaveis
                    int id;
                  //  int idLote;
                  //  int qtdeLote;
                    string nome;
                    string laboratorio;
                 //   DateTime vencLote;

                    Console.WriteLine("Informe qual é o ID do medicamento");
                    id = int.Parse((Console.ReadLine()));

                    Console.WriteLine("Informe qual é o nome do medicamento");
                    nome = Console.ReadLine();

                    Console.WriteLine("Informe qual é o nome do laboratório");
                    laboratorio = Console.ReadLine();

                    minhaListaMedicamentos.Adicionar(new Medicamento(id, nome, laboratorio)); // erro

                    Console.WriteLine("Medicamento adicionado com sucesso!");

                    Console.ReadKey();
                }//OPC 1
                #endregion
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Informe qual é o ID do medicamento que você gostaria de pesquisar.");
                    int id = int.Parse((Console.ReadLine()));

                    Console.Clear();
                    Medicamento medicamento = minhaListaMedicamentos.Pesquisar(new Medicamento(id, "1", "1"));

                    if (minhaListaMedicamentos.Existe == true)
                    {
                        Console.WriteLine("Medicamento encontrado.");
                        minhaListaMedicamentos.Existe = false;
                        Console.WriteLine("");
                        Console.WriteLine(medicamento.toString());
                    }
                    else
                    {
                        Console.WriteLine("Medicamento não existe na lista.");
                    }
                   
                    Console.ReadKey();
                }//OPC 2
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Informe qual é o ID do medicamento que você gostaria de pesquisar.");
                    int id = int.Parse((Console.ReadLine()));

                    Console.Clear();
                    Medicamento medicamento = minhaListaMedicamentos.Pesquisar(new Medicamento(id, "1", "1"));
                    foreach (Lote lot in minhaListaMedicamento.LoteMedics/*loteMedics*/)
                    {
                        if (lot.Id.Equals(id))
                        {
                            lotParc = lot;
                        }
                    }

                    if (minhaListaMedicamentos.Existe == true)
                    {
                        Console.WriteLine("Medicamento encontrado.");
                        minhaListaMedicamentos.Existe = false;
                        Console.WriteLine("");
                        Console.WriteLine(medicamento.toString() + " " + lotParc.toString());
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Medicamento não existe na lista.");
                    }

                    Console.ReadKey();
                }//OPC 3
                else if (op == 4)
                {
                    Console.Clear();
                    
                    DateTime venc = System.DateTime.Now;

                    lotParc.Venc = venc;


                    Console.WriteLine("Informe qual é o ID do Lote");
                    lotParc.Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe qual é a quantidade e medicamentos do lote");
                    lotParc.Qtde = Convert.ToInt32(Console.ReadLine());

                    minhaListaMedicamento.Comprar(lotParc);

                    Console.Clear();
                    Console.WriteLine("Medicamento comprado sucesso.");
                    Console.ReadKey();
                }//OPC 4
                else if (op == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Informe qual é a quantidade a ser vendida ?");
                    int qtde = int.Parse((Console.ReadLine()));

                    if (minhaListaMedicamento.Vender(qtde,lotParc))
                    {
                        Console.WriteLine("Medicamento vendido com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Erro ao vender o medicamento. Por favor tente novamente.");
                    }
                    Console.ReadKey();
                }//OPC 5
                else if (op == 6)
                {
                    Console.Clear();

                    foreach (Medicamento medic in minhaListaMedicamentos.ListaMedicamentos)
                    {
                        Console.WriteLine(medic.toString());
                    }
                    Console.ReadKey();
                }//OPC 6
            } while (op != 0);

        }
    }
}
