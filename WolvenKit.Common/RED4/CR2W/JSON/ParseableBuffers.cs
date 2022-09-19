#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public class ParseableBufferConverter : JsonConverter<IParseableBuffer>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IParseableBuffer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(worldNodeDataBuffer))
        {
            return JsonSerializer.Deserialize<worldNodeDataBuffer>(ref reader, options);
        }

        if (typeToConvert == typeof(RedPackage))
        {
            return JsonSerializer.Deserialize<RedPackage>(ref reader, options);
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }


        var result = System.Activator.CreateInstance(typeToConvert);
        
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return (IParseableBuffer?)result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            var property = typeToConvert.GetProperty(propertyName!);
            var value = JsonSerializer.Deserialize(ref reader, property!.PropertyType, options);
            property.SetValue(result, value);
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IParseableBuffer value, JsonSerializerOptions options)
    {
        if (value is worldNodeDataBuffer wndb)
        {
            JsonSerializer.Serialize(writer, wndb, options);
            return;
        }

        if (value is RedPackage rp)
        {
            JsonSerializer.Serialize(writer, rp, options);
            return;
        }

        writer.WriteStartObject();

        foreach (var propertyInfo in value.GetType().GetProperties())
        {
            if (propertyInfo.Name == "Data")
            {
                continue;
            }

            writer.WritePropertyName(propertyInfo.Name);
            JsonSerializer.Serialize(writer, propertyInfo.GetValue(value), options);
        }

        writer.WriteEndObject();
    }
}

public class CollisionShapeConverter : JsonConverter<CollisionShape>
{
    public override bool CanConvert(Type typeToConvert) => typeof(CollisionShape).IsAssignableFrom(typeToConvert);

    public override CollisionShape? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }
        reader.Read();

        var propertyName = reader.GetString();
        if (propertyName != "ShapeType")
        {
            throw new JsonException();
        }
        var shapeType = JsonSerializer.Deserialize<CEnum<Enums.physicsShapeType>>(ref reader, options);

        CollisionShape collisionShape;
        if (shapeType == Enums.physicsShapeType.ConvexMesh || shapeType == Enums.physicsShapeType.TriangleMesh)
        {
            collisionShape = new CollisionShapeMesh();
        }
        else
        {
            collisionShape = new CollisionShapeSimple();
        }
        collisionShape.ShapeType = shapeType;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return collisionShape;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            propertyName = reader.GetString();
            if (propertyName == null)
            {
                throw new JsonException();
            }

            var propertyInfo = collisionShape.GetType().GetProperty(propertyName)!;
            var value = JsonSerializer.Deserialize(ref reader, propertyInfo.PropertyType, options);
            propertyInfo.SetValue(collisionShape, value);
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, CollisionShape value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("ShapeType");
        JsonSerializer.Serialize(writer, value.ShapeType, options);

        foreach (var propertyInfo in value.GetType().GetProperties())
        {
            if (propertyInfo.Name == "ShapeType")
            {
                continue;
            }

            writer.WritePropertyName(propertyInfo.Name);
            JsonSerializer.Serialize(writer, propertyInfo.GetValue(value), options);
        }

        writer.WriteEndObject();
    }
}
