Console.WriteLine("Qual periodo você estuda? ");
Console.WriteLine("m - manhã, t - tarde, n - noite");
Console.WriteLine("Para finalizar digite 0");

char escolha = Console.ReadLine()[0];
while (escolha != '0') {
    switch (escolha) {
        case 'm':
            Console.WriteLine("Manhã!");
            break;
        case 't':
            Console.WriteLine("Tarde!");
            break;
        case 'n':
            Console.WriteLine("Noite!");
            break;
        default:
            Console.WriteLine("Escolha inválida!");
            break;
    }
    escolha = Console.ReadLine()[0];
}

Console.WriteLine("Programa finalizado.");

 


