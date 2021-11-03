int minValue = new Random().Next(-90, -10);
int maxValue = new Random().Next(10, 90);

Console.WriteLine(minValue);
Console.WriteLine(maxValue);
//int[] arrayA = {-50, -40, -30, -10, 5, 20, 23, 19, 20, 60};
int[] arrayA = new int[10];
int[] arrayB = new int[10];


for(int j=0; j<10; ++j)   // Заполнение массива случайными числами
{
    Random rnd;
    rnd=new Random();
    arrayA[j] = new Random().Next(minValue,maxValue);
} 

PrintArray(arrayA);
Console.WriteLine();

int[] createArrayB(int[] arrayB) //Создание массива B на основе массива А с отбрасыванием чисел, нарушающих порядок возрастания
{
    int len = (arrayA.Length)-1;
    int index = 0;
    int index2 = 0;
    int currentElement = -90;
    while (index <= len)
    {
        if(arrayA[index] > currentElement)
            {
                currentElement = arrayA[index];
                arrayB[index2] = currentElement;
                index2++;
            }
        index++;
    }
    return arrayB;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            if(col[position]!=0)
        {
            Console.Write(col[position] +" ");
        }
            position++;
    }  
}

arrayB = createArrayB(arrayB);
PrintArray(arrayB);
