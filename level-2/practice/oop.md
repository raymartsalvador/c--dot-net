# OOP

```csharp
using System.Runtime.InteropServices;

internal class Program
{

    /*
     * Portfolio
     * Abstraction
     *
     */


    public class User
    {
        private string name;
        private string password;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
    }

    private static void Main(string[] args)
    {
        User user = new User();

        user.Name = "Raymart Salvador";
        Console.WriteLine(user.Name);

        user.Password = "password";
        Console.WriteLine(user.Password);

    }
}

```

```csharp
using System.Runtime.InteropServices;

internal class Program
{

    /*
     * Portfolio
     * Abstraction
     *
     */


    public class User
    {
        private string name;
        private string password;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
    }

    private static void Main(string[] args)
    {
        User user = new User();

        user.Name = "Raymart Salvador";
        Console.WriteLine(user.Name);

        user.Password = "password";
        Console.WriteLine(user.Password);

    }
}
        
```

```csharp
using System.Runtime.InteropServices;

internal class Program
{

    /*
     * Portfolio
     * Abstraction
     *
     */

    //base class
    public class Animal
    {
        public string name;


        public void displayAnimal()
        {
            Console.WriteLine("I am an animal") ;
        }
    }
    //derrived class
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My Name is {0}", name);

        }
    }

    private static void Main(string[] args)
    {

        Dog labrador = new Dog();

        labrador.name = "hulo";
        labrador.displayAnimal();
        labrador.getName();
    }
}
```

```csharp
using System.Runtime.InteropServices;

internal class Program
{

    /*
     * Portfolio
     * Inheritance
     *
     */

    //base class
    public class Animal
    {
        public string name;


        public void displayAnimal()
        {
            Console.WriteLine("I am an animal") ;
        }
    }
    //derrived class
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My Name is {0}", name);

        }
    }

    private static void Main(string[] args)
    {

        Dog labrador = new Dog();

        labrador.name = "hulo";
        labrador.displayAnimal();
        labrador.getName();
    }
}
```

```csharp
    using System.Runtime.InteropServices;

internal class Program
{

    /*
     * Portfolio
     * polymorphism
     *
     */

    //base class
    public class CustomerInfo
    {


        public string Name(string singleName) {
            return singleName;
        }

        public string Name(string firstName, string secondName) {
            
            string fullName = firstName + " " + secondName;
            return fullName;
        }
    }
    //derrived class
   

    private static void Main(string[] args)
    {

        CustomerInfo customerInfo = new();

        Console.WriteLine(customerInfo.Name("Raymart"));
        Console.WriteLine(customerInfo.Name("Raymart", "Salvador"));

    }
}
