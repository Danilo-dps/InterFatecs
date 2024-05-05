Console.Write("Digite as letra: ");

string[] alfabeto = Console.ReadLine().Split(' '); 

string[] tipos = new string[alfabeto.Length];

for (int i = 0; i < alfabeto.Length; i++) {
    tipos[i] = alfabeto[i];
}

foreach (string s in tipos) {
    if(s == "a" || s == "e" || s == "i" || s == "o" || s == "u") {
        Console.WriteLine($"{s} é vogal");
    }
    else {
        Console.WriteLine($"{s} é consoante");
    }
}