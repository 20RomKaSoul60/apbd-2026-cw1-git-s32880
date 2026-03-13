// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int CalclateAVG(int[] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        tmp += arr[i];
    }


    return tmp/arr.Length;
}

int CalculateMAX(int[] arr)
{
    Array.Sort(arr);
    return arr[arr.Length - 1];
}