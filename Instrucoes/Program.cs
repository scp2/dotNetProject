using System;

namespace Instrucoes
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Declaracoes()
            {
                int a;
                int b = 2, c =3;
                const int d = 4;
                a = 1;
                Console.WriteLine(a + b + c + d);
            }
            
            static void InstrucoesIf(string[] args)
            {
                if(args.Length == 0)
                {
                    System.Console.WriteLine("Nenhum argumento");
                }
                else if(args.Length == 1)
                {
                    System.Console.WriteLine("Um argumento");
                }
                else
                {
                    System.Console.WriteLine($"{args.Length} argumentos");
                }
            }        

            static void InstrSwitch(string[] args)
            {
                int numeroDeArgumentos = args.Length;
                switch(numeroDeArgumentos)
                {
                    case 0:
                        System.Console.WriteLine("Nenhum argumento");
                        break;
                    case 1:
                        System.Console.WriteLine("Um argumento");
                        break;
                    case 2:
                        System.Console.WriteLine("DOis agumentos");
                        break;
                    default:
                        System.Console.WriteLine($"{numeroDeArgumentos}");
                        break;
                }
            }

            static void InstrWhile(string[] args)
            {
                int i = 0;
                while(i < args.Length)
                {
                    System.Console.WriteLine(args[i]);
                    i++;
                }
            }
        
            static void InstrForEach(string[] args)
            {
                foreach(string s in args)
                {
                    System.Console.WriteLine(s);
                }
            }
        
            static void TryCatchFinallyThrow(string[] args)
            {
                double Dividir(double x, double y)
                {
                    if(y == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return x / y;
                }

                try
                {
                    if(args.Length != 2)
                    {
                        throw new InvalidCastException("Informe 2 números");
                    }

                    double x = double.Parse(args[0]);
                    double y = double.Parse(args[1]);
                    System.Console.WriteLine(Dividir(x, y));
                }
                catch (InvalidOperationException e)
                {
                    System.Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine($"Erro genérico {e.Message}");
                }
                finally
                {
                    System.Console.WriteLine("Até breve");
                }
            }
        
            static void InstrUsing(string[] args)
            {
                using(System.IO.TextWriter w = System.IO.File.CreateText("test.txt"))
                {
                    w.WriteLine("LIne 1");
                    w.WriteLine("LIne 2");
                    w.WriteLine("LIne 3");
                }
                //O using é semelhante ao with do python, gerencia o objeto após a execução
            }
        }
    }
}
