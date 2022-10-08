namespace SNEngine
{
    public struct ResourceInfo
    {
        public string key;

        public string path;

        public ResourceType type;

        public ResourceInfo(string key, string path, ResourceType type)
        {
            this.key = key;
            this.path = path;
            this.type = type;
        }


    }
}