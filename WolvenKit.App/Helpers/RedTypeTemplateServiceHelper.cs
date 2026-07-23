using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class RedTypeTemplateServiceHelper
{
    private static readonly HttpClient s_httpClient = new();

    /// <summary>
    /// This is a helper method to correctly handle the Raw option when using RedTypeTemplateSelectionOption
    /// </summary>
    /// <param name="templateService"></param>
    /// <param name="templateOption"></param>
    /// <param name="fallbackType">type to be used for the Raw option</param>
    /// <returns></returns>
    public static IRedType CreateTypeInstanceFromSelectionOption(this RedTypeTemplateService templateService,
        RedTypeTemplateSelectionOption templateOption, Type fallbackType)
        => templateOption.Source switch
        {
            RedTypeTemplateSelectionOptionSource.Raw => RedTypeManager.CreateAndInitRedType(fallbackType),
            RedTypeTemplateSelectionOptionSource.User => templateService.CreateTypeInstance(templateOption, TemplateSource.User),
            RedTypeTemplateSelectionOptionSource.System => templateService.CreateTypeInstance(templateOption, TemplateSource.System),
            _ => throw new ArgumentOutOfRangeException(nameof(templateOption), templateOption.Source.ToString())
        };

    /// <summary>
    /// Updates the system templates from the remote WolvenKit/WolvenKit-Resources repository.
    /// </summary>
    /// <param name="loggerService"></param>
    /// <returns>true if templates are up to date or have been updated, false if status could not be verified or failed to download updated templates</returns>
    /// <remarks>Does not trigger the template service to load them from disk</remarks>
    public static async Task<bool> UpdateSystemTemplatesFromRemote(ILoggerService? loggerService = null)
    {
        // check remote version (no github API call)
        var hashUrl = $@"https://wolvenkit.github.io/Wolvenkit-Resources/templatehash.txt";
        var response = await s_httpClient.GetAsync(new Uri(hashUrl));

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            loggerService?.Error($"Failed to respond to url: {hashUrl}");
            loggerService?.Error(ex);
            return false;
        }

        var localHash = "";
        var templatesDir = new DirectoryInfo(Path.Combine("Resources", "Templates"));
        FileInfo hashPath = new(Path.Combine("Resources", "templatehash.txt"));
        if (hashPath.Exists)
        {
            localHash = await File.ReadAllTextAsync(hashPath.FullName);
        }

        using var ms = new MemoryStream();
        await response.Content.CopyToAsync(ms);
        ms.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(ms, Encoding.UTF8);
        var remoteHash = await reader.ReadToEndAsync();
        remoteHash = remoteHash.TrimEnd('\r', '\n');

        if (localHash == remoteHash)
        {
            return true;
        }

        // clean
        if (templatesDir.Exists)
        {
            templatesDir.Delete(true);
        }
        Directory.CreateDirectory(templatesDir.FullName);

        // download zip file
        var contentUrl = $@"https://wolvenkit.github.io/Wolvenkit-Resources/templates.zip";
        response = await s_httpClient.GetAsync(new Uri(contentUrl));
        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            loggerService?.Warning($"Failed update scripts from {contentUrl}");
            loggerService?.Warning($"\t{ex.Message}");
            return false;
        }

        var zip = await response.Content.ReadAsStreamAsync();
        zip.Seek(0, SeekOrigin.Begin);
        ZipArchive zipArchive = new(zip);
        zipArchive.ExtractToDirectory(templatesDir.FullName, true);

        await File.WriteAllTextAsync(hashPath.FullName, remoteHash);
        return true;
    }
}
