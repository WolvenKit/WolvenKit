using System.Text.Json;

namespace WolvenKit.Common.Extensions;

public static class JsonElementExtensions
{
    public static string GetStringOrDefault(this JsonElement element, string defaultValue = "") => element.ValueKind == JsonValueKind.String ? element.GetString()! : defaultValue;
}
