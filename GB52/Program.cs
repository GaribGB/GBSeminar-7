
Console.Clear();
int m = Input("Введите количество строк M: ");
int n = Input("Введите количество столбцов N: ");
int[,] array1 = new int [m,n];

FillArrayRandomDoubleNumbers(array1, m, n);
Console.Write("\n");
PrintArray(array1, m, n);


Console.Write("Среднее арифметическое каждого столбца: \n");
for(int i=0 ; i<n ; i++)
{
    double sum = 0;
    for(int j=0 ; j<m ; j++)
    {
        sum = sum + array1[j,i];
    }
    double average = sum/m;
    Console.Write(Math.Round(average, 1) +  "\t");
}
Console.WriteLine("\n");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array, int m, int n)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            Console.Write(array[i,j] +  "\t");
        }
        Console.Write("\n");
    }
}

void FillArrayRandomDoubleNumbers(int[,] array, int m, int n)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            Random rand = new Random();
            array[i,j] = rand.Next(10);
        }
    }
}
