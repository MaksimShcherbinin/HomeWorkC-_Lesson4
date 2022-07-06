Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int answer = 1;
for(int i = 1; i <= numberB; i++) answer = answer*numberA;
Console.WriteLine($"{numberA}^{numberB} = {answer}");
