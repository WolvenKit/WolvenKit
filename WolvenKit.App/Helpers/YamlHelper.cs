using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using DynamicData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace WolvenKit.App.Helpers;

public static class YamlHelper
{
    public static YamlMappingNode CreateLocalizationNode(string jsonRelPath) =>
        new() { { "onscreens", new YamlMappingNode { { "en-us", jsonRelPath } } } };

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

    public static YamlMappingNode EnsureNestedMapping(YamlMappingNode rootNode, params string[] names)
    {
        if (names.Length == 0)
        {
            return rootNode;
        }

        var currentNode = rootNode;
        foreach (var name in names)
        {
            if (!currentNode.Children.TryGetValue(name, out var child))
            {
                var newNode = new YamlMappingNode();
                currentNode.Add(name, newNode);
                currentNode = newNode;
            }
            else if (child is YamlMappingNode existingNode)
            {
                currentNode = existingNode;
            }
            else
            {
                throw new InvalidOperationException($"Node '{name}' exists but is not a mapping node.");
            }
        }

        return currentNode;
    }


    /// <summary>
    /// Appending to parsed yaml will not preserve comments, and also wreak havoc with formatting by trimming all whitespaces.
    /// For that reason, we're parsing first and appending later.
    /// </summary>
    public static void RemoveInExistingFileAndAppend(string absolutePath, string recordName, YamlMappingNode rootNode,
        string[]? prependingFileComment = null)
    {
        if (Path.GetDirectoryName(absolutePath) is string path && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        List<string> existingFileContents = [];

        // If the file exists, remove the record's data
        if (File.Exists(absolutePath) && File.ReadAllLines(absolutePath) is var fileContent)
        {
            if (!fileContent.Any(l => l.Contains($"{recordName}:")))
            {
                existingFileContents.AddRange(fileContent);
            }
            else
            {
                var isInExistingRecord = false;
                existingFileContents.AddRange(fileContent
                    .Where(f =>
                    {
                        if (f.Contains($"{recordName}:"))
                        {
                            isInExistingRecord = true;
                        }

                        // remove comments that contain the record name, since they'll be regenerated
                        if (f.StartsWith('#') && f.Contains($"{recordName.Replace("$(base_color)", "")}"))
                        {
                            return false;
                        }

                        if (isInExistingRecord && !f.Contains(recordName) && !f.StartsWith(' '))
                        {
                            isInExistingRecord = false;
                        }

                        return !isInExistingRecord;
                    })
                );
                while (string.IsNullOrEmpty(existingFileContents[0].Trim()))
                {
                    existingFileContents.RemoveAt(0);
                }

                existingFileContents.AddRange([string.Empty, string.Empty], 0);
            }
        }

        var serializer = new SerializerBuilder().WithIndentedSequences().Build();
        var yaml = serializer.Serialize(rootNode).Replace("'", "");

        existingFileContents.AddRange(yaml.Split(Environment.NewLine), 0);

        if (prependingFileComment is not null && prependingFileComment.Length > 0)
        {
            existingFileContents.AddRange(prependingFileComment.Select(s => s.StartsWith("# ") ? s : $"# {s}"), 0);
            existingFileContents.AddRange([""], prependingFileComment.Length);
        }

        File.WriteAllLines(absolutePath, existingFileContents);
    }

    public static void WriteYaml(string absolutePath, YamlMappingNode rootNode, string[]? prependingFileComment = null)
    {
        if (Path.GetDirectoryName(absolutePath) is string path && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var serializer = new SerializerBuilder().WithIndentedSequences().Build();
        var yaml = serializer.Serialize(rootNode);

        using var writer = new StreamWriter(absolutePath);
        writer.Write(yaml.Replace("'", ""));
        writer.Close();

        if (prependingFileComment is null || prependingFileComment.Length == 0)
        {
            return;
        }

        var fileContents = File.ReadAllLines(absolutePath).ToList();
        fileContents.AddRange(prependingFileComment.Select(s => s.StartsWith("# ") ? s : $"# {s}"), 0);
        File.WriteAllLines(absolutePath, fileContents);
    }

    public static void WriteYaml(string absolutePath, ExpandoObject rootNode, string[]? prependingFileComment = null)
    {
        if (Path.GetDirectoryName(absolutePath) is string path && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        var serializer = new Serializer();
        var yamlString = serializer.Serialize(rootNode);
        var filePath = Path.Join(absolutePath);
        File.WriteAllText(filePath, yamlString);

        if (prependingFileComment is null || prependingFileComment.Length == 0)
        {
            return;
        }

        var fileContents = File.ReadAllLines(absolutePath).ToList();
        fileContents.AddRange(prependingFileComment.Select(s => s.StartsWith("# ") ? s : $"# {s}"), 0);
        File.WriteAllLines(absolutePath, fileContents);
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

    public static YamlMappingNode? ReadYamlAsNodes(string absolutePath)
    {
        if (!File.Exists(absolutePath))
        {
            return null;
        }

        var yamlText = File.ReadAllText(absolutePath);
        var yamlStream = new YamlStream();
        using (var reader = new StringReader(yamlText))
        {
            yamlStream.Load(reader);
        }

        if (yamlStream.Documents.Count == 0)
        {
            return null;
        }

        return yamlStream.Documents[0].RootNode as YamlMappingNode;
    }

    public static void AddPropertyRecursive(IDictionary<string, object> dict, object property, params string[] names)
    {
        if (names.Length == 0)
        {
            return;
        }

        while (names.Length > 1)
        {
            var name = names[0];
            names = names.Skip(1).ToArray();
            if (!dict.TryGetValue(name, out var value))
            {
                dict.Add(name, new Dictionary<string, object>());
            }

            if (dict[name] is IDictionary<string, object> child)
            {
                dict = child;
            }
        }

        dict[names[0]] = property;
    }

    public static object? GetPropertyRecursive(IDictionary<string, object> dict, params string[] names)
    {
        if (names.Length == 0)
        {
            return null;
        }

        while (names.Length > 1)
        {
            var name = names[0];
            names = names.Skip(1).ToArray();
            if (!dict.TryGetValue(names[0], out var value))
            {
                return null;
            }

            if (dict[name] is IDictionary<string, object> child)
            {
                dict = child;
            }
        }

        return dict[names[0]];
    }

    public static Dictionary<string, List<string>> GetItemRecordsFromYaml(string absolutePath)
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
