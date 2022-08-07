int[] Array = { 12, 23, 32, 44, 512, 63, 73, 44 };

int n = Array.Length;
int find = 44;

int index = 0;

while (index < n)
{
    if (Array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}