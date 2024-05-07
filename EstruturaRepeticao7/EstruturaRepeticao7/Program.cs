
Console.WriteLine("Digite os números.");
string[] nums = Console.ReadLine().Split(' ');
int[] num = new int[nums.Length];
for (int i = 0; i < nums.Length; i++) {
    num[i] = int.Parse(nums[i]);
}

int maior = num[0];
for (int i = 0; i < nums.Length; i++) {
    if (num[i] > maior) {
        maior = num[i];
    }
}

Console.WriteLine($"O maior é: {maior}");