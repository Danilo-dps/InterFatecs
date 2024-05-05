
while (true) {
    string nome;
    int idade;
    double salario;
    char sexo;
    char EstadoCivil;
    while (true) {
        Console.WriteLine("Nome: maior que 3 caracteres");
        nome = Console.ReadLine();
        if (nome.Length > 3) {
            break;
        }
    }
    while (true) {
        Console.WriteLine("Idade: entre 0 e 150");
        idade = int.Parse(Console.ReadLine());
        if (idade > 0 && idade < 150) {
            break;
        }
    }
    while(true) {
        Console.WriteLine("Salário: maior que zero");
        salario = double.Parse(Console.ReadLine());
        if(salario > 0) {
            break;
        }
    }
    while (true) {
        Console.WriteLine("Sexo: 'f' ou 'm'");
        sexo = Console.ReadLine()[0];
        if (sexo == 'f' || sexo == 'm') {
            break ;
        }
    }
    while (true) {
        Console.WriteLine("Estado Civil: 's', 'c', 'v', 'd'");
        EstadoCivil = Console.ReadLine()[0];
        if(EstadoCivil == 's' ||  EstadoCivil == 'c' ||  EstadoCivil == 'v' ||  EstadoCivil == 'd') {
            break ;
        }
    }

    Console.WriteLine();
    Console.WriteLine("Dados cadastrados");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine($"Salário: {salario}");
    Console.WriteLine($"Sexo: {sexo}");
    Console.WriteLine($"Estado civil: {EstadoCivil}");
    break;
}



