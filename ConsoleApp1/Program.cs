Console.Write("Enter 1st number: ");
int x = 0;
x = Int32.Parse(Console.ReadLine()) ;
string opperation = "";
do
{
    Console.Write("+ for addition\n- for subtraction\n* for multiplication\n/ for division\nEnter operation: ");
    opperation = Console.ReadLine();
} while (opperation[0] != '+' && opperation[0] != '-' && opperation[0] != '*' && opperation[0] != '/');
int op = 0;
if (opperation[0] == '+')
{
    op += 1;
}
else if (opperation[0] == '-')
{
    op += 2;
}
else if (opperation[0] == '*')
{
    op += 3;
}
else
{
    op += 4;
}

Console.Write("Enter 2nd number: ");
int y = 0;
y =Int32.Parse( Console.ReadLine());
if (op==1)
{
    Console.WriteLine("\n" + (x + y));
}
else if (op==2)
{
    Console.WriteLine("\n" + (x - y));
}
else if (op==3)
{
    Console.WriteLine("\n" + (x * y));
}
else
{
    Console.WriteLine("\n" + (x / y));
}
Console.ReadLine();