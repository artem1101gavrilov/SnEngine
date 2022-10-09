namespace SNEngine
{
    [System.Serializable]
    public class SNEngineNullReferenceException : System.Exception
    {
        public SNEngineNullReferenceException() { }
        public SNEngineNullReferenceException(string message) : base(message) { }
        public SNEngineNullReferenceException(string message, System.Exception inner) : base(message, inner) { }
        protected SNEngineNullReferenceException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}