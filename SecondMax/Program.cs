int[] array = { 1, 2, 3, 4, 5, 6, 7, 0, 8, 9, 10 };
int i = 2;
int max = 0;
int max2 = 0;

if (array[0] > array[1])
{
    max = array[0];
    max2 = array[1];
}
if (array[1] > array[0])
{
    max = array[1];
    max2 = array[0];
}

while (i < array.Length)
{
    if (array[i] == 0) break;
    if (array[i] > max) 
    {
        max2 = max;
        max = array[i];
    }
    i++;
}
Console.WriteLine(max2);




