int [] createArray(int length)
{
    var random = new Random ();
    var result = new int [length];
    for (long i = 0; i < result.Length; i++)
    {
        result [i] = random.Next(1,100);
    }
    return result;
}

void printArray (int [] array)
{
   Console.Write ("[");
   
    for (var i = 0; i < array.Length; i ++)
    {   
        Console.Write (array[i]);
         if (i < array.Length - 1)
         Console.Write (", ");
        
    }
   Console.Write ("]");
   Console.WriteLine();
}

int MaxMin (int [] array) {   
    int Max = array [1];
    int Min = array [1];
    for (int i = 0; i <= array.Length - 1; i++) {   
        if (array[i] > Max) Max = array[i];      
        if (array[i] < Min) Min = array[i];  
    }
    int diffMaxMin = Max - Min;
    return diffMaxMin;
}   

Console.Write ("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine();

var array = createArray(length);
Console.WriteLine("Сгенерировали массив");

printArray(array);

Console.WriteLine();

int result = MaxMin(array);

Console.Write("Разница между Max и Min: " + result);
