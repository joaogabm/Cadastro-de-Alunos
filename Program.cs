using System;
using System.Collections.Generic;

namespace CadastroDeAlunos
{
    public struct Aluno
    {
        public string nome;
        public int matricula;
        public int idade;
        public string email;
        public string telefone;
    }
    public class Program
    {
        public static List<Aluno> alunos = new List<Aluno>();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("              Cadastro de Alunos              ");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Consultar aluno");
                Console.WriteLine("3 - Listagem de alunos");
                Console.WriteLine("4 - Excluir aluno");
                Console.WriteLine("5 - Alterar cadastro");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1': Console.Clear(); CadastrarAluno(); break;
                    case '2': Console.Clear(); ConsultarAluno(); break;
                    case '3': Console.Clear(); ListagemDeAlunos(); break;
                    case '4': Console.Clear(); ExcluirAluno(); break;
                    case '5': Console.Clear(); AlterarCadastro(); break;
                    default: Console.Clear(); Console.WriteLine("Opção Inválida!"); break;
                }
                Console.WriteLine("Pressione <ENTER> para continuar");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        static void CadastrarAluno()
        {
            Aluno a = new Aluno();
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            a.matricula = int.Parse(Console.ReadLine());
            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());
            Console.Write("E-mail: ");
            a.email = Console.ReadLine();
            Console.Write("Telefone: ");
            a.telefone = Console.ReadLine();
            alunos.Add(a);
        }
        static void ConsultarAluno()
        {
            Console.Write("Digite um nome a ser consultado: ");
            string nome = Console.ReadLine();

            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].nome != null && alunos[i].nome.ToLower().Contains(nome.ToLower()))
                {
                    ListarAlunoIndice(i);
                }
            }
        }
        static void ExcluirAluno()
        {
            Console.Write("Digite um nome a ser consultado: ");
            string nome = Console.ReadLine();

            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].nome != null && alunos[i].nome.ToLower().Contains(nome.ToLower()))
                {
                    Console.WriteLine($"Índice: {i}");
                    ListarAlunoIndice(i);
                }
            }
            Console.Write("Digite o índice o elemento a ser excluído:");
            alunos.RemoveAt(int.Parse(Console.ReadLine()));
        }

        static void ListagemDeAlunos()
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                ListarAlunoIndice(i);
            }
        }
        static void ListarAlunoIndice(int i)
        {
            Console.WriteLine($"Nome: {alunos[i].nome}");
            Console.WriteLine($"Matrícula: {alunos[i].matricula}");
            Console.WriteLine($"Idade: {alunos[i].idade}");
            Console.WriteLine($"E-mail: {alunos[i].email}");
            Console.WriteLine($"Telefone: {alunos[i].telefone}");
            Console.WriteLine("----------------------------------");
        }
        static void AlterarCadastro()
        {

            Console.Write("Digite o nome do aluno a ser consultado: ");
            string nome = Console.ReadLine();

            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].nome != null && alunos[i].nome.ToLower().Contains(nome.ToLower()))
                {
                    Console.WriteLine($"Índice: {i}");
                    ListarAlunoIndice(i);
                }
            }

            Console.Write("Digite no índice o aluno a ser alterado: ");
            int indice = int.Parse(Console.ReadLine());

            Aluno alunoAlterar = alunos[indice];

            Console.Clear();
            Console.WriteLine("Qual informação você deseja alterar?");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Matrícula");
            Console.WriteLine("3 - Idade");
            Console.WriteLine("4 - E-mail");
            Console.WriteLine("5 - Telefone");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.Write("Novo nome: ");
                    alunoAlterar.nome = Console.ReadLine();
                    break;
                case '2':
                    Console.Clear();
                    Console.Write("Nova matrícula: ");
                    alunoAlterar.matricula = int.Parse(Console.ReadLine());
                    break;
                case '3':
                    Console.Clear();
                    Console.Write("Nova idade: ");
                    alunoAlterar.idade = int.Parse(Console.ReadLine());
                    break;
                case '4':
                    Console.Clear();
                    Console.Write("Novo e-mail: ");
                    alunoAlterar.email = Console.ReadLine();
                    break;
                case '5':
                    Console.Clear();
                    Console.Write("Novo telefone: ");
                    alunoAlterar.telefone = Console.ReadLine();
                    break;
            }

            alunos[indice] = alunoAlterar;

        }
    }
}