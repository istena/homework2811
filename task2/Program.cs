Console.Clear();
Console.Write("Введете координаты первой точки: ");
int [] a=new int[3];
for(int i=0;i<3;i++){
     a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введете координаты второй точки: ");
int [] b=new int[3];
for(int i=0;i<3;i++){
     b[i] = Convert.ToInt32(Console.ReadLine());
}
double result=Math.Sqrt((b[0]-a[0])*(b[0]-a[0])+(b[1]-a[1])*(b[1]-a[1])+(b[2]-a[2])*(b[2]-a[2]));
Console.Write($"Растояние межде двумя точками = {result}");

