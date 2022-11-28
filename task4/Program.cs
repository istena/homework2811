Console.Clear();
Console.Write("Введете число кустов: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum=0;

for(int i=1;i<=a;i++){
    Console.Write($"Введете количество ягод на {i} кусте: ");
    sum+=Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Количество ягод на всех кустах : {sum}");
