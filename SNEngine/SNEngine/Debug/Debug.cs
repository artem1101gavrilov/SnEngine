namespace SNEngine
{
    public static class Debug
    {
        public static void Log (string message)
        {
            SetColorConsole(ConsoleColor.Blue);

            Console.WriteLine($"[SNEngine Message]: {message}");

            ResetColor();
        }

        private static void ResetColor() =>  Console.ResetColor();

        private static void SetColorConsole(ConsoleColor color) =>  Console.ForegroundColor = color;

        public static void LogError (string message) 
        {
             SetColorConsole(ConsoleColor.Red);

             Console.WriteLine($"[SNEngine ERROR]: {message}");

              ResetColor();
        }

        public static void LogWarning (string message) 
        {
             SetColorConsole(ConsoleColor.Yellow);

             Console.WriteLine($"[SNEngine Warning]: {message}");
             
              ResetColor();
        }
        public static void LogAction (string message) 
        {
             SetColorConsole(ConsoleColor.Green);

             Console.WriteLine($"[SNEngine Action]: {message}");

              ResetColor();
        }

        public static void LogSpecial (string message, ConsoleColor color) 
        {
             SetColorConsole(color);

             Console.WriteLine($"[SNEngine Special Event]: {message}");

              ResetColor();
        }

        
    }
}