// See https://aka.ms/new-console-template for more information

Console.WriteLine("Creating new math funcs");

int CalclateAVG(int[] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        tmp += arr[i];
    }


    return tmp/arr.Length;


}