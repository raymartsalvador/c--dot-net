# C# Level 2 Day 1


## Practice: Expense Tracker

```csharp
namespace aware_expense_tracker
{
    internal class Program
    {
        struct Expenses
        {
        
            public string title; public double amount;

        }

        struct Income { 
            public string title; public double amount;
        }



        static void Main(string[] args)
        {
            int capacity = 1000;
            Expenses[] expenses = new Expenses[capacity];
            Income[] income = new Income[capacity];
            double balance = 0;
            bool repeat = true;
            int choice;
            int expensesNum = 0;
            int incomeNum = 0;
            do
            {
                Console.WriteLine("1 - Enter New Expenses");
                Console.WriteLine("2 - Enter new Income");
                Console.WriteLine("3 - Display All");
                Console.WriteLine("4 - Delete Expense");
                Console.WriteLine("5 - Delete Income");
                Console.WriteLine("0 - Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (choice)
                    {

                        case 1: // Enter new Expense
                            if (expensesNum < capacity)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter Expense Title: ");
                                expenses[expensesNum].title = Console.ReadLine();
                                Console.WriteLine("Enter Expense amount");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                expenses[expensesNum].amount = amount;
                                balance -= amount;
                                expensesNum++;
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Limit has been reached");
                                Console.ResetColor();
                            }

                            break;

                        case 2: //Enter Income
                            if (incomeNum < capacity)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter Income Title: ");
                                income[incomeNum].title = Console.ReadLine();
                                Console.WriteLine("Enter Income Amount: ");
                                double amount= Convert.ToDouble(Console.ReadLine());
                                income[incomeNum].amount = amount;
                                balance += amount;
                                incomeNum++;
                                Console.ResetColor();

                            }
                            else
                            {
                                Console.WriteLine("Number of income reached Limit. The Limit is {0}", capacity);
                            }
                            break;

                        case 3: //Display All


                            Console.WriteLine("Your Balance is: {0}", balance);

                            if (expensesNum < 1)
                            {
                                Console.WriteLine("There is no expenses");
                            }
                            else
                            {
                                Console.WriteLine("Expenses: ");
                                for (int i = 0; i < expensesNum; i++) { 
                                    Console.WriteLine("{0} {1} : {2}",i+1, expenses[i].title, expenses[i].amount );
                                }
                            }


                            if (incomeNum < 1)
                            {
                                Console.WriteLine("There is no income");
                            }
                            else
                            {
                                Console.WriteLine("Income: ");
                                for (int i = 0; i < incomeNum; i++) { 
                                    Console.WriteLine("{0} {1} : {2}",i+1, income[i].title, income[i].amount );
                                }
                            }
                            break;
                        case 4:
                            if (expensesNum<1)
                            {
                                Console.WriteLine("No expense to delete");
                            } else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter the number of expense to delete (1 to {0})", expensesNum);
                                int postDelete = Convert.ToInt32(Console.ReadLine()) - 1;
                                for (int deleteExpense = postDelete; deleteExpense < expensesNum - 1; deleteExpense++)
                                    expenses[deleteExpense] = expenses[deleteExpense + 1];
                                expensesNum--;
                                Console.ResetColor();

                            }
                            break;
                    };
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                }

            } while (repeat);

        }
    }
}
```

```csharp
using System.Runtime.InteropServices;

internal class Program
{

    /*
     *GG Simple Library
     * Add
     * Search - Partial and exact
     * Delete
     * 
     */

    struct book
    {
        public string title;
        public string author;
    }

    private static void Main(string[] args)
    {
        int capacity = 10;
        book[] books = new book[capacity];
        bool repeat = true;
        int option;
        int amount = 0;
        string search;
        bool found;

        do
        {
            Console.WriteLine("\n **** Welcome Our Library **** \n");
            Console.WriteLine("1 - Add a new Book");
            Console.WriteLine("2 - Display Books");
            Console.WriteLine("3 - Search for any books");
            Console.WriteLine("4 - Partial Search");
            Console.WriteLine("5 - Delete Books");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("Enter an option");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
                
            {
                case  1: //add new book
                    if (amount < capacity)
                    {
                        Console.WriteLine("Enter data for book{0}", amount + 1);
                        Console.WriteLine("Enter the Name of the book");
                        books[amount].title = Console.ReadLine();
                        Console.WriteLine("Enter the author name");
                        books[amount].author = Console.ReadLine();
                        amount++;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Books are full");
                        Console.WriteLine();
                        Console.ResetColor();

                    }
                    break;
                case 2:
                    if (amount == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("No Books Found");
                    }
                    else
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0}: Title: {1}, Author: {2}", i + 1, books[i].title, books[i].author);
                            Console.ResetColor();
                        }
                    }
                    break;
                case 3:
                    //Exact Search
                    Console.WriteLine("Exter Exact Name of the Book: ");
                    search = Console.ReadLine();
                    found = false;

                    for (int searchI = 0; searchI < amount; searchI++)
                        if (books[searchI].title == search)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0}Books Found in {1}", searchI, books[searchI].title);
                            Console.ResetColor();
                            found = true;
                        }
                    if (!found)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Books Not found");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    break;
                case 4: //Partial Search
                    Console.WriteLine("Enter the search string");
                    search = Console.ReadLine();
                    found = false;
                    for (int partialSearch = 0; partialSearch < amount; partialSearch++)
                        if (books[partialSearch].title.ToUpper().Contains(search.ToUpper()) ||
                            books[partialSearch].author.ToUpper().Contains(search.ToUpper()))
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} found in {1}", search, books[partialSearch].title);
                            Console.ResetColor();
                            found = true;
                        }
                    Console.WriteLine();
                    if (!found)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Books Not found");
                        Console.ResetColor();
                    }
                    break;


                case 5: //delete record
                    if (amount == 0) { 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No Books Found");
                    
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter the number of book to delete 1 to {0}", amount);
                        int numberOfBooks = Convert.ToInt32(Console.ReadLine()) - 1;
                        for (int deleteBook = numberOfBooks; deleteBook < amount - 1; deleteBook++)
                            books[deleteBook] = books[deleteBook + 1];
                        amount--;
                        Console.ResetColor();
                    }
                    break;

                case 0:
                    repeat = false;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ResetColor();
                    break;
            }

        } while (repeat);

    }
}
```