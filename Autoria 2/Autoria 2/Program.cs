// See https://aka.ms/new-console-template for more information

Random gerador = new Random();
int numeroSecreto = gerador.Next(1, 101);

int palpite = 0;
int tentativas = 0;

Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

// Enquanto o palpite estiver errado, continua o jogo
while (palpite != numeroSecreto)
{
    Console.Write("Digite seu palpite: ");
    palpite = int.Parse(Console.ReadLine());
    tentativas++;

    // Verifica se o palpite está correto
    if (palpite == numeroSecreto)
    {
        Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
    }
    else if (palpite < numeroSecreto)
    {
        Console.WriteLine("O número é maior. Tente novamente.");
    }
    else
    {
        Console.WriteLine("O número é menor. Tente novamente.");
    }
}