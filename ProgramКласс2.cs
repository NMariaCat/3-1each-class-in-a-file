// See https://aka.ms/new-console-template for more information
class OneDimentionArr
{
    private int[] array = new int[100];
    public bool WayOfInputtingTheArray = false;
    Random rnd = new Random();
    public OneDimentionArr(int ElementsNumber, bool WayOfInputtingTheArray)
    {
        //Console.WriteLine("Введите количество элементов.")
        //ElementsNumber = Console.ReadLine();
    }
    public void OneDimentionArrINP(int ElementsNumber, bool WayOfInputtingTheArray)
    {
        if (WayOfInputtingTheArray == false)
        {
            for (int i = 0; i < ElementsNumber; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }
        else
        {
            for (int i = 0; i < ElementsNumber; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void oneDimentionArrOUTPUT(int ElementsNumber)
    {
        for (int i = 0; i < ElementsNumber; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public double countAverage(int ElementsNumber)
    {
        int m = 0;
        int k = 0;
        for (int i = 0; i < ElementsNumber; i++)
        {
            k += array[i];
            m++;
        }
        return k / m;
    }

    public string DeleteMoreThan100(int ElementsNumber)
    {
        string line = "";
        for (int i = 0; i < ElementsNumber; i++)
        {
            if (array[i] < 100 && array[i] > -100)
            {
                line += array[i].ToString();
                line += " ";
            }
        }
        return line;
    }

    public string DeleteTheRepeating(int ElementsNumber)
    {
        int[] arr = new int[100];
        string line = "";
        int t = 0;
        int[] b = array;
        for (int i = 0; i < ElementsNumber; i++)
        {
            if (Check(arr, b[i]) == false)
            {
                arr[t] = b[i];
                t++;
                line += b[i];
                line += " ";
            }
        }
        return line;
    }

    bool Check(int[] arr, int k)

    {
        foreach (int i in arr)
        {
            if (i == k)
                return true;
        }
        return false;
    }


}
