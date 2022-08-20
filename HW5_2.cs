int [] createArray(int length)
{
    var random = new Random ();
    var result = new int [length];
    for (long i = 0; i < result.Length; i++)
    {
        result [i] = random.Next(-99,100);
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

int sumNumb (int [] array) {   
    int sumNumbs = 0;
    for (int i = 0; i <= array.Length - 1; i++) {   
        if (i%2 == 1) sumNumbs = sumNumbs + array[i];      
    }
    return sumNumbs;
}   

Console.Write ("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine();

var array = createArray(length);
Console.WriteLine("Сгенерировали массив");

printArray(array);

Console.WriteLine();

int result = sumNumb(array);

Console.Write("Сумма чисел на нечетных позициях: " + result);
