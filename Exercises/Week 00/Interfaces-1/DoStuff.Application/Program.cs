namespace DoStuff.Application
{
    class program
    {
        // Version 1
        /* 
        static void Main()
        {
            IDoThings myIDoThings = new DoHickey();
                    

            myIDoThings.DoNothing();
            myIDoThings.DoSomething(10);
            myIDoThings.DoSomethingElse("Hello World");
        }
       */
        // Version 2
        static void Main()
        {
            IDoThings? myIDoThings;

            do {
                // Ask the user which instance they want to create
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Which object do you want to create? Enter 'Hickey' or 'Dickey':");
                Console.ResetColor();
                // Trim removes white space before and after input string
                string? choice = Console.ReadLine()?.Trim().ToLower();


                // Create object based input
                if (choice == "hickey")
                {
                    myIDoThings = new DoHickey();
                }
                else if (choice == "dickey")
                {
                    myIDoThings = new DoDickey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice");
                    Console.ResetColor();
                    myIDoThings = null;
                }

                if (myIDoThings != null)
                {
                    myIDoThings.DoNothing();
                    int number = myIDoThings.DoSomething(10);
                    string input = myIDoThings.DoSomethingElse("Hello World");

                    Console.WriteLine($"Number: {number}, Input: {input}");
                }
            } while(true); 
        }
    }
}