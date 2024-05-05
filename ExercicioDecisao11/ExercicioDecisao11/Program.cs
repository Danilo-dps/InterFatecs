
Console.WriteLine("Informe seu salário: ");
double salario = double.Parse(Console.ReadLine());
double nSalario = 0;

    if (salario <= 280) {
        nSalario = salario * 1.2;
        Console.WriteLine($"Salário antigo R${salario.ToString("F2")}");
        Console.WriteLine($"Novo salário R${nSalario.ToString("F2")}");
        Console.WriteLine($"Valor do aumento R${(nSalario - salario).ToString("F2")}");
        Console.WriteLine("Percentual de aumento 20%");
    }
    else if (salario > 280 && salario <= 700) {
        nSalario = salario * 1.15;
        Console.WriteLine($"Salário antigo R${salario.ToString("F2")}");
        Console.WriteLine($"Novo salário R${nSalario.ToString("F2")}");
        Console.WriteLine($"Valor do aumento R${(nSalario - salario).ToString("F2")}");
        Console.WriteLine("Percentual de aumento 15%");
    }
    else if (salario > 700 && salario <= 1500) {
        nSalario = salario * 1.1;
        Console.WriteLine($"Salário antigo R${salario.ToString("F2")}");
        Console.WriteLine($"Novo salário R${nSalario.ToString("F2")}");
        Console.WriteLine($"Valor do aumento R${(nSalario - salario).ToString("F2")}");
        Console.WriteLine("Percentual de aumento 10%");
    }
    else {
        nSalario = salario * 1.05;
        Console.WriteLine($"Salário antigo R${salario.ToString("F2")}");
        Console.WriteLine($"Novo salário R${nSalario.ToString("F2")}");
        Console.WriteLine($"Valor do aumento R${(nSalario - salario).ToString("F2")}");
        Console.WriteLine("Percentual de aumento 5%");
    }
