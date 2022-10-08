using SFML.Graphics;

namespace SNEngine
{
    public static class GameResources
    {

        private static bool _isLoadContent = false;

        private static string _rootDirectory = "./SNE_Data/";

        private static string[] _defaultPaths = new string[] 
        {
            "images",
            "fonts",
            "UI",
            "audio",
        };

        private static Dictionary<string, string> _paths;

        private static Dictionary<string, Texture> _texturesCache;

        public static string RootDirectory => _rootDirectory;

        public static bool IsLoadContent => _isLoadContent;

        public static void Initialize()
        {
            _paths = new Dictionary<string, string>();

            for (int i = 0; i < _defaultPaths.Length; i++)
            {
                string path = _defaultPaths[i];

                AddNewPathResources(path, path);


            }
        }

        public static void LoadContent () 
        {
             _texturesCache = new Dictionary<string, Texture>();
        }

        public static void SetRootDirectory (string path) 
        {
              _rootDirectory = path;
        }

        public static void AddNewPathResources (string key, string path) 
        {

            if (string.IsNullOrEmpty(path)) 
            {
                  throw new SNEngineException("path of resources not be as empty!");
            }

            if (string.IsNullOrEmpty(key)) 
            {
                  throw new SNEngineException("path of resources not be as empty!");
            }

            if (_paths.ContainsKey(key)) 
            {
                throw new SNEngineException($"the path resources of key {key} as used!");
            }

            if (_paths.Count(x => x.Value == path) > 1) 
            {
                throw new SNEngineException($"the value of resources path {path} as containts");
            }

            _paths.Add(key, _rootDirectory + path);

            Debug.Log($"added new path of resources: Key: {key} Path: {path}");
        }


    }
}