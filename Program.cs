using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] line1 = Console.ReadLine().Split(" ");
            string[] line2 = Console.ReadLine().Split(" ");
            
            int finalExpediente = int.Parse(line1[0]);
            
            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);
            
            //continue a solucao
            int totalNecessario =  presente1 + presente2;
            
            if ( finalExpediente < totalNecessario )
            {
            Console.WriteLine("Deixa para amanha!");
            }
            else
            {
            Console.WriteLine("Farei hoje!");
            }





            /*
            var timeInSeconds = int.Parse(Console.ReadLine());

            //continue a solucao
            var hours = timeInSeconds/3600;
            timeInSeconds =  timeInSeconds%3600;
            var minutes =  timeInSeconds/60;
            var seconds =  timeInSeconds%60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");

            */

            /*
            int n;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            for (int x = 0; x <= n; x++) //complete seu codigo
            {
                if(x%2!=0){
                    Console.WriteLine( x.ToString());
                }
            }
            
            Console.ReadLine();
            */


            /*
            //continue a solucao com a insercao da variavel corretamente

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B  == 0 || B % A == 0 ) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
            */

        }
    }
}
