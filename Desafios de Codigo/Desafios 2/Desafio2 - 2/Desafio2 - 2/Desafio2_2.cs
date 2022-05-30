////Abaixo segue um exemplo de código que você pode ou não utilizar
//using System;

//namespace Start
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a, b, c, d, avg;
//            string[] values = Console.ReadLine().Split(' ');
//            //TODO: Complete os espaços em branco com uma possível solução para o desafio
//            a = double.Parse(values[0]) * 2;
//            b = double.Parse(values[1]) * 3;
//            c = double.Parse(values[2]) * 4;
//            d = double.Parse(values[3]) * 1;

//            avg = ((a + b + c + d) / 10);
//            Console.WriteLine("Media: " + avg.ToString("0.0"));
//            if (avg >= 7)
//            {
//                Console.WriteLine("Aluno aprovado.");
//            }
//            if (avg < 5)
//            {
//                Console.WriteLine("Aluno reprovado.");
//            }
//            if (6.9 >= avg >= 5)
//            {
//                Console.WriteLine("Aluno em exame.");
//                Console.Write("Nota do exame: ");
//                double e = double.Parse(Console.ReadLine());
//                avg = (e + avg) / 2;
//                if (                    )
//                {
//                    Console.WriteLine("Aluno aprovado.");
//                }
//                if (                  )
//                {
//                    Console.WriteLine("Aluno reprovado.");
//                }
//                Console.WriteLine("Media final: " + avg.ToString("0.0"));
//            }

//            Console.ReadKey();
//        }
//    }
//}