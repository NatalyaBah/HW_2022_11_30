#define HW3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2022_11_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if HW1
            /*Задание 1
            Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных
            чисел с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а 
            двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива 
            А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, 
            минимальный элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных 
            элементов массива А, сумму нечетных столбцов массива В. */
            int[]A = new int[5];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < A.Length; i++) A[i] = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Заполненный массив Вашими значениями: ");
            for (int j = 0; j < A.Length; j++) Console.Write(A[j] + " ");
            Console.WriteLine("\n");

            double[,]B=new double[3,4];
            Random r = new Random();
            Console.WriteLine("Двух мерный массив заполненный рандомными значениями: \n");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    B[i,j] = r.NextDouble()*20;
                    Console.Write("{0,8:N3}", B[i,j], 2);
                }
                Console.WriteLine(" ");
            } 
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент массива \"A\": " + A.Max() + "\n");
            double maxI = 0;
            for (int i = 0; i < 3; i++)
            {   
                for (int j = 0; j < 4; j++)
                {
                    maxI = Math.Max(maxI, B[i,j]);                    
                }
            }
            Console.WriteLine("Максимальный элемент массива \"B\": " + Math.Round(maxI, 3) + "\n");
            double maxB = A.Max();
            if(maxB < maxI) maxB = maxI;
            Console.WriteLine("Максимальный размер из двух массивов: " + Math.Round(maxB, 3) + "\n");
            // поиск минимального значения
            Console.WriteLine("Минимальный элемент массива \"A\": " + A.Min() + "\n");
            double minI = maxB;
            for (int i = 0; i < 3; i++)
            {   
                for (int j = 0; j < 4; j++)
                {
                    minI = Math.Min(minI, B[i,j]);                    
                }
            }
            Console.WriteLine("Минимальный элемент массива \"B\": " + Math.Round(minI, 3) + "\n");
            double minB = A.Min();
            if(minB < minI) minI = minB;
            Console.WriteLine("Минимальный размер из двух массивов: " + Math.Round(minI, 3) + "\n");
            // сумма элементов массивов
            Console.WriteLine("Сумма элемнтов массива \"A\": " + A.Sum() + "\n");
            double sumI = 0;
            for (int i = 0; i < 3; i++)
            {   
                for (int j = 0; j < 4; j++)
                {
                    sumI += B[i,j];
                }
            }
            Console.WriteLine("Сумма элементов массива \"B\": " + Math.Round(sumI, 3) + "\n");
            double sumAll = A.Sum() + Math.Round(sumI, 3);
            Console.WriteLine("Сумма элементов двух массивов: " + Math.Round(sumAll, 3) + "\n");
            //произведение массивов
            int multA = 1;
            for (int i = 0; i < 5; i++)
			{
                multA *= A[i];
			}
            Console.WriteLine("Произведение элементов массива \"A\": " + multA + "\n");
            double multB = 1;
            for (int i = 0; i < 3; i++)
            {   
                for (int j = 0; j < 4; j++)
                {
                    multB *= B[i,j];
                }
            }
            Console.WriteLine("Произведение элементов массива \"B\": " + Math.Round(multB, 3) + "\n");
            double multAll = multA * Math.Round(multB, 3);
            Console.WriteLine($"Произведение двух массивов равна: {multAll}");
            Console.WriteLine();
            //сумма чётных элементов массива            
            Console.WriteLine("Сумма четных элементов массива \"A\": " + A.Where(i => i % 2 == 0).Sum() + "\n");
            // сумма не чётных элементов столбцов массива
            double ancountB = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i,j] % 2 !=0) ancountB += B[0,j];
                }
                Console.WriteLine("Сумма не чётных элементов сталбцов массива \"B\": " + Math.Round(ancountB, 3) + "\n");
            }
#endif         

#if HW2
            /*Задание 2
            Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
            Определить сумму элементов массива, расположенных между минимальным и максимальным элементами. */

            int [,] array= new int[5,5];
            Random r= new Random();
            for (int i = 0; i < 5; i++)
			{
                for (int j = 0; j < 5; j++)
			    {
                    array[i,j]=r.Next(-100, 100);
                    Console.Write(array[i,j] + "\t");
			    }
                Console.WriteLine(" ");
			}
            int min=0;
            int max=0;
            for (int i = 0; i < 5; i++)
            {   
                for (int j = 0; j < 5; j++)
                {
                    min = Math.Min(min, array[i,j]);                    
                }
            }
            for (int i = 0; i < 5; i++)
            {   
                for (int j = 0; j < 5; j++)
                {
                    max = Math.Max(max, array[i,j]);                    
                }
            }
            int summ=0;
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
			    {
                    summ += array[i,j];
			    }
            }
            Console.WriteLine($"Сумма от минимального числа, до максимального равна: {summ-min-max}");
#endif



#if HW3
            /*Задание 3
            Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. 
            Из Википедии:
            Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется 
            символом, находящимся на некотором постоянном числе позиций левее или правее него в алфавите. Например, 
            в шифре со сдвигом вправо на 3, A была бы заменена на D, B станет E, и так далее. 
            Кроме механизма шифровки, реализуйте механизм расшифрования. */

            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            char[] strChar = str.ToCharArray();            
            Console.Write("Введите ключ для шифрования: ");
            var key = Console.ReadLine(); //кол-во перестановок
            int Q = 33; //кол-во символов в алфавите
            int n = 0;
            int result=0;
            for (int i = 0; i < strChar.Length; i++)
			{
                Console.Write(strChar[i] + "\t");                
                result += Convert.ToChar(Convert.ToInt16(strChar[i]) + key - Q) % Q;
                Console.Write(result);
			}
            //не справилась с заданием, не как не осилю string
            
#endif

#if HW4

            /*Задание 4
            Создайте приложение, которое производит операции над матрицами:
            ■ Умножение матрицы на число;
            ■ Сложение матриц;
            ■ Произведение матриц.*/

            Random random = new Random();
            Console.Write("Cоздайте матрицу, введите количество сталбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Первая матрица: ");
            int[,] array = new int[x, y];
            int result = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = random.Next(1, 10);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Умножение матрицы на число

            Console.WriteLine("Введите число на которое хотите умножить маирицу: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Вывод матрицы после умножения на " + number);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    result = array[i, j] * number;
                    Console.Write(result + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //сложение матриц

            Console.WriteLine("Вторая матрица") ;
            int[,] array1 = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array1[i, j] = random.Next(1, 10);
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine() ;
            Console.WriteLine("Результат сложения матриц");
            int result1 = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    result1 = array[i, j] + array1[i, j];
                    Console.Write(result1 + "\t");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine();
            //умножение матриц

            Console.WriteLine("Результат умножения матриц");
            int result2 = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    result2 = array[i, j] * array1[i, j];
                    Console.Write(result2 + "\t");
                }
                Console.WriteLine();
            }

#endif

#if HW5
            /*Задание 5
            Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать 
            его результат. Необходимо поддерживать только две операции: + и –. */
            Console.Write("Введите арифметическое выражение :");
            string str = Console.ReadLine();
            char znak = ' ';
            foreach (var e in str)
            {
                if (e == '+' || e == '-')
                {
                    znak = e; break;
                }
            }
            var str1=str.Substring(0, 1); //если поменять 1 на 2 можно складывать десятичные и так далее
            int x = int.Parse(str1);
            var str2 = str.Substring(str.Length-1); // и здесь тоже не знаю как сделать по другому, вероятно через цикл
            int y = int.Parse(str2);
            int result = 0;
            switch (znak)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;              
                default:
                    throw new InvalidOperationException();
            }
            Console.WriteLine($"Результат вычисления : {result}");

#endif

#if HW6

            /*Задание 6
            Пользователь с клавиатуры вводит некоторый текст. Приложение должно изменять регистр первой буквы 
            каждого предложения на букву в верхнем регистре.*/

            string str = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0].ToString().ToUpper());
            for (int i = 1; i < str.Length; i++)
            {
                if(char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
                {
                    stringBuilder.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());

#endif

#if HW7

            /*Задание 7
            Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно 
            должно быть заменено на набор символов *. По итогам работы приложения необходимо показать статистику 
            действий. */

            int counter = 0;
            string a = (@"To be, or not to be, that is the question,
Whether 'tis nobler in the mind to suffer
The slings and arrows of outrageous fortune,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
The heart-ache and the thousand natural shocks
That flesh is heir to, 'tis a consummatioт
Devoutly to be wish'd. To die, to sleep");
            Console.WriteLine("Исходный текст:");
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine();
            string b = a.Replace("die", "***");
            Console.WriteLine("Текст после заметы \"die\" на \"***\"");
            Console.WriteLine();
            Console.WriteLine(b);
            Console.WriteLine();
            var T = b.Split(' ').ToList();
            foreach (var e in T)
            {
                if (e.Contains("***"))
                {
                    counter++;                   
                }
            }
            Console.WriteLine($"Количество замены: { counter }");

#endif
        }
    }
}