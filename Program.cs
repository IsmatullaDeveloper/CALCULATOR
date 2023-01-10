string password = "";

do
{
    System.Console.WriteLine("Enter password");
    password = Console.ReadLine();
} while (password != "kod");
System.Console.WriteLine("Salom hurmatli foydalanuvchi! Kalkulyator dasturimizga xush kelibsiz :)");
// System.Console.Write("Keling tanishamiz. Ismingizni kiriting: ");
// string greeting = Console.ReadLine();
// System.Console.WriteLine($"Wohooo! Siz bilan tanishishdan xursandman {greeting}");
System.Console.Write("Birinchi raqamni kiriting: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter operation(+,-,/,*,%)");
string operation = Console.ReadLine();
int num1 = Convert.ToInt32(firstNumber);
System.Console.Write("Ikkinchi raqamni kiriting: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(secondNumber);

System.Console.WriteLine($"Ko'paytma: {num1 * num2}");
System.Console.WriteLine($"Bo'linma: {num1 / num2}");
System.Console.WriteLine($"Yig'indi: {num1 + num2}");
System.Console.WriteLine($"Ayirma: {num1 - num2}");
System.Console.WriteLine($"Qoldiq: {num1 % num2}");

string message =
    num1 >= 0
        ? "1st number is positive"
        : "1nd number is negative";

System.Console.WriteLine(message);

string messageNum2 =
    num2 >= 0
        ? "2nd number is positive"
        : "2nd nember is negative";

System.Console.WriteLine(messageNum2);

if (num1 > num2)
{
    System.Console.WriteLine("1st number is greater than the 2nd!");
}
else if (num1 == num2)
{
    System.Console.WriteLine("The 1st and 2nd number are equel!");
}
else
{
    System.Console.WriteLine("The 2nd number is greater than the 1st!");
}

string result = operation switch
{
    "+" => $"{num1} + {num2} = {num1 + num2}",
    "-" => $"{num1} - {num2} = {num1 - num2}",
    "/" => $"{num1} / {num2} = {num1 / num2}",
    "*" => $"{num1} * {num2} = {num1 * num2}",
    "%" => $"{num1} % {num2} = {num1 % num2}",
    _ => "Operation Not Found"
};

System.Console.WriteLine(result);


for (int iterator = 1; iterator <= 10; iterator++)
{
    for( int innerIterator = 1; innerIterator <= 10; innerIterator++)
    {
        System.Console.WriteLine($"{iterator} * {innerIterator} = {iterator * innerIterator}");
    }
   System.Console.WriteLine();
}