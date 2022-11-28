Console.Clear();
Console.Write("Введете любое  число:");
int a = Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<a){
    Console.Write($"{i*i*i}, ");
    i++;
}
Console.Write(a*a*a);
