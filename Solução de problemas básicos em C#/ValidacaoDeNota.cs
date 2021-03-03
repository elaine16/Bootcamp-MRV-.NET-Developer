/*
Validação de Nota

Desafio
Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.

 
Exemplo de Entrada	
-3.5
3.5
11.0
10.0

Exemplo de Saída
nota invalida
nota invalida
media = 6.75
*/

using System; 

class Desafio {

    static void Main(string[] args) { 
       double nota, resultado = 0;
       int i = 0, cont = 0;

       while (cont != 2){
        nota = double.Parse(Console.ReadLine());

        if (nota < 0 || nota > 10){
        Console.WriteLine("nota invalida");
        }
        else{
            resultado += nota;
            cont++;
        }
      }
        Console.WriteLine("media = {0:F2}", resultado/2);
    }

}
