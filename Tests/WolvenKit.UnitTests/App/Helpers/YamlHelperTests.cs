using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Helpers;
using YamlDotNet.RepresentationModel;

namespace WolvenKit.UnitTests.App.Helpers;

/// <summary>
/// Tests the YAML helpers used for ArchiveXL file lists.
/// </summary>
[TestClass]
public class YamlHelperTests
{
    private const string firstLipmap = @"mod\my_mod\localization\en-us\first.lipmap";
    private const string secondLipmap = @"mod\my_mod\localization\en-us\second.lipmap";

    [TestMethod]
    public void FindsANestedMapping()
    {
        var rootNode = ParseYaml("""
                                 localization:
                                   lipmaps:
                                     en-us: first.lipmap
                                 """);

        var lipmapsNode = YamlHelper.FindNestedMapping(rootNode, "localization", "lipmaps");

        Assert.IsNotNull(lipmapsNode);
        Assert.IsTrue(lipmapsNode.Children.ContainsKey("en-us"));
    }

    [TestMethod]
    public void FindsNoMappingWhereAKeyIsMissingOrHoldsAnotherNode()
    {
        var rootNode = ParseYaml("""
                                 localization:
                                   onscreens: onscreens.json
                                 """);

        Assert.IsNull(YamlHelper.FindNestedMapping(rootNode, "localization", "lipmaps"));
        Assert.IsNull(YamlHelper.FindNestedMapping(rootNode, "localization", "onscreens"));
        Assert.AreEqual(1, rootNode.Children.Count);
    }

    [TestMethod]
    public void AddsAMissingKeyAsASingleValue()
    {
        var mappingNode = new YamlMappingNode();

        Assert.IsTrue(YamlHelper.AddToScalarOrSequence(mappingNode, "en-us", firstLipmap, StringComparison.OrdinalIgnoreCase));

        Assert.AreEqual(firstLipmap, ((YamlScalarNode)mappingNode.Children["en-us"]).Value);
    }

    [TestMethod]
    public void TurnsAnotherSingleValueIntoASequenceHoldingBoth()
    {
        var mappingNode = new YamlMappingNode { { "en-us", firstLipmap } };

        Assert.IsTrue(YamlHelper.AddToScalarOrSequence(mappingNode, "en-us", secondLipmap, StringComparison.OrdinalIgnoreCase));

        CollectionAssert.AreEqual(new[] { firstLipmap, secondLipmap }, GetSequenceValues(mappingNode, "en-us"));
    }

    [TestMethod]
    public void AppendsToASequence()
    {
        var mappingNode = new YamlMappingNode { { "en-us", new YamlSequenceNode(new YamlScalarNode(firstLipmap)) } };

        Assert.IsTrue(YamlHelper.AddToScalarOrSequence(mappingNode, "en-us", secondLipmap, StringComparison.OrdinalIgnoreCase));

        CollectionAssert.AreEqual(new[] { firstLipmap, secondLipmap }, GetSequenceValues(mappingNode, "en-us"));
    }

    [TestMethod]
    public void DoesNotAddAValueTheKeyAlreadyHolds()
    {
        var singleValue = new YamlMappingNode { { "en-us", firstLipmap } };
        var sequence = new YamlMappingNode { { "en-us", new YamlSequenceNode(new YamlScalarNode(firstLipmap)) } };

        Assert.IsFalse(YamlHelper.AddToScalarOrSequence(
            singleValue, "en-us", firstLipmap.ToUpperInvariant(), StringComparison.OrdinalIgnoreCase));
        Assert.IsFalse(YamlHelper.AddToScalarOrSequence(
            sequence, "en-us", firstLipmap.ToUpperInvariant(), StringComparison.OrdinalIgnoreCase));

        Assert.IsInstanceOfType(singleValue.Children["en-us"], typeof(YamlScalarNode));
        Assert.AreEqual(1, ((YamlSequenceNode)sequence.Children["en-us"]).Children.Count);
    }

    [TestMethod]
    public void ThrowsForAKeyHoldingAMapping()
    {
        var mappingNode = new YamlMappingNode { { "en-us", new YamlMappingNode() } };

        Assert.ThrowsException<InvalidOperationException>(() =>
            YamlHelper.AddToScalarOrSequence(mappingNode, "en-us", firstLipmap, StringComparison.OrdinalIgnoreCase));
    }

    private static YamlMappingNode ParseYaml(string yaml)
    {
        var yamlStream = new YamlStream();
        yamlStream.Load(new StringReader(yaml));
        return (YamlMappingNode)yamlStream.Documents[0].RootNode;
    }

    private static string?[] GetSequenceValues(YamlMappingNode mappingNode, string key) =>
        ((YamlSequenceNode)mappingNode.Children[key]).Children
            .Select(node => ((YamlScalarNode)node).Value)
            .ToArray();
}
