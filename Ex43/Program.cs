// Программа находит точку пересечения двух прямых, 
// заданных уравнениями.

Console.Clear();

Console.WriteLine("Для уравнения первой прямой y=kx+b:");
Console.Write("Введите k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Для уравнения второй прямой y=kx+b:");
Console.Write("Введите k2: ");
double k2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2}");

if(k1==k2)
    Console.WriteLine("параллельны");
else 
    Console.Write($"пересекаются в точке [{FindInterPoint(k1,b1,k2,b2).Item1};{FindInterPoint(k1,b1,k2,b2).Item2}]");

(double, double) FindInterPoint(double k1, double b1, double k2, double b2)
{
    double x=0.0,y=0.0;
    
    x=(b1-b2)/(k2-k1);
    y=k1*x+b1;
        
    return (x,y);   
}

