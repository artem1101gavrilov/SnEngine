namespace SNEngine;

[Serializable]
public class SNEngineNullReferenceException : Exception
{
    public SNEngineNullReferenceException() { }
    public SNEngineNullReferenceException(string message) : base(message) { }
    public SNEngineNullReferenceException(string message, Exception inner) : base(message, inner) { }
    protected SNEngineNullReferenceException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}