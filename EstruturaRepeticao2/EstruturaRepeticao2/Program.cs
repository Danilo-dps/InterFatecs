
internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Informe o nome e senha");

        while (true) {
            string nome = Console.ReadLine();
            string senha = Console.ReadLine();

            if (nome == senha) {
                Console.WriteLine("A senha não pode ser o seu nome!");
                Console.WriteLine("Informe nome e senha válidos!");
            } 
            else {
                Console.WriteLine("Login efetuado!");
                break;
            }
        }
    }
}