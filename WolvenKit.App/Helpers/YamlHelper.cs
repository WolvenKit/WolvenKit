using System.Collections.Generic;
using System.IO;
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
}