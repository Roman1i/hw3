Console.WriteLine("Введите координаты первой точки");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());
int bz = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
Console.WriteLine(string.Format("{0:F2}",result));

