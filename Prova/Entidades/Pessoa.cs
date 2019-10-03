using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }
        public string DataNascimento { get; set; }
        public float AntigoSalario { get; set; }
        public override string ToString()
        {
            return $"Nome:{Nome}, Idade: {Idade}, Salario: {Salario}, DataNascimento:{DataNascimento}, Antigo salario:{AntigoSalario}";
        }
    }
}
