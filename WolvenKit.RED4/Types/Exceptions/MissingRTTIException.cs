namespace WolvenKit.RED4.Types.Exceptions;

public class MissingRTTIException : Exception
{
    public MissingRTTIException(string varname, string vartype, string parenttype) : base($"Missing in wolven rtti: ({vartype}){varname} in {parenttype}")
    {
    }
}

public class InvalidRTTIException : Exception
{
    public InvalidRTTIException(string propName, Type expectedType, Type actualType) : base($"Invalid in wolven rtti:\"{propName}\" [Expected: \"{expectedType.Name}\" | Got: \"{actualType.Name}\"]")
    {
    }
}