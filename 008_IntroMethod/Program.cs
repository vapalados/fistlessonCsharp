int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int a1 = 125;
int b1 = 221;
int c1 = 548;
int a2 = 59;
int b2 = 44;
int c2 = 5585;
int a3 = 82;
int b3 = 9653;
int c3 = 99;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
     Max(a2, b2, c2),
      Max(a3, b3, c3));



Console.WriteLine(max);