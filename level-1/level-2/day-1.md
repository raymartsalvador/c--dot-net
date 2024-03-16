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