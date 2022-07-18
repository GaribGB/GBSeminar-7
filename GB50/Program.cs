
Console.Clear();
int m = Input("Введите количество строк M: ");
int n = Input("Введите количество столбцов N: ");
double[,] array1 = new double [m,n];

FillArrayRandomDoubleNumbers(array1, m, n);
PrintArray(array1, m, n);

Console.WriteLine("Введите номер строки и номер столбца: ");


int positions = Convert.ToInt32(Console.ReadLine());
int posM = positions/10;
int posN = positions%10;

if(posM<m && posN<n)
{
    Console.WriteLine("Значение элемента в строке " + posM + " столбце " + posN + ": " + array1[posM,posN]);
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}

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
            Console.Write(array[i,j] +  " ");
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
            array[i,j] = rand.Next(0, 10);
        }
    }
}