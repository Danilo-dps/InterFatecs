
Console.WriteLine("Entre com os números populacional.");
double popA = double.Parse(Console.ReadLine());
double popB = double.Parse(Console.ReadLine());
Console.WriteLine("Entre com a taxa de crescimento.");
double taxA = double.Parse(Console.ReadLine());
double taxB = double.Parse(Console.ReadLine());
int anos = 0;

if (popA > popB) {
    while (popA > popB) {
        popA += popA * taxA / 100;
        popB += popB * taxB / 100;
        anos++;
    }
    Console.WriteLine($"População A: {(int)popA}");
    Console.WriteLine($"População B: {(int)popB}");
    Console.WriteLine($"São necessários {anos} anos para B ultrapassar A");
}
else {
    while (popA < popB) {
        popA += popA * taxA / 100;
        popB += popB * taxB / 100;
        anos++;
    }
    Console.WriteLine($"População A: {(int)popA}");
    Console.WriteLine($"População B: {(int)popB}");
    Console.WriteLine($"São necessários {anos} anos para A ultrapassar B");
}
