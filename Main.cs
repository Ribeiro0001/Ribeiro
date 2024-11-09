using System;

class desafio11
{


    static void Main(){

        // 1L = 3m
        // 18L = 54m = 80,00$
 
        Console.WriteLine("Digite o tamanho da area a ser pintada (m2): ");
        double area = Convert.ToDouble(Console.ReadLine());

        double latas = Math.Ceiling(area / 54);
        double price = latas * 80.00;

        Console.WriteLine("Vai ser necessario " + latas + " latas.");
        Console.WriteLine("Você ira pagar R$ " + price);


    }
}