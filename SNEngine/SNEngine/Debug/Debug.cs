namespace SNEngine
{
    public static class Debug
    {
        public static void Log (object message)
        {
            #if DEBUG
            SetColorConsole(ConsoleColor.Blue);

            Console.WriteLine($"[SNEngine Message]: {message.ToString()}");

            ResetColor();
            #endif
        }

        private static void ResetColor() =>  Console.ResetColor();

        private static void SetColorConsole(ConsoleColor color) =>  Console.ForegroundColor = color;

        public static void LogError (object message) 
        {
             SetColorConsole(ConsoleColor.Red);

             Console.WriteLine($"[SNEngine ERROR]: {message.ToString()}");

              ResetColor();

        }

        public static void LogWarning (object message) 
        {
            #if DEBUG
             SetColorConsole(ConsoleColor.Yellow);

             Console.WriteLine($"[SNEngine Warning]: {message.ToString()}");
             
              ResetColor();

              #endif
        }
        public static void LogAction (object message) 
        {
            #if DEBUG
             SetColorConsole(ConsoleColor.Green);

             Console.WriteLine($"[SNEngine Action]: {message.ToString()}");

              ResetColor();

            #endif
        }

        public static void LogSpecial (object message, ConsoleColor color) 
        {
            #if DEBUG
             SetColorConsole(color);

             Console.WriteLine($"[SNEngine Special Event]: {message.ToString()}");

              ResetColor();

              #endif
        }

        
    }
}
