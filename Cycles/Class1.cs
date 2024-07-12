namespace Cycles
{
    public class CyclesApp
    {
        public void Run()
        {
            // I believe this was beginner practice on cycles. I won't change code much, I'll just add translations.

            string input;
            bool proceed = true;
            while (proceed)
            {
                // Translation: Input
                Console.WriteLine("Zadej:");
                input = Console.ReadLine()!;
                if (input != "exit")
                {
                    Console.WriteLine(input);
                    // Tady bude většina program
                    // Translation: Here will be most of the code.
                }
                else
                {
                    proceed = false;
                }
            }

            int a = 5;
            int b = 10;
            while (a < b)
            {
                Console.WriteLine(a);
                //a = a + 1;
                a += 1;
                //a++;

            }
            for (int i = 9; i > 5; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}