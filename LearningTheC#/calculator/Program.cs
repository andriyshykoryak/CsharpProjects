namespace calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            int n1 = int.Parse(Console.ReadLine());

            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the action");
            string action = Console.ReadLine();


            switch (action) {
                case  "+":
                    Console.WriteLine(n1 + n2);
                    break;
                case "-":
                    Console.WriteLine(n1 - n2);
                    break;
                 case "*":
                    Console.WriteLine(n1 * n2);
                break;
                case "/":   

                    Console.WriteLine(n1 / n2);
                    break;
                default: Console.WriteLine("Please enter the correct action");
                    break;

            
            }


        }
    }
}