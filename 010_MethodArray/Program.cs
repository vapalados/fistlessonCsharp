int[] array = {21,32,43,54,65,76,87,90};

int n = array.Length;
int find = 90;

int index = 0;

while(index < n)
{
if(array[index] == find)
{
    Console.WriteLine(index);
}
    index++;
}