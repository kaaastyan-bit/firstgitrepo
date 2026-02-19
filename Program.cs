namespace trainingalgoritmov;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static void Bubble(int[] a)
    {
        int n = a.Length;
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int t = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = t;
                }
            }
        }
    }

    static void Select(int[] a)
    {
        int n = a.Length;
        for(int i = 0; i < n; i++)
        {
            int minIndex = i;
            for(int j = i + 1; j < n; j++)
            {
                if (a[j] > a[minIndex])
                {
                    minIndex = j;
                }
            }
            int t = a[i];
            a[i] = a[minIndex];
            a[minIndex] = t;
        }
    }

    static void Insertion(int[] a)
    {
        for(int i = 1; i < a.Length; i++)
        {
            int current = i;
            int j = i - 1;
            while(j >= 0 && a[j] > current)
            {
                a[j + 1] = a[j];
                j--;
            }

            a[j + 1] = current;
        }
    }

    static void CompleteSearch()
    {
        for(int i = 0; i < 9; i++) 
    {
            if ((i * 10 + 3) * 6528 == (30 + i) * 8256)
                return i;
    }


}

