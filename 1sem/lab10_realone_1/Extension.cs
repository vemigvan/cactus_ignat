static class Extension
{
    public static int MyReverse(this int a)
    {
        string src, res = "";
        int k = 1;
        if (a < 0)
        {
            a *= -1;
            k = -1;
        }
        src = a.ToString();
        for (int i = src.Length - 1; i >= 0; i--)
        {
            res += src[i];
        }
        int.TryParse(res, out a);
        a *= k;

        return a;
    }

    public static string MyReverse(this string src)
    {
        string res = "";
        for (int i = src.Length - 1; i >= 0; i--)
        {
            res += src[i];
        }

        return res;
    }

    public static double MyReverse(this double a)
    {
        string src, res = "";
        int k = 1;
        if (a < 0)
        {
            a *= -1;
            k = -1;
        }
        src = a.ToString();
        for (int i = 0; src[i] != '.'; i++)
        {
            res += src[i];
        }
        res = res.MyReverse();
        res += ".";
        for (int i = src.Length - 1; src[i] != '.'; i--)
        {
            res += src[i];
        }


        double.TryParse(res, out a);
        a *= k;

        return a;
    }

    public static string MyReverse(this string src, char p)
    {
        string res = "";
        int i, j = 0;
        for (i = 0; src[i] != p; i++)
        {
            res += src[i];
        }
        j = i;
        res = res.MyReverse();
        res += p;
        for (i = src.Length - 1; i != j; i--)
        {
            res += src[i];
        }
        return res;
    }

    public static int[] MyReverse(this int[] src)
    {
        int[] res = new int[src.Length];
        for (int i = 0; i < src.Length; i++)
        {
            res[i] = src[src.Length - i - 1];
        }
        return res;
    }

    public static int[] MySort(this int[] src)
    {
        int t;
        for (int i = 0; i < src.Length - 1; i++)
        {
            for (int j = i + 1; j < src.Length; j++)
            {
                if (src[i] > src[j])
                {
                    t = src[i];
                    src[i] = src[j];
                    src[j] = t;
                }
            }
        }
        return src;
    }
}
