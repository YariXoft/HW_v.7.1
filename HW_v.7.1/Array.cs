public class Array : ICalc, IOutput2, ICalc2
{
    private int[] elements;
    public Array(int[] array)
    {
        elements = array;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] < valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
    public int Greater(int valueToCompare)
    {
        int count = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
    public void ShowEven()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] % 2 == 0)
            {
                System.Console.WriteLine(elements[i]);
            }
        }
    }
    public void ShowOdd()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] % 2 != 0)
            {
                System.Console.WriteLine(elements[i]);
            }
        }
    }

    public int CountDistinct()
    {
        int countDistinct = 0;
        bool[] distinctTracker = new bool[101]; // <---максимальне значення в массиві

        for (int i = 0; i < elements.Length; i++)
        {
            int element = elements[i];
            if (!distinctTracker[element])
            {
                distinctTracker[element] = true;
                countDistinct++;
            }
        }
        return countDistinct;
    }
    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] == valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
}
