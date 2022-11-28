Console.Clear();
Console.Write("Введете любое пятизначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if((a%10)==(a/10000)){
    if(((a%100)/10)==((a/1000)%10)){
        Console.Write("Да");
    }
}
else 
    Console.Write("Нет");
