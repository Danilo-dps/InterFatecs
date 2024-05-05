Console.WriteLine("Informe um número entre 0 e 10");


while (true) {
    int num = int.Parse(Console.ReadLine());
    if (num < 0 || num > 10) {
        Console.WriteLine("Informe um número válido!");
    }
    else {
        Console.WriteLine("Valor válido!");
    }
}
