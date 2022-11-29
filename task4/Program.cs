Console.Clear();
Console.Write("Введете число кустов: ");
int a = Convert.ToInt32(Console.ReadLine());
int [] b = new int [a];
int []sum=new int[a-2];

for(int i=1;i<=a;i++){
    Console.Write($"Введете количество ягод на {i} кусте: ");
    b[i-1]=Convert.ToInt32(Console.ReadLine());
}
int res=0;
for (int j=1;j<=(a-2);j++){
    if((b[j-1]+b[j]+b[j+1])>res)
        res=b[j-1]+b[j]+b[j+1];

}
Console.Write($"Максимальное количество трех рядостоящих куста =  : {res}");
