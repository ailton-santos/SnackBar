using System;

class Program
{
    static void Main()
    {
        // Declaração dos lanches e seus respectivos valores
        string[] lanche = { "Hot Dog", "Misto Quente", "X-Burger", "X-Calabresa", "X-Egg" };
        double[] valor = { 7.99, 5.10, 12.99, 13.89, 11.20 };

        Console.WriteLine("BigTech Lanches");
        Console.WriteLine("Cardápio:");

        // Exibe o cardápio com os lanches e valores correspondentes
        for (int i = 0; i < lanche.Length; i++)
        {
            Console.WriteLine($"[{i}] {lanche[i]} - {valor[i].ToString("c")}");
        }

        int escolha;
        while (true)
        {
            // Solicita ao usuário que escolha um número correspondente ao lanche desejado
            Console.Write("Por favor, insira o número do lanche desejado: ");
            if (int.TryParse(Console.ReadLine(), out escolha) && escolha >= 0 && escolha < lanche.Length)
            {
                break;
            }
            Console.WriteLine("Opção inválida. Tente novamente.");
        }

        double total = valor[escolha];
        Console.WriteLine($"Você escolheu {lanche[escolha]} que custa {valor[escolha].ToString("c")}.");

        // Pergunta ao usuário se deseja adicionar uma bebida ao pedido

        Console.Write("Gostaria de adicionar uma bebida por mais R$10,00? (S/N): ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "s")
        {
            total += 10;
            Console.WriteLine($"Você escolheu adicionar uma bebida. O total agora é {total.ToString("c")}.");
        }
        else if (resposta != "n")
        {
            Console.WriteLine("Opção inválida. Não será adicionada uma bebida.");
        }

        // Finaliza o pedido e exibe o total a ser pago

        Console.WriteLine("Obrigado pela compra! \nA BigTech agradece pela preferência.");
        Console.WriteLine($"Total a pagar: {total.ToString("c")}.");

        Console.ReadKey();
    }
}
