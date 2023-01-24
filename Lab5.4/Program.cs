using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов в массиве");
        int count = Convert.ToInt32(Console.ReadLine());
        double[] firstArray = new double[count];
        double[] secondArray = new double[count];
        int i = 0;
        while (i != count)
        {
            firstArray[i] = Convert.ToDouble(Console.ReadLine());
            i++;
        }
        for (int y = 0; y < firstArray.Length; y++)
        {
            if (firstArray[y] > 0 && firstArray[y] % 1 == 0)
            {
                secondArray[y] = Factorial(firstArray[y]);
            }
            else if (firstArray[y] > 0 && firstArray[y] % 1 != 0 || (firstArray[y] < 0 && firstArray[y] % 1 != 0))
            {
                if (firstArray[y] < 0)
                {
                    double plus = firstArray[y] * -1;
                    double roundNum = Math.Round(plus, 2);
                    int roundNum1 = Convert.ToInt32(roundNum * 100);
                    secondArray[y] = roundNum1 % 100;
                }
                else
                {
                    double roundNum = Math.Round(firstArray[y], 2);
                    int roundNum1 = Convert.ToInt32(roundNum * 100);
                    secondArray[y] = roundNum1 % 100;
                }
            }
            else
            {
                secondArray[y] = firstArray[y];
            }
        }
        Console.WriteLine("Первый массив:");
        for (int j = 0; j < firstArray.Length; j++)
        {
            Console.Write("{0} ", firstArray[j]);
        }
        Console.WriteLine("");
        Console.WriteLine("Новый массив");
        for (int u = 0; u < secondArray.Length; u++)
        {
            Console.Write("{0} ", secondArray[u]);
        }
    }
    public static int Factorial(double n)
    {
        int factorial = 1;
        for (int f = 1; f <= n; f++)
        {
            factorial = factorial * f;
        }
        return factorial;
    }


}
