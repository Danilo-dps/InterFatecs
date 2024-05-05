

Console.Write("Digite as notas: ");

string[] notas = Console.ReadLine().Split(' ');

long[] longs = new long[notas.Length];
long count = 0;

for (int i = 0; i < notas.Length; i++) {
    longs[i] = long.Parse(notas[i]);
    count += longs[i];
}

long avg = count / longs.Length;

Console.WriteLine($"A média das notas são {avg}");