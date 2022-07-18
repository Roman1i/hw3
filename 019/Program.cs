int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999) n = Convert.ToInt32(Console.ReadLine());
if (Convert.ToString(n)[0] == Convert.ToString(n)[4] && Convert.ToString(n)[1] == Convert.ToString(n)[3]) Console.WriteLine("да");
else Console.WriteLine("нет");
