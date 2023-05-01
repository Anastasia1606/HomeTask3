Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
  int cube = i *i *i;
  Console.WriteLine($"{i}^3 = {cube}");
}