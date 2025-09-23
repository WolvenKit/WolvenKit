using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace WolvenKit.App.Helpers;

public class YamlHelper
{
    public static YamlMappingNode CreateLocalizationNode(string jsonRelPath)
    {
        return new YamlMappingNode { { "onscreens", new YamlMappingNode { { "en-us", jsonRelPath } } } };
    }

    public static YamlMappingNode CreateScopeNode(string scopeName, List<string> scopeValues)
    {
        var scopeNode = new YamlSequenceNode();
        foreach (var str in scopeValues)
        {
            scopeNode.Add(str);
        }

        return new YamlMappingNode
        {
            { "scope", new YamlMappingNode { { scopeName, scopeNode } } }
        };
    }


    public static void WriteYaml(string absolutePath, YamlMappingNode rootNode)
    {
        var serializer = new SerializerBuilder().WithIndentedSequences().Build();
        var yaml = serializer.Serialize(rootNode);

        using var writer = new StreamWriter(absolutePath);
        writer.Write(yaml);
    }

    public static ExpandoObject? ReadYamlAsObject(string absolutePath)
    {
        if (!File.Exists(absolutePath))
        {
            return null;
        }

        var yamlText = File.ReadAllText(absolutePath);
        var jsonText = Modkit.Resources.YamlHelper.YamlToJson(yamlText);
        return JsonConvert.DeserializeObject<ExpandoObject>(jsonText, new ExpandoObjectConverter());
    }

    public static Dictionary<string, List<string>> GetItemsFromYaml(string absolutePath)
    {
        Dictionary<string, List<string>> ret = [];
        if (ReadYamlAsObject(absolutePath) is not ExpandoObject yaml || yaml.AsReadOnly() is not { } yamlDict ||
            yamlDict.Count == 0)
        {
            return ret;
        }


        foreach (var itemKey in yamlDict.Keys.Where(key => key.StartsWith("Items.")))
        {
            if (!yamlDict.TryGetValue(itemKey, out var itemValue) || itemValue is not ExpandoObject value ||
                value.AsReadOnly() is not { } itemDict || itemDict.Count == 0)
            {
                continue;
            }

            ret.TryAdd(itemKey, []);

            if (!itemDict.TryGetValue("$instances", out var inst) || inst is not List<Object> instances)
            {
                ret[itemKey].Add("");
                continue;
            }

            foreach (var i in instances.OfType<ExpandoObject>().Select(i => i.AsReadOnly()))
            {
                var itemName = itemKey.Replace('{', '(').Replace('}', ')');
                foreach (var iKey in i.Keys)
                {
                    itemName = itemName.Replace($"$({iKey})", $"{i[iKey]}");
                }

                ret[itemKey].Add(itemName);
            }
        }

        return ret;
    }


}
