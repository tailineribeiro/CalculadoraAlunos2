using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CalculadoraBoletim
{
    public class Boletim
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Escola { get; set; }

        public double Media { get; set; }

        public Boletim()
        {
        }

        public Boletim(string nome, int idade, string escola)
        {
            Nome = nome;
            Idade = idade;
            Escola = escola;
        }

        public double Medias(double media)//armazena a media de cada laço for repassado, para cada bimestre.
        {
            Media += media; // Media(propriedade da classe), recebe media(variável criada nesse método) + Media(propriedade da classe)
            return Media;//E retorna esse valor para Média(propriedade da classe).

        }


        public double NotaFinal()//Faz a media final do ano letivo.
        {
            return Media / 4.0;

        }

    }

    internal class Cadastramento
    {

        public static void MediaAnoLetivo()
        {

            Console.WriteLine("Informe o nome do aluno: ");
            string nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Informe a idade do aluno: ");
            int.TryParse(Console.ReadLine(), out int idade);

            Console.WriteLine("Informe a escola: ");
            string escola = Console.ReadLine() ?? string.Empty;

            var alunoFinal = new Boletim(nome, idade, escola);
           

            double media = 0.0;//Criado uma variavel do tipo double media, que vai receber o valor 0, criada fora do for, para ser usada fora do escopo de for,caso precise. 

            for (int i = 1; i <= 4; i++)//Aqui está dizendo para repetir 4 vezes. 
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Informe as notas do {i}º Bimestre:  ");
                Console.WriteLine("---------------------------------------------");
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

                media = ((notaMat + notaPort + notaCiencias + notaGeo + notaHist + notaEdFisica + notaEnsReligioso + notaIngles + notaArtes) / 9.0) / 10.0;
               
                alunoFinal.Medias(media);//Enviado o valor de media para o método poder somar e guardar na propriedade da classe.
               
            }


            Console.WriteLine($"Aluno (a) {alunoFinal.Nome}, {alunoFinal.Idade} anos, da escola {alunoFinal.Escola}.");//Mostra os dados


            if (media >= 7.0)
            {
                Console.WriteLine($"Status: APROVADO com média de {media.ToString("F1")}!");
            }

            else if (media > 2.0)
            {
                Console.WriteLine($"Status: em RECUPERAÇÃO, com média de {media.ToString("F1")}!");
            }

            else
            {
                Console.WriteLine($"Status: REPROVADO, com média de {media.ToString("F1")}!");
            }
                

        }

    }
}