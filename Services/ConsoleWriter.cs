namespace DeliverySystem.Service
{
    public class ConsoleWriter
    {
        public void WriteLoginScreen()
        {
            int h = Console.WindowHeight;
            int w = Console.WindowWidth;

            
            
            Console.WriteLine(new string('—',w));

            for (int i = 1; i <= h-2; i ++)
            {
                Console.SetCursorPosition(0,i);
                Console.WriteLine("|");
            }


            for (int i = 1; i <= h-2; i ++)
            {
                Console.SetCursorPosition(w-1,i);
                Console.WriteLine("|");
            }

            Console.SetCursorPosition(0,h-1);
            Console.WriteLine(new string('—',w));

            Console.SetCursorPosition(w/2,h/2);

            Console.ReadLine();
            
        }
    }
}