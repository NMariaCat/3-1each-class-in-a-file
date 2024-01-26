class TwoDimentionArr
{
    public int[,] array;
    Random rnd = new Random();
    public bool WayOfInputtingTheArray = false;
    public TwoDimentionArr(int colomnsN, int linesM)
    {
        array = new int[colomnsN, linesM];
    }
    public void TwoDimentionArrINP(bool WayOfInputtingTheArray, int colomnsN, int linesM)
    {
        if (WayOfInputtingTheArray == false)
        {
            for (int i = 0; i < colomnsN; i++)
            {
                for (int j = 0; j < linesM; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        else
        {
            for (int i = 0; i < colomnsN; i++)
            {
                for (int j = 0; j < linesM; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
    public void TwoDimentionArrOUTPUT(int colomnsN, int linesM)
    {
        for (int i = 0; i < colomnsN; i++)
        {
            for (int j = 0; j < linesM; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public int countAverage(int colomnsN, int linesM)
    {
        int m = 0;
        for (int i = 0; i < colomnsN; i++)
        {
            for (int j = 0; j < linesM; j++)
            {
                m += array[i, j];
            }
        }
        return m / (colomnsN * linesM);
    }
    public void PrintArrBackw(int colomnsN, int linesM)
    {
        for (int i = 0; i < colomnsN; i++)
        {
            if (i % 2 == 1)
            {
                for (int j = linesM - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                for (int j = 0; j < linesM; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}