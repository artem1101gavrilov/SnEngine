using System.Diagnostics;
using System.Security.Cryptography;
using SFML.Graphics;

namespace SNEngine
{
    public static class GameResources
    {

        private static bool _isLoadContent = false;

        private static string _rootDirectory = "/SNE_Data/";

        private static string[] _defaultPaths = new string[] 
        {
            "images",
            "fonts",
            "UI",
            "audio",
        };

        private static Dictionary<string, ResourceInfo> _paths;

        private static Dictionary<string, Texture> _texturesCache;

        public static string RootDirectory => _rootDirectory;

        public static bool IsLoadContent => _isLoadContent;

        public static void Initialize()
        {

            _rootDirectory = AppDomain.CurrentDomain.BaseDirectory + _rootDirectory;

            Debug.Log($"Root directory a game at {_rootDirectory}");


            bool firstStart = !Directory.Exists(_rootDirectory);


           if (firstStart) 
           {
                Directory.CreateDirectory(_rootDirectory);

                Debug.LogAction("folber of data engine created");
           }


            _paths = new Dictionary<string, ResourceInfo>();

            for (int i = 0; i < _defaultPaths.Length; i++)
            {
                string path = _defaultPaths[i];

                string fullPath = GetFulPathToFolber(path);

                if (!Directory.Exists(fullPath)) 
                {
                       Directory.CreateDirectory(fullPath);

                       Debug.Log($"created of new directory for resources Path {fullPath} ");


                }
            }

                if (firstStart) 
                {
                 Debug.LogSpecial("This project as running at first time. Closing. You should to add content on a folbers on SNE_Data folber. You can restart the application to continue working", ConsoleColor.Cyan);

                Environment.Exit(1);

                  
                }

            for (int i = 0; i < _defaultPaths.Length; i++)
            {
                string path = _defaultPaths[i];

                string fullPath = GetFulPathToFolber(path);

                if (!Directory.Exists(fullPath)) 
                {
                       Directory.CreateDirectory(fullPath);

                       Debug.Log($"created of new directory for resources Path {fullPath} ");


                }


                ResourceType resourceType = default;

                switch (i)
                {
                    case 0:

                    resourceType = ResourceType.Image;

                    break;

                    case 1:

                    resourceType = ResourceType.Font;

                    break;

                    case 2:

                    resourceType = ResourceType.Image;

                    break;

                    case 3:

                    resourceType = ResourceType.Audio;

                    break;
                    
                    default:

                    throw new SNEngineException($"underfined resource of index {i} in _defaultPaths array strings");
                }

                ResourceInfo resource = new ResourceInfo(path, path + "/", resourceType);

                AddNewPathResources(resource);
            }


        }

        public static void LoadContent () 
        {



            if (_isLoadContent)
            {
                Debug.LogError("content of the game as loaded before");

                return;
            }
             _texturesCache = new Dictionary<string, Texture>();

             var folberTextures = GetFulPathToFolber(_paths.Single(x => x.Value.key == "images").Value.path);

              

             _isLoadContent = true;
        }

        public static void SetRootDirectory (string path) 
        {
            if (_isLoadContent) 
            {
                 Debug.LogError("you not set root directory because Initialize() as called last");

                 return;
            }

              _rootDirectory = path;
        }

        public static void AddNewPathResources (ResourceInfo resource) 
        {

            if (string.IsNullOrEmpty(resource.path)) 
            {
                  throw new SNEngineException("path of resources not be as empty!");
            }

            if (string.IsNullOrEmpty(resource.key)) 
            {
                  throw new SNEngineException("path of resources not be as empty!");
            }

            if (_paths.ContainsKey(resource.key)) 
            {
                throw new SNEngineException($"the path resources of key {resource.key} as used!");
            }

            _paths.Add(resource.key, resource);

            Debug.LogAction($"added new path of resources: Key: {resource.key} Path: {resource.path}");

            
        }

        private static string GetFulPathToFolber (string path) 
        {
              return $"{_rootDirectory}{path}";
        }




    }
}