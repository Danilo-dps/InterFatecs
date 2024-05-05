
double popA = 80000;
double popB = 200000;
double taxA = 0.03;
double taxB = 0.015;
int anos = 0;

while (popA < popB) {
    popA += popA * taxA;
    popB += popB * taxB;
    anos++;
}

Console.WriteLine($"População A: {(int)popA}");
Console.WriteLine($"População B: {(int)popB}");

Console.WriteLine($"São necessários {anos} anos para A ultrapassar B");

