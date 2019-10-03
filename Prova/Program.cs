using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();
            int continuar = 1;
            int escolha = 0;
            for (int i = 0; i < continuar; i++)
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1 - Incluir Pessoa");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir Pessoa");
                Console.WriteLine("4 - Visualizar");
                Console.WriteLine("5 - Pesquisar");
                Console.WriteLine("6 - Sair");
                Console.WriteLine("----------------");
                Console.WriteLine("Digite o número da opção desejada:");
                Console.WriteLine("Pessoas registradas: " + listaPessoa.Count);
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    int seguir = 1;
                    do
                    {
                        Console.WriteLine("Cadastrar");
                        Pessoa novaPessoa = new Pessoa();
                        Console.WriteLine("Nome:");
                        novaPessoa.Nome = ler("Insira o nome");
                        Console.WriteLine("Idade:");
                        novaPessoa.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Salario:");
                        novaPessoa.Salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Data de Nascimento: ");
                        novaPessoa.DataNascimento = Console.ReadLine();
                        Console.WriteLine("Antigo Salario: ");
                        novaPessoa.AntigoSalario = float.Parse(Console.ReadLine());
                        listaPessoa.Add(novaPessoa);
                        Console.WriteLine("Se deseja continuar cadastrando digite 1, para sair digite 2");
                        seguir = int.Parse(Console.ReadLine());
                    } while (seguir == 1);


                }
                continuar++;//aumenta a condição do for i 
                if (escolha == 2)
                {
                    Console.WriteLine("Alterar");
                    string nome;
                    int seguir = 0;
                    Console.WriteLine("Digite o nome da pessoa que deseja alterar");
                    nome = Console.ReadLine();
                    Pessoa mudar = listaPessoa.Find(x => x.Nome.Equals(nome));
                    Console.WriteLine("Nome atual: " + mudar.Nome);
                    Console.WriteLine("Idade atual: " + mudar.Idade);
                    Console.WriteLine("Salario atual: " + mudar.Salario);
                    Console.WriteLine("Data de nascimento atual: " + mudar.DataNascimento);
                    Console.WriteLine("Antigo salario registrado atualmente: " + mudar.AntigoSalario);
                    Console.WriteLine("Usuario" + mudar.Nome);
                    Console.WriteLine("1 - mudar nome");
                    Console.WriteLine("2 - mudar idade");
                    Console.WriteLine("3 - mudar salario");
                    Console.WriteLine("4 - Mudar Data de Nascimento");
                    Console.WriteLine("5 - Mudar o Salario antigo");
                    seguir = int.Parse(Console.ReadLine());
                    if (seguir == 1)
                    {
                        Console.WriteLine("nome: ");
                        mudar.Nome = Console.ReadLine();
                        Console.WriteLine("Nome alterado");
                    }
                    if (seguir == 2)
                    {
                        Console.WriteLine("Idade: ");
                        mudar.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Idade alterada");
                    }
                    if (seguir == 3)
                    {
                        Console.WriteLine("Salario: ");
                        mudar.Salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Salario alterado");
                    }
                    if (seguir == 4)
                    {
                        Console.WriteLine("Data de Nascimento: ");
                        mudar.DataNascimento = Console.ReadLine();
                        Console.WriteLine("Salario alterado");
                    }
                    if (seguir == 5)
                    {
                        Console.WriteLine("Salario antigo: ");
                        mudar.AntigoSalario = float.Parse(Console.ReadLine());
                        Console.WriteLine("Salario antigo alterado");
                    }
                }
                if (escolha == 3)
                {
                    Console.WriteLine("Remover");
                    string nome;
                    Console.WriteLine("Digite o nome da pessoa que deseja remover");
                    nome = Console.ReadLine();
                    Pessoa deletar = listaPessoa.Find(x => x.Nome.Equals(nome));//Tentei usar com o for, mas não encontrei uma forma de fazer isso através do c#
                    Console.WriteLine($"Deseja deletar o usuario {deletar.Nome}? Se sim, digite 1" );
                    int ler = 0;
                    ler = int.Parse(Console.ReadLine());
                    if (ler == 1)
                    {
                        listaPessoa.Remove(deletar);
                        Console.WriteLine("Usuario removido com sucesso!!");
                    }
                   
                }
                if (escolha == 4)
                {
                    foreach (Pessoa mostrar in listaPessoa)
                    {
                        Console.WriteLine($"----nome:{mostrar.Nome} " +
                            $"Idade:{mostrar.Idade} " +
                            $"Salario:{mostrar.Salario} " +
                            $"Data de Nascimento:{mostrar.DataNascimento} " +
                            $"Salario antigo:{mostrar.AntigoSalario}----");
                    }
                }
                if (escolha == 5)
                {
                    Console.WriteLine("Pesquisar");
                    string nome;//A "pesquisa" não ficou muita clara, então decidi puxar o usuario pelo id(nome).
                    Console.WriteLine("Digite o nome da pessoa que deseja pesquisar");
                    nome = Console.ReadLine();
                    Pessoa encontrar = listaPessoa.Find(x => x.Nome.Equals(nome));
                    Console.WriteLine(encontrar.Nome);
                    Console.WriteLine(encontrar.Idade);
                    Console.WriteLine(encontrar.Salario);
                    Console.WriteLine(encontrar.DataNascimento);
                    Console.WriteLine(encontrar.AntigoSalario);
                }
                continuar++;
                if (escolha == 6)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}

