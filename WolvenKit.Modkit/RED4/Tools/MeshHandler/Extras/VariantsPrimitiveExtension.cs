using System;
using System.Collections.Generic;
using System.Text.Json;
using SharpGLTF.Schema2;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

internal class VariantsPrimitiveEntry : ExtraProperties
{
    private Int32 _material;
    private List<Int32> _variants = new();

    internal VariantsPrimitiveEntry() { }

    public Int32 Material
    {
        get => _material;
        set => _material = value;
    }

    public List<Int32> Variants
    {
        get => _variants;
        set => _variants = value;
    }

    protected override void SerializeProperties(Utf8JsonWriter writer)
    {
        base.SerializeProperties(writer);
        SerializeProperty(writer, "material", _material);
        SerializeProperty(writer, "variants", _variants);
    }

    protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
    {
        switch (jsonPropertyName)
        {
            case "material":
                _material = DeserializePropertyValue<Int32>(ref reader);
                break;
            case "variants":
                DeserializePropertyList(ref reader, _variants);
                break;
            default:
                base.DeserializeProperty(jsonPropertyName, ref reader);
                break;
        }
    }
}

internal class VariantsPrimitiveExtension : ExtraProperties
{
    private readonly MeshPrimitive _parent;

    private List<VariantsPrimitiveEntry> _mappings = new();

    internal VariantsPrimitiveExtension(MeshPrimitive parent)
    {
        _parent = parent;
    }

    public List<VariantsPrimitiveEntry> Mappings
    {
        get => _mappings;
        set => _mappings = value;
    }

    protected override void SerializeProperties(Utf8JsonWriter writer)
    {
        base.SerializeProperties(writer);
        SerializeProperty(writer, "mappings", _mappings);
    }

    protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
    {
        switch (jsonPropertyName)
        {
            case "mappings":
                DeserializePropertyList(ref reader, _mappings);
                break;
            default:
                base.DeserializeProperty(jsonPropertyName, ref reader);
                break;
        }
    }
}
