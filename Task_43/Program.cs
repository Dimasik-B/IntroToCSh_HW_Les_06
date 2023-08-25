Console.WriteLine("Прямые заданы уравнениями: y = k1 * x + b1, y = k2 * x + b2");

Console.Write("\nВведите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nТочка пересечения двух прямых: {String.Join("; ", GetCrossPoint(b1, k1, b2, k2))}");

double [] GetCrossPoint (double b1, double k1, double b2, double k2){
    double [] crossPoint = new double[2];
    double x = -(b1 - b2) / (k1 - k2);
    double y = k2 * x + b2;
    crossPoint[0] = Math.Round(x, 1);
    crossPoint[1] = Math.Round(y, 1);
    return crossPoint;
}