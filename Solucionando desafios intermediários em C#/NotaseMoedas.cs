/*
 Notas e Moedas

Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.

 
Exemplo de Entrada:
576.73


Exemplo de Saída:
NOTAS:
5 nota(s) de R$ 100.00
1 nota(s) de R$ 50.00
1 nota(s) de R$ 20.00
0 nota(s) de R$ 10.00
1 nota(s) de R$ 5.00
0 nota(s) de R$ 2.00
MOEDAS:
1 moeda(s) de R$ 1.00
1 moeda(s) de R$ 0.50
0 moeda(s) de R$ 0.25
2 moeda(s) de R$ 0.10
0 moeda(s) de R$ 0.05
3 moeda(s) de R$ 0.01
*/
using System; 

class minhaClasse {
  static void Main(string[] args) { 
      double valor;
      int inteiro, auxNotas, auxMoedas;

      valor = double.Parse(Console.ReadLine().ToString());
      inteiro = (int)valor;

      valor *= 100;
      auxMoedas = (int)valor;


      Console.WriteLine("NOTAS:");
      Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro/100);

      auxNotas = (inteiro % 100);

      Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas/50);

      auxNotas = (auxNotas % 50);

      Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas/20);

      auxNotas = (auxNotas % 20);

      Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas/10);

      auxNotas = (auxNotas % 10); 

      Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas/5);

      auxNotas = (auxNotas % 5); 

      Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas/2);

      auxNotas = (auxNotas % 2); 




      Console.WriteLine("MOEDAS:");

      Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);

      auxMoedas %= 100;

      //complete o codigo

      Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 50);

      auxMoedas %= 50;

      Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas / 25);

      auxMoedas %= 25;

      Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);

      auxMoedas %= 10;

      Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 5);

      auxMoedas %= 5;

      Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas );
  }
}


