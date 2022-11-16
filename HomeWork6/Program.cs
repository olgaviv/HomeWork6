// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Find(int[]array)
{
    int count = 0;
    for( int i=0; i< array.Length; i++)
        if(array[i] > 0 )
            count++;
    return count;
}

int [] CreateArrayPols(int size)
{
    int[] array = new int[size];

    int i = 0;
       while (i < size)
        {
           Console.WriteLine("Введите элемент массива");
           array[i] = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine();
           i++;
        }
    
    return array;
}

        int m;
        Console.WriteLine("Введите число элементов массива");
        m = Convert.ToInt16(Console.ReadLine());
        
int[] myArray = CreateArrayPols(m);
ShowArray(myArray);
Console.WriteLine($"Количество чисел больше нуля  = {Find(myArray)}");

*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int TochPeresech(double k1, double b1, double k2, double b2)
{
    int res;
    Console.WriteLine ($" 1 прямая: y = {k1}x+{b1}");
    Console.WriteLine ($" 2 прямая: y = {k2}x+{b2}");
    
if( ( k1 == k2) && ( b1 == b2 )) 
             {
                res = 0;
                Console.WriteLine("Прямые совпадают");        
                                                                                          
                if (( k1 ==k2)&&(b1!=b2))  
                    {res = -1;
                    Console.WriteLine("Прямые параллельны"); 
                    }                                                    
             }
            else res = 1;
                      
                                     
            return res;
            
}

Console.Write("Введите значение b1:  ");
double b1= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2:  ");
double b2= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

int res = TochPeresech(k1,b1,k2,b2);
 
       if (res==1)
        {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1*x+b1;  
        Console.WriteLine($"Точка пересечения двух прямых: x = {x} y = {y}");
        }   
     