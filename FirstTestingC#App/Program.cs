// Exercise 1

Console.WriteLine("What is your name?");
string nameToStore = Console.ReadLine();

Console.WriteLine($"Hello, {nameToStore}!");

// Exercise 2

int firstNumber = 5;
int secondNumber = 3;

Console.WriteLine($"Sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");

// Exercise 3

Console.WriteLine("What is your current age?");
int ageToStore = int.Parse(Console.ReadLine());
Console.WriteLine($"Your age after 5 years is {ageToStore + 5}");

// Exercise 4
Console.Write("Input length: ");
double rectangleLength = double.Parse(Console.ReadLine());
Console.Write("Input width: ");
double rectangleWidth = double.Parse(Console.ReadLine());

Console.WriteLine($"Rectangle area: {rectangleLength * rectangleWidth}");


// Variables and conditions exercises

// Exercise 1
string name = "Kirill";
string surname = "Bravin";
int yearOfBirth = 1991;
int currentYear = 2024;

Console.WriteLine($"I am {name} {surname} I am {currentYear - yearOfBirth} years old.");

// Exercise 2

Random randomGenerator = new Random();

int firstRandomNumber = randomGenerator.Next(0, 5);
int secondRandomNumber = randomGenerator.Next(0, 5);

if (firstRandomNumber > secondRandomNumber && secondRandomNumber != 0)
{
    double result = firstRandomNumber / secondRandomNumber;
    Console.WriteLine(result);
}
else if (firstRandomNumber < secondRandomNumber && firstRandomNumber != 0)
{
    double result = secondRandomNumber / firstRandomNumber;
    Console.WriteLine(result);
}

// Exercise 3

int thirdRandomNumber = randomGenerator.Next(0, 26);
int fourthRandomNumber = randomGenerator.Next(0, 26);
int fifthRandomNumber = randomGenerator.Next(0, 26);

if (thirdRandomNumber > 0 || fourthRandomNumber > 0 || fifthRandomNumber > 0)
{
    int averageNumber = (thirdRandomNumber + fourthRandomNumber + fifthRandomNumber) / 3;
    Console.WriteLine($"The middle value is: {averageNumber}");
} else
{
    Console.WriteLine("All your numbers are 0, you can't divide on 0!");
}


// Exercise 4

int a = randomGenerator.Next(1, 11);
int b = randomGenerator.Next(1, 11);
int c = randomGenerator.Next(1, 11);

if (a + b > c || b + c > a || a + c > b)
{
    Console.WriteLine($"{a} {b} {c}");
    Console.WriteLine("Congratulations a triangle can be formed!");
} else Console.WriteLine("Triangle can't be formed");

// Exercise 5

int firstVar =  randomGenerator.Next(0, 3);
int secondVar = randomGenerator.Next(0, 3);
int thirdVar = randomGenerator.Next(0, 3);
int fourthVar = randomGenerator.Next(0, 3);

int countZeroes = 0;
int countOnes = 0;
int countTwos = 0;

if (firstVar == 0) countZeroes++;
else if (firstVar == 1) countOnes++;
else if (firstVar == 2) countTwos++;

if (secondVar == 0) countZeroes++;
else if (secondVar == 1) countOnes++;
else if (secondVar == 2) countTwos++;

if (thirdVar == 0) countZeroes++;
else if (thirdVar == 1) countOnes++;
else if (thirdVar == 2) countTwos++;

if (fourthVar == 0) countZeroes++;
else if (fourthVar == 1) countOnes++;
else if (fourthVar == 2) countTwos++;

Console.WriteLine($"Number of 0: {countZeroes}");
Console.WriteLine($"Number of 1: {countOnes}");
Console.WriteLine($"Number of 2: {countTwos}");

// Exercise 6

int sixthRandomNumber = randomGenerator.Next(-10, 11);
int seventhRandomNumber = randomGenerator.Next(-10, 11);
int eightRandomNumber = randomGenerator.Next(-10, 11);

string result0 = sixthRandomNumber > 0 ? "{}" : sixthRandomNumber == 0 ? "()" : sixthRandomNumber < 0 ? "[]" : "error";
string result1 = seventhRandomNumber > 0 ? "{}" : seventhRandomNumber == 0 ? "()" : seventhRandomNumber < 0 ? "[]" : "error";
string result2 = eightRandomNumber > 0 ? "{}" : eightRandomNumber == 0 ? "()" : eightRandomNumber < 0 ? "[]" : "error";

Console.WriteLine($"{result0}{result1}{result2}");

// Exercise 7

int candles = randomGenerator.Next(5, 3001);
int singleCandlePrice = 1;

double price;
int discount = 0;

if (candles >= 1000 && candles < 2000)
{
    price = Math.Round(candles * singleCandlePrice * (1 - 0.03), 2);
    discount = 3;
} else if (candles >= 2000)
{
    price = Math.Round(candles * singleCandlePrice * (1 - 0.04), 2);
    discount = 4;
} else
{
    price = candles * singleCandlePrice;
}

Console.WriteLine($"Candles: {candles} Price: {price} Discount: {discount}%");

// Exercise 8

int randomNumber0 = randomGenerator.Next(0, 101);
int randomNumber1 = randomGenerator.Next(0, 101);
int randomNumber2 = randomGenerator.Next(0, 101);

double firstArithmeticMean = (randomNumber0 + randomNumber1 + randomNumber2) / 3.0;
Console.WriteLine($"First arithmetic mean: {firstArithmeticMean}");

double secondArithmeticMean;

if (randomNumber0 < 10 || randomNumber0 > 90)
{
    randomNumber0 = 0;
}
if (randomNumber1 < 10 || randomNumber1 > 90)
{
    randomNumber1 = 0;
}
if (randomNumber2 < 10 || randomNumber2 > 90)
{
    randomNumber2 = 0;
}

secondArithmeticMean = (randomNumber0 + randomNumber1 + randomNumber2) / 3.0;

Console.WriteLine($"Second arithmetic mean: {secondArithmeticMean}");

Console.WriteLine($"First arithmetic mean as a whole number: {(int)firstArithmeticMean}");
Console.WriteLine($"Second arithmetic mean as a whole number: {(int)secondArithmeticMean}");

// Extra exercise 9

int hours = randomGenerator.Next(1, 25);
int minutes = randomGenerator.Next(0, 61);
int seconds = randomGenerator.Next(0, 61);
int clockNumber = randomGenerator.Next(0, 301);

Console.WriteLine($"Time is - {hours} hours {minutes} minutes {seconds} seconds");

while (clockNumber >= 60)
{
    seconds++;
    if (seconds >= 60)
    {
        seconds -= 60;
        minutes++;
    }
    if (minutes >= 60)
    {
        minutes -= 60;
        hours++;
    }
    if (hours >= 24) 
    {
        hours -= 24;
    }
    clockNumber -= 60;
}

Console.WriteLine($"New time is - {hours} hours {minutes} minutes {seconds} seconds");

// Average temperature exercise
Console.Write("Monday temperature: ");
int monday = int.Parse(Console.ReadLine());
Console.Write("Tuesday temperature: ");
int tuesday = int.Parse(Console.ReadLine());
Console.Write("Wednesday temperature: ");
int wednesday = int.Parse(Console.ReadLine());
Console.Write("Thursday temperature: ");
int thursday = int.Parse(Console.ReadLine());
Console.Write("Friday temperature: ");
int friday = int.Parse(Console.ReadLine());
Console.Write("Saturday temperature: ");
int saturday = int.Parse(Console.ReadLine());
Console.Write("Sunday temperature: ");
int sunday = int.Parse(Console.ReadLine());

Console.Write("Weekly average temperature is: ");
double avgTemp = (monday + tuesday + wednesday + thursday + friday + saturday + sunday) / 7;
Console.WriteLine(avgTemp);

// Calculating the price with VAT

Console.Write("Initial price: ");
double initialPrice = double.Parse(Console.ReadLine());
Console.Write("VAT percentage: ");
double vatPercentage = double.Parse(Console.ReadLine());
double vatAmount = initialPrice * (vatPercentage / 100);
double totalPrice = initialPrice + vatAmount;

Console.WriteLine($"Your price with VAT: {totalPrice}");

// BMI calculator

Console.Write("Enter your weight: ");
double weight = double.Parse(Console.ReadLine());
Console.Write("Enter your height: ");
double height = double.Parse(Console.ReadLine());

double bmi = weight / (height * height);
Console.Write($"Your BMI is: {bmi}");