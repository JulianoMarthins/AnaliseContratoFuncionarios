using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperior {
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("        Programado por JulianoMarthins");

            Console.WriteLine("     =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

            Console.Write("Número de funcionários para registrar: ");
            int num = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();
            

            for(int i = 0; i < num; i++) {

                Console.Write($"\nDigite os dados do {i + 1}° funcionário: ");                
                Console.Write("Id: ");
                int variavel = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                
                funcionarios.Add(new Funcionario(variavel, nome, salario));
            
            }

            foreach(Funcionario func in funcionarios) {
                Console.WriteLine(func.ToString());
            }

            Console.WriteLine("\n     =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

            Console.Write("   =-=-=-   Aumento salarial   =-=-=-\nDigite a ID do funcionário: ");
            double id = double.Parse(Console.ReadLine());

            foreach(Funcionario func in funcionarios) {
                if (func.Id == id) {
                    Console.Write("Digite a porcentagem de aumento: ");
                    int porcento = int.Parse(Console.ReadLine());

                    func.aumentoSalarial(porcento);
                }
                else {
                    Console.WriteLine("\nEsta Id não existe");
                }


            }

            foreach (Funcionario func in funcionarios) {
                Console.WriteLine(func.ToString());
            }




        }


    }
}
