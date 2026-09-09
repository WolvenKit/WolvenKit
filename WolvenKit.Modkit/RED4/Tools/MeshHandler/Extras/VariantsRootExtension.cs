using System.Collections.Generic;
using System.Text.Json;
using SharpGLTF.Schema2;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;


internal class VariantsRootEntry : ExtraProperties
{
    private string _name = null!;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public List<string> Materials { get; set; } = new();

    protected override void SerializeProperties(Utf8JsonWriter writer)
    {
        base.SerializeProperties(writer);
        SerializeProperty(writer, "name", _name);
    }

    protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
    {
        switch (jsonPropertyName)
        {
            case "name":
                _name = DeserializePropertyValue<string>(ref reader);
                break;
            default:
                base.DeserializeProperty(jsonPropertyName, ref reader);
                break;
        }
    }
}

internal class VariantsRootExtension : ExtraProperties
{
    private List<VariantsRootEntry> _variants = new();

    internal VariantsRootExtension(ModelRoot parent) { }

    public List<VariantsRootEntry> Variants
    {
        get => _variants;
        set => _variants = value;
    }

    protected override void SerializeProperties(Utf8JsonWriter writer)
    {
        base.SerializeProperties(writer);
        SerializeProperty(writer, "variants", _variants);
    }

    protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
    {
        switch (jsonPropertyName)
        {
            case "variants":
                DeserializePropertyList(ref reader, _variants);
                break;
            default:
                base.DeserializeProperty(jsonPropertyName, ref reader);
                break;
        }
    }
}
