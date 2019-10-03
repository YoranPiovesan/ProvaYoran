using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.View
{
    class ViewPessoa
    {
        public string meunuPessoa(int QuantidadePessoas)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Cadastro - Pessoa" + Environment.NewLine);
            Console.WriteLine($"Menu: Possui {QuantidadePessoas} Pessoas cadastradas");
            Console.WriteLine("01 - Incluir");
            Console.WriteLine("02 - Alterar");
            Console.WriteLine("03 - Excluir");
            Console.WriteLine("04 - Listar");
            Console.WriteLine("05 - Pesquisar");
            Console.WriteLine("06 - Salvar");
            Console.WriteLine("09 - Sair");
            Console.WriteLine("Digite a opção desejada");
            return Console.ReadLine();
        }
        public Pessoa inserirPessoa()
        {
            Console.WriteLine("Cadastrar");
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Nome = ler("Nome:");
            novaPessoa.Idade = int.Parse(ler("Idade:"));
            novaPessoa.Salario = double.Parse(ler("Nome:"));
            novaPessoa.DataNascimento = ler("Data de nascimentos:");
            novaPessoa.AntigoSalario = float.Parse(ler("Antigo Salario:"));
            return novaPessoa;

        }
        private string ler(string mensagem)
        {
            Console.WriteLine($"{mensagem}");
            return Console.ReadLine();
        }
        public string lerNome(string nome)
        {
            Console.WriteLine(nome);
            return ler("Indique o nome da pessoa:");
        }
        public Pessoa alterarPessoa(Pessoa pessoa)
        {
            pessoa.Nome = leAlteracao("Insira o nome", pessoa.Nome);
            pessoa.Salario = double.Parse(leAlteracao("Salario: ", pessoa.Salario.ToString()));
            pessoa.Idade = int.Parse(leAlteracao("Insira o nome", pessoa.Idade.ToString()));
            pessoa.DataNascimento = leAlteracao("Insira o nome", pessoa.DataNascimento);
            pessoa.AntigoSalario = float.Parse(leAlteracao("Insira o nome", pessoa.AntigoSalario.ToString()));
            return pessoa;
        }
        internal void listaPessoas(List<Pessoa>listaPessoas)
        {
            Console.WriteLine("Lista de pessoas");
            listaPessoas.ForEach(pessoa => Console.WriteLine(pessoa));
        }
        public string confirmaExclusão(Pessoa pessoa)
        {
            Console.WriteLine($"Excluir:");
            return ler("Deseja excluir?(S/N)");
        }
        private string leAlteracao(string mensagem, string valor)
        {
            Console.Write($"{mensagem}({valor}):");
            string vlr = Console.ReadLine();
            return !vlr.Equals("") ? vlr : valor;
        }
        public void mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
        public void mostrarPessoa(Pessoa pessoa)
        {
            Console.WriteLine($"{pessoa}");
        }
        
    }

}
