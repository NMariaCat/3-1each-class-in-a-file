// See https://aka.ms/new-console-template for more information
class SteppedArray
{
    public int[][] array;
    public int[] lengths = new int[100];
    Random rnd = new Random();
    public bool WayOfInputtingTheArray = false;
    public SteppedArray(int colsN, int[] lengths)
    {
        array = new int[colsN][];
        for (int i = 0; i < colsN; i++)
        {
            array[i] = new int[lengths[i]];
        }
    }

    public void SteppedINP(bool WayOfInputtingTheArray, int colN, int[] lengths)
    {
        if (WayOfInputtingTheArray == false)
        {
            for (int i = 0; i < colN; i++)
            {
                for (int j = 0; j < lengths[i]; j++)
                {
                    array[i][j] = rnd.Next(-100, 100);
                }

            }
        }
        else
        {
            for (int i = 0; i < colN; i++)
            {
                Console.WriteLine("Введите элементы строки " + (i + 1));
                for (int j = 0; j < lengths[i]; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }

            }
        }

    }

    public int countAverage(int colN, int[] lengths)
    {
        int m = 0;
        int num = 0;
        for (int i = 0; i < colN; i++)
        {
            for (int j = 0; j < lengths[i]; j++)
            {
                m += array[i][j];
                num++;
            }
        }
        return m / num;
    }

    public void ChangeInd(int colN)
    {
        for (int i = 0; i < colN; i++)
        {
            int lineM = array[i].Length;
            for (int j = 0; j < lineM; j++)
            {
                if (array[i][j] % 2 == 0)
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                        array[i][j] = i * j;
                    }
            }

        }
    }
    public void AverageInEveryStepped(int colN)
    {
        for (int i = 0; i < colN; i++)
        {
            int num = 0;
            int sum = 0;
            int lineM = array[i].Length;
            for (int j = 0; j < lineM; j++)
            {
                num++;
                sum += array[i][j];
            }
            Console.WriteLine(sum / num);

        }
    }

    public void SteppedOUTPUT(int colN)
    {
        for (int i = 0; i < colN; i++)
        {
            int lineM = array[i].Length;
            for (int j = 0; j < lineM; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();

        }
    }

}

}

