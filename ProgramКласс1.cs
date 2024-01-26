// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Двумерные  массивы");
        Console.WriteLine("Введите количество элементов в строке.");
        int linesM = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество элементов в столбце.");
        int colomnsN = int.Parse(Console.ReadLine());
        bool WayInpArr2D;
        Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
        if (Console.ReadLine() == "+")
        {
            WayInpArr2D = true;
        }
        else
        {
            WayInpArr2D = false;
        }
        TwoDimentionArr twoD = new TwoDimentionArr(colomnsN, linesM);
        twoD.TwoDimentionArrINP(WayInpArr2D, colomnsN, linesM);
        Console.WriteLine("Массив: ");
        twoD.TwoDimentionArrOUTPUT(colomnsN, linesM);
        Console.WriteLine("Среднее арифметическое элементов: " + twoD.countAverage(colomnsN, linesM));
        Console.WriteLine("Массив, в котором элементы четных строк напечатаны в обратном порядке: ");
        twoD.PrintArrBackw(colomnsN, linesM);

        //одномерные
        Console.WriteLine("Одномерные  массивы");
        Console.WriteLine("Введите количество элементов.");
        int ElementsNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
        bool WayInpArr1D;
        if (Console.ReadLine() == "+")
        {
            WayInpArr1D = true;
        }
        else
        {
            WayInpArr1D = false;
        }
        OneDimentionArr oneD = new OneDimentionArr(ElementsNumber, WayInpArr1D);
        oneD.OneDimentionArrINP(ElementsNumber, WayInpArr1D);
        oneD.oneDimentionArrOUTPUT(ElementsNumber);
        Console.WriteLine("Среднее арифметическое элементов: " + oneD.countAverage(ElementsNumber));
        Console.WriteLine("Массив, из которого удалили элементы, большие 100 по модулю: " + oneD.DeleteMoreThan100(ElementsNumber));
        Console.WriteLine("Массив, из которого удалили повторяющиеся элементы: " + oneD.DeleteTheRepeating(ElementsNumber));

        //ступенчатые
        Console.WriteLine("Ступенчатые  массивы");
        bool WayInpStepped;
        Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
        if (Console.ReadLine() == "+")
        {
            WayInpStepped = true;
        }
        else
        {
            WayInpStepped = false;
        }
        Console.WriteLine("Введите количество строк");
        int colN = int.Parse(Console.ReadLine());
        int[] lengths = new int[100];
        for (int i = 0; i < colN; i++)
        {
            Console.WriteLine("Сколько элементов в строке " + (i + 1) + "?");
            lengths[i] = int.Parse(Console.ReadLine());
        }
        SteppedArray st = new SteppedArray(colN, lengths);
        st.SteppedINP(WayInpStepped, colN, lengths);
        st.SteppedOUTPUT(colN);
        Console.WriteLine("Среднее арифметическое элементов: " + st.countAverage(colN, lengths));
        Console.WriteLine("Средние арифметические строк массива");
        st.AverageInEveryStepped(colN);
        Console.WriteLine("Массив, в котором четные по значению элементы массива заменены на произведения их индексов");
        st.ChangeInd(colN);
        st.SteppedOUTPUT(colN);
    }
}
