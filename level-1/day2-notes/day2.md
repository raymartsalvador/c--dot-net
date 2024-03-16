# Intro to C# (Continuation)

> Console.Readline() is used to read input from user.

## Swtich Statement (Practice)

```c#
//Console.Readline(); is used to read the input from the user

string studentName;
double quiz1, quiz2, quiz3, quizGrade;
double recitation;
double lab1, lab2, labGrade;
double classStanding;
double majorExam;
double finalGrade = 0;

Console.WriteLine("Enter student name: ");
studentName = Console.ReadLine() ?? "";

Console.WriteLine("Enter the grade for Quiz 2: ");
quiz1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the grade for Quiz 2: ");
quiz2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the grade for Quiz 3: ");
quiz3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the grade for Recitation: ");
recitation = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the grade for Lab1: ");
lab1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the grade for Lab2: ");
lab2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the grade for MajorExam: ");
majorExam = Convert.ToDouble(Console.ReadLine());



// quiz1 = 86.15;
// quiz2 = 87.00;
// quiz3 = 75.29;

// recitation = 78.00;

// lab1 = 92.14;
// lab2 = 87.15;

// majorExam = 87.65;




quizGrade = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
recitation = recitation * 0.15;
labGrade = (lab1 + lab2) / 2 * 0.25;
majorExam = majorExam * 0.35;

classStanding = quizGrade + recitation + labGrade + majorExam;
System.Console.WriteLine("Name: " + studentName);
Console.WriteLine("semestral grade: " + classStanding);
/*
Criteria:
1.0 = (98-100)
1.25 = (97-95)
1.5 = (94-90)
1.75 = (89-86)
2.0 =  (85-83)
2.25 = (82-80)
2.50 = (79-78)
2.75 = (77-76)
3.0 = (75)
5.0 = (74-0)
*/

switch (classStanding)
{
    case >= 98 and <= 100:
        finalGrade = 1.00;
        break;
    case >= 95 and <= 97:
        finalGrade = 1.25;
        break;
    case >= 90 and <= 94:
        finalGrade = 1.50;
        break;
    case >= 86 and <= 89:
        finalGrade = 1.75;
        break;
    case >= 83 and <= 85:
        finalGrade = 2.00;
        break;
    case >= 80 and <= 82:
        finalGrade = 2.25;
        break;
    case >= 76 and <= 77:
        finalGrade = 2.50;
        break;
    case >= 78 and <= 79:
        finalGrade = 2.75;
        break;
    case 75:
        finalGrade = 3.0;
        break;
    case > 75:
        finalGrade = 5.0;
        break;
    default:
        break;
}

Math.Round(finalGrade);
Console.WriteLine("Final Grade: " + finalGrade);
```

## Loops
>
> Loops are used to execute a block of code multiple times.

### While Loop

```c#
int y = 0;

while (y < 5>){
    Console.WriteLine(y);
    y++;
}
```

### Do While Loop

> The do while loop is similar to the while loop, but the condition is checked after the block of code is executed.

```c#
int x = 0;
do {
    Console.WriteLine(x);
    x++;
} while (x < 5);
```

### For Loop
>
> The for loop is used to execute a block of code a specified number of times.

```c#
for (int i = 0; i < 5; i++){
    Console.WriteLine(i);
}
```

#### Practice Problem
>
>Multiplication Table

```c#
int multiplicand;
System.Console.WriteLine("Welcome to multiplication table");


multiplicand = int.Parse(Console.ReadLine());
int i, j;
for (i = 1; i <= multiplicand; i++)
{
    for (j = 1; j <= multiplicand; j++)
    {
        int product = i * j;
        Console.Write(" |"+product+"| ");
    }
    Console.WriteLine("\n");
}
```

### Foreach Loop
>
> The foreach loop is used to iterate through a collection of items such as an array or list.

```c#
string[] names = {"John", "Jane", "Jim", "Jill"};

foreach (string name in names){
    Console.WriteLine(name);
}
```

#### Break and Continue
>
> The break statement is used to exit a loop, while the continue statement is used to skip the current iteration and continue with the next iteration.

```c#
for (int i = 0; i < 10; i++){
    if (i == 5){
        break;
    }
    Console.WriteLine(i);
}
```

```c#
for (int i = 0; i < 10; i++){
    if (i == 5){
        continue;
    }
    Console.WriteLine(i);
}
```

## Date and Time

> DateTime is a struct to work with dates and times.

```c#
// assigns default value of 01/01/001 00:00:00
DateTime dt1 = new();

// assign year, month, day
DateTime dt2 = new(2000, 6, 13);

// assign year, month, day, hours, minutes, seconds
DateTime dt3 = new(2000, 6, 13, 12, 31, 31);

// assign year, month, day, hours, minutes, seconds, utc timezone
DateTime dt4 = new(2000, 6, 13, 12, 31, 31, DateTimeKind.Utc);

System.Console.WriteLine(dt1);
System.Console.WriteLine(dt2);
System.Console.WriteLine(dt3);
System.Console.WriteLine(dt4);
```

### TimeSpan
>
> TimeSpan is a struct to work with time intervals.

```c#
DateTime dpSpan = new DateTime(2024, 03, 03);
TimeSpan ts = new TimeSpan(25, 20, 55);

DateOnly newDate = DateOnly.FromDateTime(dpSpan.Add(ts));
System.Console.WriteLine(newDate);

//subtract 2 dates
DateTime dtborrow = new DateTime(2024, 03, 03);
DateTime dtreturn = new DateTime(2024, 04, 03);
TimeSpan results = dtreturn.Subtract(dtborrow);
System.Console.WriteLine(results);
```

## Arrays
>
> An array is a collection of items stored at contiguous memory locations.

### Declare an array

```c#
int[] arr;
```

### Allocate memory for array

```c#
arr = new int[5];
```

### Access & modify array elements

```c#
int[] GGAge = {12, 6, 8, 11};
System.Console.WriteLine(GGAge[0]);
GGAge[3] = (int)Convert.ToInt64(Console.ReadLine());
System.Console.WriteLine(GGAge[3]);
```

## Lists
>
> A list is a collection of items that can grow or shrink in size.
>

```c#
List<int> listProductID = new List<int>();

listProductID.Add(1561); 
listProductID.Add(2020); 
listProductID.Add(2056); 
listProductID.Add(3456); 

System.Console.WriteLine("using for loop");
for(int i = 0; i< listProductID.Count; i++){
    System.Console.WriteLine(listProductID[i]);
}
System.Console.WriteLine("using for each loop");
foreach(int productId in listProductID)
{
    Console.WriteLine(productId);
}
System.Console.WriteLine("using method");
listProductID.ForEach(Console.WriteLine);
```
```c#
List<string> productName = new List<string>();
productName = ["bike", "shoes", "bag"];
productName.ForEach(Console.WriteLine);
```
## Foreign Terms

- struct - a value type that is typically used to encapsulate small groups of related variables.
