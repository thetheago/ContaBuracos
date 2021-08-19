using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBuracos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contBuracos = 0;

            Console.WriteLine("Digite um texto:");
            string texto = Console.ReadLine();
            Console.WriteLine("");
            char[] textoArr = texto.ToCharArray(); //Aqui eu transformei a string digitada em um array de char
            String[] palavras = texto.Split(' ');//Aqui dei um split na frase para separar as palavras
            int totPalavras = palavras.Length;
            int textoLetras = texto.Replace(" ", string.Empty).Length;
            //texto.Replace para substituir os espaços por empty para não contar


            //Para cada char no array ele irá testar quantos buracos tem de acordo com a segunda função.
            foreach (char letra in textoArr)
            {

                contBuracos += TestarArray(letra);

            }

            if (contBuracos > 1 && totPalavras > 1) //Caso tenha mais de um buraco e mais de uma palavra
            {
                Console.WriteLine("Seu texto há " + textoLetras + " letras");
                Console.WriteLine("Seu texto há " + totPalavras + " palavras");
                Console.WriteLine("Nas letras do seu texto há : " + contBuracos + " buracos.");
            }
            else if (contBuracos > 1 && totPalavras == 1) //Caso tenha mais de um buraco mas apenas uma palavra
            {
                Console.WriteLine("Seu texto há " + textoLetras + " letras");
                Console.WriteLine("Seu texto há " + totPalavras + " palavra");
                Console.WriteLine("Nas letras do seu texto há : " + contBuracos + " buracos.");
            }
            else if (contBuracos == 1 && totPalavras > 1) //Caso tenha um baraco e mais de uma palavra
            {
                Console.WriteLine("Seu texto há " + textoLetras + " letras");
                Console.WriteLine("Seu texto há " + totPalavras + " palavras");
                Console.WriteLine("Nas letras do seu texto há : " + contBuracos + " buraco.");
            }
            else if (contBuracos == 1 && totPalavras == 1) //Caso tenha um buraco e uma palavra
            {
                Console.WriteLine("Seu texto há " + textoLetras + " letras");
                Console.WriteLine("Seu texto há " + totPalavras + " palavra");
                Console.WriteLine("Nas letras do seu texto há : " + contBuracos + " buraco.");
            }
            else if (textoLetras == 0) //Caso não digite nada
            {
                Console.WriteLine("Você não digitou nada!");
            }
            else if (contBuracos == 0 && totPalavras == 1) //Caso não tenha buracos e uma palavra
            {
                Console.WriteLine("Seu texto há " + textoLetras + " letras");
                Console.WriteLine("Seu texto há " + totPalavras + " palavra");
                Console.WriteLine("Nas letras do seu texto não há buracos.");
            }
            else if (contBuracos == 0 && totPalavras > 1) //Caso não tenha buracos e mais de uma palavra
            {
                Console.WriteLine("Seu texto há " + textoLetras + " letras");
                Console.WriteLine("Seu texto há " + totPalavras + " palavras");
                Console.WriteLine("Nas letras do seu texto não há buracos.");
            }
            else //Caso não tenha nenhum buraco
            {
                Console.WriteLine("Seu texto há " + textoLetras + " letras");
                Console.WriteLine("Seu texto há " + totPalavras + " palavras");
                Console.WriteLine("Nas letras do seu texto há : " + contBuracos + " buracos.");
            }


            Console.ReadKey();
        }

        static int TestarArray(char test) //Aqui é uma função para testar a char e retornar o número de buracos
        {
            int buracos = 0;

            if (test == 'a' || test == 'A')
            {
                buracos++;
            }
            if (test == 'b')
            {
                buracos++;
            }
            if (test == 'B')
            {
                buracos += 2;
            }
            if (test == 'd' || test == 'D')
            {
                buracos++;
            }
            if (test == 'e')
            {
                buracos++;
            }
            if (test == 'g') //Nesse aqui o g eu coloquei como 1 buraco porque to usando a fonte padrão (Arial) como referência
            {
                buracos++;
            }
            if (test == 'o' || test == 'O')
            {
                buracos++;
            }
            if (test == 'p' || test == 'P')
            {
                buracos++;
            }
            if (test == 'q' || test == 'Q')
            {
                buracos++;
            }
            if (test == 'R')
            {
                buracos++;
            }

            return buracos;
        }
    }
}
