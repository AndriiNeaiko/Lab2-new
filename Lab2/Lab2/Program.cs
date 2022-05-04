Console.WriteLine("Specify age from 20 to 69 years:");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case int m when (m % 10 == 1):
        Console.WriteLine(n + " year");
        break;
    case int m when (m == 20 || m >= 25 && m <= 30 || m >= 35 && m <= 40 || m >= 45 && m <= 50 || m >= 55 && m <= 60 || m >= 65 && m < 70):
        Console.WriteLine(n + " years");
        break;
    case int m when (m % 10 == 2 || m % 10 == 3 || m % 10 == 4):
        Console.WriteLine(n + " of the year");
        break;

}
Console.ReadLine();