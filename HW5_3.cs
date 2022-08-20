double [] createArray(int length)
{
    var random = new Random ();
    var result = new double [length];
    for (long i = 0; i < result.Length; i++)
    {
        result [i] = random.NextDouble ();
    }
    return result;
}

void printArray (double [] array)
{
   Console.Write ("[");
   
    for (var i = 0; i < array.Length; i ++)
    {   
        Console.Write ("{0,6:F2}", array[i]);
         if (i < array.Length - 1)
         Console.Write (", ");
        
    }
   Console.Write ("]");
   Console.WriteLine();
}

double MaxMin (double [] array) {   
    var Max = array [1];
    var Min = array [1];
    for (int i = 0; i <= array.Length - 1; i++) {   
        if (array[i] > Max) Max = array[i];      
        if (array[i] < Min) Min = array[i];  
    }
    var diffMaxMin = Max - Min;
    return diffMaxMin;
}   

Console.Write ("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine();

var array = createArray(length);
Console.WriteLine("Сгенерировали массив");

printArray(array);

Console.WriteLine();

var result = MaxMin(array);

Console.Write("Разница между Max и Min: " + "{0,6:F2}", result);
