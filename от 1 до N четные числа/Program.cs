Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 1;
while(a>=b)
{
    if((b%2)==0)
    Console.WriteLine(" "+b);
    b=b+1;
}

