Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int answer = 0;

for(int i = userNumber; i > 0; i = i / 10) answer = answer + i % 10;

Console.WriteLine($"Сумма цифр числа {userNumber} = {answer}");
