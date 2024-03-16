# Day 3

## Simple Console App (Banking System)

```c#
namespace Day1
{
    class BankAccount
    {
        public string accountHolder { get; set; }
        public double balance { get; set; }
        public void depositAmount(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited Amount is ${amount}. New balance ${balance}");
            }
        }

        public void withdrawAmount(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                System.Console.WriteLine($"Withdrawn P{amount}. New balance P{balance}");
            }
            else
            {
                System.Console.WriteLine("Insufficient Balance");
            }
        }

        public void checkBalance()
        {
            System.Console.WriteLine($"{accountHolder}'s Balance is: P{balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBank = new BankAccount();
            while (true)
            {
                System.Console.WriteLine("Welcome to Poor Bank");
                System.Console.WriteLine("1. Deposit\n2. Withdraw\n3. Check Balance\n4. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            System.Console.WriteLine("Enter Deposit");
                            if (double.TryParse(Console.ReadLine(), out double depositAmount))
                            {
                                myBank.depositAmount(depositAmount);
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid Input, Please enter a valid amount");
                            }
                            break;
                        case 2: Console.WriteLine("Enter Withdrawal Amount");
                            if(double.TryParse(Console.ReadLine(), out double withdrawalAmount)){
                                myBank.withdrawAmount(withdrawalAmount);
                            }
                            break;
                        case 3: 
                            myBank.checkBalance();
                            break;
                        case 4: 
                            Environment.Exit(0);
                            break;
                        default: 
                            System.Console.WriteLine("Enter 1 to 4 only");
                            break;
                    }
                }else{
                    System.Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
```

## Simple Console App (POS)

```c#
using System.Collections;

namespace Day1
{
    class Product()
    {

        public int Price { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }


    }

    class POS
    {
        List<Product> products = new List<Product>();
        public void addProduct(string product, int Price){
            
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("1. Add Product\n 2. Cashier");
                if (
                    int.TryParse(Console.ReadLine(), out int choice)
                )
                {
                    switch (choice)
                    {
                        case 1:

                            break;
                    }
                }
            }

        }
    }
}
```

## String Functions

```c#
// 1. Concat
string lastName = "Raymart";
string firstName = "Salvador";
string fullName = string.Concat(lastName, " ", firstName);

System.Console.WriteLine("Concat Example: {0}", fullName);

//2. Length

string greeting = "Hello Mina";
int stringLength = greeting.Length;
System.Console.WriteLine("Sample Length {0}", stringLength);

// 3. Substring

string message = "This is a sample message";
string subMessage = message.Substring(5, 10);
System.Console.WriteLine("substring {0}", subMessage);

// 4. ToUpper and ToLower
string stringCase = "Hello Mina";
string upperText = stringCase.ToUpper();
string lowerText = stringCase.ToLower();
System.Console.WriteLine("This is an uppercase text {0}:", upperText);
System.Console.WriteLine("This is an lowercase text {0}:", lowerText);

//5. Trim

string userName = "Raymart ";
string trimmedUsername = userName.Trim();
System.Console.WriteLine("Trimmed Username {0}, Previous username length{1}", trimmedUsername.Length, userName.Length);

// 6. Replace
string sentenceStr = "c# is awesome";
string sentencModified = sentenceStr.Replace("c#", "Java");
System.Console.WriteLine(sentencModified);

// 7. Split
string names = "Mark,John,Paul";
string[] nameArray = names.Split(',');
foreach (string arr in nameArray)
{
    System.Console.WriteLine(arr);
}

//8. Join

string[] fruits = { "orange", "mango", "apple" };
string joinedFruits = string.Join(",", fruits);
System.Console.WriteLine(joinedFruits);

// 9. Index

string sentence = "c# is something to be learned";

int index = sentence.IndexOf("is");
System.Console.WriteLine(index + sentence.Contains('i').ToString());
```
## Math Functions

```c#
//Math Functions
// 1. Abs
int num = -15;
int absoluteValue = Math.Abs(num);
System.Console.WriteLine(absoluteValue);

// 2.Power
double baseNumber = 2;
double exponent = 4;
double resultPower = Math.Pow(baseNumber, exponent);
System.Console.WriteLine(resultPower);

// 3. Square Root
double number= 16;
double squareRoot = Math.Sqrt(number);
System.Console.WriteLine(squareRoot);

//4. Ceiling and Floor. Converts decimal values to nearest integer
double decimalNumber = 4.2;
double Ceiling = Math.Ceiling(decimalNumber);
System.Console.WriteLine(Ceiling);

double Floor = Math.Floor(decimalNumber);
System.Console.WriteLine(Floor);

//5. round
double pi = 3.14159;
double round = Math.Round(pi);
System.Console.WriteLine(round);

//Max and Min
int c = 90;
int d = 45;
int minValue = Math.Min(c, d);
int maxValue = Math.Max(c, d);
System.Console.WriteLine("Min {0}, Max {1}", minValue, maxValue);
```

## Exceptions

```c#
using System.Linq.Expressions;

try
{
    System.Console.WriteLine("Enter student number");
    int studentNumber = Convert.ToInt32(Console.ReadLine());
}
catch(Exception sampleErr)
{
    System.Console.WriteLine($"Exception caught: {sampleErr}" );
}
finally
{
    System.Console.WriteLine("This will always execute");
}
```
## OOP (Object Oriented Programming)

Value Parameters
```c#
//value Parameters
namespace Day1
{
    //value Parameters
    class Student
    {
        public void DisplayStudentNumber(int studentNumber)
        {
            System.Console.WriteLine("The Student Number is {0}", studentNumber);
        }
    }

    //method overload
    class MathRM
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }


    class Program
    {
        //reference Parameters
        public static void IncrementNumber(ref int num)
        {
            num++;
        }
        //Output Parameters
        public static void GetSumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
        //params parameter
        public static int GetSum(params int[] number)
        {
            int sum = 0;
            foreach (int num in number)
            {
                sum += num;
            }
            return sum;
        }

        //optional Parameters

        public static void GreetSomeone(string name, string greeting = "hello")
        {
            System.Console.WriteLine("{0}, {1}", name, greeting);
        }

        public static void Main(string[] args)
        {
            MathRM myMath = new();
            myMath.Add(1.2, 1.3);
            Student myStudent = new Student();
            myStudent.DisplayStudentNumber(10009);

            int value = 14;
            IncrementNumber(ref value);

            int sum, product;
            GetSumAndProduct(3, 4, out sum, out product);
            System.Console.WriteLine("sum {0}, and Product {1}", sum, product);

            System.Console.WriteLine(GetSum(1, 2, 3, 4));

            GreetSomeone("World");
        }
    }
}
```
