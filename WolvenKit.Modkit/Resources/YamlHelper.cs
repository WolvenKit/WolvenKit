using System.Text.RegularExpressions;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace WolvenKit.Modkit.Resources;

public class YamlHelper
{
    /// <summary>
    /// remove yaml tags like !include, !append etc., which make Deserializer fail
    /// </summary>
    private static readonly Regex s_yamlTagRegex = new(@"(?<=-)\s?\![a-z-]*(?=\s)");

    public static string YamlToJson(string yamlText)
    {
        // remove yaml tags like !include, !append etc.
        yamlText = s_yamlTagRegex.Replace(yamlText, "");

        // deserialize it
        var yamlObject = new Deserializer().Deserialize(yamlText);

        return JsonConvert.SerializeObject(yamlObject);
    }
}
