System.Console.WriteLine("Salom hurmatli foydalanuvchi! Kalkulyator dasturimizga xush kelibsiz :)");
System.Console.Write("Keling tanishamiz. Ismingizni kiriting: ");
string greeting = Console.ReadLine();
System.Console.WriteLine($"Wohooo! Siz bilan tanishishdan xursandman {greeting}");
System.Console.Write("Birinchi raqamni kiriting: ");
string firstNumber = Console.ReadLine();
int num1 = Convert.ToInt32(firstNumber);
System.Console.Write("Ikkinchi raqamni kiriting: ");
string secondNumber = Console.ReadLine();
int num2 = Convert.ToInt32(secondNumber);

System.Console.WriteLine($"Ko'paytma: {num1 * num2}");
System.Console.WriteLine($"Bo'linma: {num1 / num2}");
System.Console.WriteLine($"Yig'indi: {num1 + num2}");
System.Console.WriteLine($"Ayirma: {num1 - num2}");
System.Console.WriteLine($"Qoldiq: {num1 % num2}");