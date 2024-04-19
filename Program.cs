// See https://aka.ms/new-console-template for more information

int firstNum;
int secondNum;
string command;

Console.WriteLine("This is a test calculator!");
Console.WriteLine("Please enter your first number");

firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Okay! Your first number is {firstNum}");
Console.WriteLine("Please enter your second number");


secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Okay! Your second number is {secondNum}");
Console.WriteLine("What would you like to do with these two numbers? You can use commands like 'add', 'subtract', 'divide', or 'multiply'.");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
command = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

if (command == "add") {
    Console.WriteLine($"The sum of your two numbers is {firstNum + secondNum}");
} else if (command =="subtract") {
    Console.WriteLine($"The difference between  your two numbers is {firstNum - secondNum}");
} else if (command == "multiply") {
    Console.WriteLine($"The product of your two numbers is {firstNum * secondNum}");
} else if (command == "divide") {
    float quotient = (float)firstNum / secondNum;
    Console.WriteLine ($"The quotient between your two numbers is {quotient}");
} else {
    Console.WriteLine ($"Sorry! I don't recognize that command!");
}
