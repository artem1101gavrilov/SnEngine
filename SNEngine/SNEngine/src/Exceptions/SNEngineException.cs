namespace SNEngine
{
    [System.Serializable]
    public class SNEngineException : System.Exception
    {
        public SNEngineException() { }
        public SNEngineException(string message) : base(message) { }
        public SNEngineException(string message, System.Exception inner) : base(message, inner) { }
        protected SNEngineException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}