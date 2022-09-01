using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CalculadoraAlunos
{

    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Escola { get; set; }
        public double Media { get; set; }

        public Aluno() { }

        public Aluno(string nome, int idade, string escola)
        {
            Nome = nome;
            Idade = idade;
            Escola = escola;
        }

        public double CadastroAlunos()
        {


            Console.WriteLine("Informe o nome do aluno ");
            string nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Informe a idade do aluno ");
            int.TryParse(Console.ReadLine(), out int idade);

            Console.WriteLine("Informe o nome da escola ");
            string escola = Console.ReadLine() ?? string.Empty;

            Nome = nome;
            Idade = idade;
            Escola = escola;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Agora informe as notas do aluno:");
            Console.WriteLine("");

            Console.WriteLine("Informe a nota do aluno em Matemática: ");
            double.TryParse(Console.ReadLine(), out double notaMat);

            Console.WriteLine("Informe a nota do aluno em Português: ");
            double.TryParse(Console.ReadLine(), out double notaPort);

            Console.WriteLine("Informe a nota do aluno em Ciências: ");
            double.TryParse(Console.ReadLine(), out double notaCiencias);

            Console.WriteLine("Informe a nota do aluno em Geografia: ");
            double.TryParse(Console.ReadLine(), out double notaGeo);

            Console.WriteLine("Informe a nota do aluno em História: ");
            double.TryParse(Console.ReadLine(), out double notaHist);

            Console.WriteLine("Informe a nota do aluno em Educação Física: ");
            double.TryParse(Console.ReadLine(), out double notaEdFisica);

            Console.WriteLine("Informe a nota do aluno em Ensino Religioso: ");
            double.TryParse(Console.ReadLine(), out double notaEnsReligioso);

            Console.WriteLine("Informe a nota do aluno em Inglês: ");
            double.TryParse(Console.ReadLine(), out double notaIngles);

            Console.WriteLine("Informe a nota do aluno em Artes: ");
            double.TryParse(Console.ReadLine(), out double notaArtes);

            Media = ((notaMat + notaPort + notaCiencias + notaGeo + notaHist + notaEdFisica + notaEnsReligioso + notaIngles + notaArtes) / 9.0) / 10.0;

            return Media;

            Console.WriteLine("---------------------------------------------");

        }
    }

    internal class Parametros
    {
        public static List<Aluno> alunosCadastrados = new List<Aluno>();
        public static void MenuInicial()
        {

            Console.WriteLine("----------------Menu Inicial-----------------");

            int opcao2 = 1;

            while (opcao2 == 1 || opcao2 == 2)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Selecione (1) para cadastrar aluno ");
                Console.WriteLine("Selecione (2) para listar alunos cadastrados ");
                Console.WriteLine("Selecione (3) para Sair");
                Console.WriteLine("---------------------------------------------");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        var aluno = new Aluno();
                        aluno.CadastroAlunos();
                        alunosCadastrados.Add(aluno);
                        break;

                    case "2":
                        ListagemAlunos();
                        break;

                    default:
                        Console.WriteLine("Tecle Enter para sair: ");
                        int.TryParse(Console.ReadLine(), out opcao2);
                        break;
                }
            }

        }

        public static void ListagemAlunos()
        {

            foreach (Aluno aluno in alunosCadastrados)
            {
                bool notaValida = aluno.Media <= 10 && aluno.Media >= 0;
                if (!notaValida)
                {
                    Console.WriteLine("Essa nota é inválida!");
                    continue;
                }
                else if (aluno.Media >= 7.0)
                {
                    Console.WriteLine($"Aluno(a) {aluno.Nome}, {aluno.Idade} anos, da escola {aluno.Escola}, foi APROVADO com média geral de {aluno.Media.ToString("F1")}.");
                }

                else if (aluno.Media > 2.0)
                {
                    Console.WriteLine($"Aluno (a) {aluno.Nome}, {aluno.Idade} anos, da escola {aluno.Escola}, esta em RECUPERAÇÃO com média geral de {aluno.Media.ToString("F1")}.");
                }

                else
                {
                    Console.WriteLine($"Aluno (a) {aluno.Nome}, {aluno.Idade} anos, da escola {aluno.Escola}, foi REPROVADO com média geral de {aluno.Media.ToString("F1")}.");
                }


            }

        }

    }
}



