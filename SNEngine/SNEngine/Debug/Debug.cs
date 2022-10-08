namespace SNEngine
{
    public static class Debug
    {
        public static void Log (string message)
        {
            #if DEBUG
            SetColorConsole(ConsoleColor.Blue);

            Console.WriteLine($"[SNEngine Message]: {message}");

            ResetColor();
            #endif
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
            #if DEBUG
             SetColorConsole(ConsoleColor.Yellow);

             Console.WriteLine($"[SNEngine Warning]: {message}");
             
              ResetColor();

              #endif
        }
        public static void LogAction (string message) 
        {
            #if DEBUG
             SetColorConsole(ConsoleColor.Green);

             Console.WriteLine($"[SNEngine Action]: {message}");

              ResetColor();

            #endif
        }

        public static void LogSpecial (string message, ConsoleColor color) 
        {
            #if DEBUG
             SetColorConsole(color);

             Console.WriteLine($"[SNEngine Special Event]: {message}");

              ResetColor();

              #endif
        }

        
    }
}
