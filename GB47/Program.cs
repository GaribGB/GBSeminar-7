
Console.Clear();
int m = Input("Введите количество строк M: ");
int n = Input("Введите количество столбцов N: ");
double[,] array1 = new double [m,n];

FillArrayRandomDoubleNumbers(array1, m, n);
PrintArray(array1, m, n);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] array, int m, int n)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            Console.Write(array[i,j] +  " \t");
        }
        Console.Write("\n");
    }
}

void FillArrayRandomDoubleNumbers(double[,] array, int m, int n)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            Random rand = new Random();
            array[i,j] = rand.Next(-9999, 10000)*0.01;
            array[i,j] = Math.Round(array[i,j], 2);
        }
    }
}