using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            //Atividade 1
            int numero;
            Console.Write("\n DIGITE UM NUMERO MEU BOM: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("seu numero sucessor e: " + (numero + 1));
            Console.Write("\n seu numero antecessor e: " + (numero - 1));
            Console.ReadLine();

            //Atividade 2
            string nome, endereco;
            int cep;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Endereço: ");
            endereco = Console.ReadLine();
            Console.Write("CEP: ");
            cep = int.Parse(Console.ReadLine());


            Console.WriteLine("\n Seu Nome e: {0} \n Seu Endereço e: {1} \n Seu CEP e: {2}", nome, endereco, cep);
            Console.ReadLine();

            //Atividade 3
            
            double d_nro1 = 0; double d_nro2 = 0;

            Console.Write("\n Digite o 1º numero: ");
            d_nro1 = double.Parse(Console.ReadLine());
            Console.Write("\n Digite o 2º numero: ");
            d_nro2 = double.Parse(Console.ReadLine());

            Console.Write("sua soma é: " + (d_nro1 + d_nro2));
            Console.Write("\n sua subtração e: " + (d_nro1 - d_nro2));
            Console.Write("\n sua multiplicação e: " + (d_nro1 * d_nro2));
            Console.Write("\n sua divisão e: " + (d_nro1 / d_nro2));
            Console.ReadLine();

            //Atividade 4
            double d_peso = 89, d_alt1 = 1.68, d_alt2 = 1.68;

            Console.Write("Digite a seu peso: ");
            d_peso = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura");
            d_alt1 = double.Parse(Console.ReadLine());
            Console.Write("\n seu peso é: " + d_peso);
            Console.Write("sua altura é: " + d_alt1);
            Console.Write("seu imc é: " + (d_peso / d_alt1 * d_alt2));
            Console.ReadLine();

            












        }
    }
}
