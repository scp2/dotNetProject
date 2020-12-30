// using System;

// class Desafio
// {
//   public static void Main(string[] args)
//   {
//     string[] line = Console.ReadLine().Split(" ");
//     int NumeroPessoas = int.Parse(line[0]);
//     int NumeroDatas = int.Parse(line[1]);
//     bool existeData = false;

//     for(int j = 0; j < NumeroDatas; j++)
//     {
//       string[] lineDatas = Console.ReadLine().Split(" ");
//       string dataDisponivel = lineDatas[0];
//       int PessoasConfirmadas = 0;
//       for(int i = 1; i <= NumeroPessoas; i++)
//       {
//         if(lineDatas[i] == "1")
//         {
//           PessoasConfirmadas+=1;
//         }
//       }
//       if(PessoasConfirmadas == NumeroPessoas)
//       {
//         existeData = true;
//         System.Console.WriteLine(dataDisponivel);
//       }
//     }
  
//   if (!existeData)
//   {
//     System.Console.WriteLine("Pizza antes de FdA");
//   }
//   }
// }
using System;

// class Desafio
// {
//   public static void Main(string[] args)
//   {
//     int Tempo, Horas, Minutos, Segundos;
//     Tempo = int.Parse(Console.ReadLine());

//     Horas = Tempo / 3600;

//     Minutos = Tempo % 3600 / 60;

//     Segundos = Tempo % 60;

//     Console.WriteLine(Horas + ":" + Minutos + ":" + Segundos);
//   }
// // }
// class MinhaClasse {
//   public static void Main (string[] args) {
//     int idadeEmDias = int.Parse(Console.ReadLine());
//     int anos = idadeEmDias / 365; // Implemente aqui o calculo dos anos
//     int meses = idadeEmDias % 365 / 30; // Implemente aqui o calculo dos meses 
//     int dias =  (idadeEmDias % 365) % 30; // Implemente aqui o calculo dos dias

//     Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
//   }
// }

// class Desafio
// {
//   public static void Main(string[] args)
//   {
    // int minutosParaLargar = int.Parse(Console.ReadLine());
    // string[] line = Console.ReadLine().Split(" ");
    // int A = int.Parse(line[0]);
    // int B = int.Parse(line[1]);

    // if((A + B) > minutosParaLargar)
    // {
    //   System.Console.WriteLine("Deixa para amanha!");
    // }
    // else
    // {
    //   System.Console.WriteLine("Farei hoje!");
    // }
class Desafio
{
  public static void Main(string[] args)
  {
    char[] letras = {
      'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
      'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
    };

    char[] numeros = {
      '1','2', '3','4','5','6','7','8','9','0'
    };

    int numeroTestes = int.Parse(Console.ReadLine());
    string[] PlacasParaTest = new string[numeroTestes];

    for(int i = 0; i < numeroTestes; i++)
    {
      PlacasParaTest[i] = Console.ReadLine();
    }
    foreach(string placa in PlacasParaTest)
    {
      string[] dadosPlaca = placa.Split('-');
      if(dadosPlaca.Length < 2)
      {
        System.Console.WriteLine("FALHA");
        continue;
      }
      if((dadosPlaca[0].Length != 3) | (dadosPlaca[1].Length != 4))
      {
        System.Console.WriteLine("FALHA");
        continue;
      }
      bool IsValid = false;
      int CountValid = 0;
      foreach(char letra in dadosPlaca[0])
      {
        foreach(char letraValida in letras)
        {
          if(letraValida == letra)
          {
            CountValid += 1;
          }
        }
      }
      foreach(char numero in dadosPlaca[1])
      {
        foreach(char numeroValido in numeros)
        {
          if(numeroValido == numero)
          {
            CountValid += 1;
          }
        }
      }
      if(CountValid == 7){IsValid = true;}
      if(IsValid)
      {
        if((dadosPlaca[1][3] == '1') | (dadosPlaca[1][3] == '2'))
        {
          System.Console.WriteLine("SEGUNDA");
        }
        if((dadosPlaca[1][3] == '3') | (dadosPlaca[1][3] == '4'))
        {
          System.Console.WriteLine("TERCA");
        }
        if((dadosPlaca[1][3] == '5') | (dadosPlaca[1][3] == '6'))
        {
          System.Console.WriteLine("QUARTA");
        }
        if((dadosPlaca[1][3] == '7') | (dadosPlaca[1][3] == '8'))
        {
          System.Console.WriteLine("QUINTA");
        }
        if((dadosPlaca[1][3] == '9') | (dadosPlaca[1][3] == '0'))
        {
          System.Console.WriteLine("SEXTA");
        }
      }
      else
      {
        System.Console.WriteLine("FALHA");
      }
    }
  }
}