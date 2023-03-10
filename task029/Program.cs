int n = 8;
int[] array = new int[n];
Random arr = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = arr.Next(1, 9);
}
Console.WriteLine($"[{String.Join("; ", array)}]");