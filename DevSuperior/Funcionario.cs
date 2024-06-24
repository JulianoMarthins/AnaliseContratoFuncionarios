using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace DevSuperior {
    internal class Funcionario {

        public int Id { get; private set; }
        public string Nome{ get; set; }
        public double Salario{ get; private set; }


        public Funcionario(int id, string nome, double salario) {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void aumentoSalarial(double porcento) {
            Salario += (Salario * porcento) / 100;
        }
                
        public override string ToString() {
            string valorFormatado = string.Format(CultureInfo.GetCultureInfo("bt-BR"), "{0:C}", Salario);
            return $"\nLista de funcionários atualizada\n\nID: {Id}\nNome: {Nome}\nSalario: {Salario}";
        }

    }
}
