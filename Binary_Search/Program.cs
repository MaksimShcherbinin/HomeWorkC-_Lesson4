Console.WriteLine("Загадай число от 1 до 100: ");
int n_first = 0, n_last = 100, mid = 50;
Console.WriteLine("Число {0}?", mid);
string? ans = Console.ReadLine();
if (ans != "yes")
{
    while (n_first <= n_last)
    {
        mid = (n_first + n_last) / 2;
        Console.WriteLine("Число больше {0}?", mid);
        ans = Console.ReadLine();
        if (ans == "yes") n_first = mid + 1;
        else n_last = mid - 1;
    }
}

Console.WriteLine(mid);
