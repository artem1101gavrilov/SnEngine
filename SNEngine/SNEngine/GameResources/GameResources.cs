namespace SNEngine
{
    public static class GameResources
    {

        private static string _rootDirectory = "SNE_Data";

        public static string RootDirectory => _rootDirectory;

        public static void SetRootDirectory (string path) 
        {
              _rootDirectory = path;
        }
    }
}