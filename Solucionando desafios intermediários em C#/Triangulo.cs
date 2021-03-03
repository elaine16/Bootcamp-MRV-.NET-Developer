/*
Triângulo

Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:

Perimetro = XX.X

Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem

Area = XX.X

Entrada
A entrada contém três valores reais.

Saída
O resultado deve ser apresentado com uma casa decimal.

 
Exemplo de Entrada	Exemplo de Saída
6.0 4.0 2.0             Area = 10.0

6.0 4.0 2.1          Perimetro = 12.1


*/

using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if(( a<(b+c)) && ( c<(a+b)) && ( b<(a+c)) ){
                Console.WriteLine("Perimetro = {0:0.0}",  a+b+c ); 
            }
            else{
                Console.WriteLine("Area = {0:0.0}", ((a + b) * c) / 2 ); 
            }

    }

}
