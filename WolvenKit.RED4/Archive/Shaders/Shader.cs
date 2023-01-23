namespace WolvenKit.RED4.Archive.Shaders;

public class Shader
{
    public ulong GUID;
    public ulong ParamsGUID;
    public ParameterSet Parameters;
    public string FileName;
    public uint Size;
}

public class Extra
{
    public uint StartThing;
    public uint EndThing;
    public string ShaderInfo;
    public string TemplateName;
    public Shader PixelShader;
    public Shader VertexShader;
    public ulong MaterialGUID;
    public ulong uk1;
    public List<ulong> Flags1;
    public List<ulong> Flags2;
}

public class Parameter
{
    public string Name;
    public byte uk1;
    public byte uk2;
}

public class ParameterSet
{
    public ulong GUID;
    public uint uk1;
    public List<Parameter> Parameters;
}

public class ShaderMapping
{
    public uint EndThing;
    public uint ID;
    public uint Postfix;
}

public class Effect
{
    public string Name;
    public ulong GUID;
}