using System;
using WolvenKit.App.Helpers;
using WolvenKit.Common;
using Xunit;

namespace Wolvenkit.Test;

public class RawFileFormatParserTests
{
    [Theory]
    [InlineData("jpg", ERawFileFormat.jpg)]
    [InlineData(".JPG", ERawFileFormat.jpg)]
    [InlineData("jpeg", ERawFileFormat.jpg)]
    [InlineData(".JPEG", ERawFileFormat.jpg)]
    [InlineData("jpe", ERawFileFormat.jpg)]
    [InlineData(".JpE", ERawFileFormat.jpg)]
    [InlineData("tiff", ERawFileFormat.tiff)]
    [InlineData(".TIFF", ERawFileFormat.tiff)]
    [InlineData("tif", ERawFileFormat.tiff)]
    [InlineData(".TiF", ERawFileFormat.tiff)]
    public void ResolvesImageAliases(string extension, ERawFileFormat expected)
    {
        Assert.True(RawFileFormatParser.TryParse(extension, out var format));
        Assert.Equal(expected, format);
        Assert.True(ImportExportHelper.CanImportFilepath("texture_d." + extension.TrimStart('.')));
    }

    [Fact]
    public void PreservesAllCanonicalFormats()
    {
        foreach (var expected in Enum.GetValues<ERawFileFormat>())
        {
            Assert.True(RawFileFormatParser.TryParse(expected.ToString(), out var format));
            Assert.Equal(expected, format);
            Assert.True(RawFileFormatParser.TryParse(expected.ToString().ToUpperInvariant(), out format));
            Assert.Equal(expected, format);
        }
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(".")]
    [InlineData("webp")]
    [InlineData("1")]
    [InlineData("999")]
    [InlineData("bmp, jpg")]
    [InlineData(" jpg ")]
    public void RejectsInvalidExtensions(string? extension)
    {
        Assert.False(RawFileFormatParser.TryParse(extension, out _));
    }
}
