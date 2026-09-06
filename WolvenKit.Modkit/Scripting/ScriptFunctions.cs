using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Resources;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;

namespace WolvenKit.Modkit.Scripting;

/// <summary>
/// TODO
/// </summary>
public partial class ScriptFunctions
{
    protected readonly ILoggerService _loggerService;
    protected readonly IArchiveManager _archiveManager;
    protected readonly Red4ParserService _redParserService;
    protected readonly RedTypeTemplateService _redTypeTemplateService;

    public ScriptFunctions(ILoggerService loggerService, IArchiveManager archiveManager, Red4ParserService parserService, RedTypeTemplateService redTypeTemplateService)
    {
        _loggerService = loggerService;
        _archiveManager = archiveManager;
        _redParserService = parserService;
        _redTypeTemplateService = redTypeTemplateService;
    }

    /// <summary>
    /// Gets a list of the files available in the game archives
    /// Note to myself: Don't use IEnumerable<T>
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable GetArchiveFiles()
    {
        foreach (var archive in _archiveManager.GetGameArchives())
        {
            foreach (var (key, file) in archive.Files)
            {
                yield return file as FileEntry;
            }
        }
    }

    /// <summary>
    /// DEPRECATED: Please use GetFileFromArchive(path, OpenAs.GameFile)
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="path">The path of the file to retrieve</param>
    /// <returns></returns>
    [Obsolete]
    public virtual IGameFile? GetFileFromBase(string path) => (IGameFile?)GetFileFromArchive(path, OpenAs.GameFile);

    /// <summary>
    /// DEPRECATED: Please use GetFileFromArchive(hash, OpenAs.GameFile)
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="hash">The hash of the file to retrieve</param>
    /// <returns></returns>
    [Obsolete]
    public virtual IGameFile? GetFileFromBase(ulong hash) => (IGameFile?)GetFileFromArchive(hash, OpenAs.GameFile);

    /// <summary>
    /// Creates a json representation of the specifed game file.
    /// </summary>
    /// <param name="gameFile">The gameFile which should be converted</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public virtual string? GameFileToJson(IGameFile gameFile) => (string?)ConvertGameFile(gameFile, OpenAs.Json);

    /// <summary>
    /// Creates a CR2W game file from a json
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    [Obsolete]
    public virtual CR2WFile? JsonToCR2W(string json) => RedJsonSerializer.Deserialize<RedFileDto>(json)?.Data;

    /// <summary>
    /// Changes the extension of the provided string path
    /// </summary>
    /// <param name="path">The path of the file to change</param>
    /// <param name="extension"></param>
    /// <returns></returns>
    public virtual string ChangeExtension(string path, string extension) => Path.ChangeExtension(path, extension);

    protected virtual object? ConvertGameFile(IGameFile gameFile, OpenAs openAs)
    {
        if (openAs == OpenAs.GameFile)
        {
            return gameFile;
        }

        using var ms = new MemoryStream();
        gameFile.Extract(ms);
        ms.Position = 0;

        if (!_redParserService.TryReadRed4File(ms, out var cr2w))
        {
            _loggerService.Error($"\"{gameFile.Name}\" is not a CR2W file");
            return null;
        }

        if (openAs == OpenAs.CR2W)
        {
            return cr2w;
        }

        if (openAs == OpenAs.Json)
        {
            var dto = new RedFileDto(cr2w);
            return RedJsonSerializer.Serialize(dto);
        }

        throw new ArgumentOutOfRangeException(nameof(openAs));
    }

    /// <summary>
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="path">The path of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFileFromArchive(string path, OpenAs openAs)
    {
        if (string.IsNullOrEmpty(path))
        {
            return null;
        }

        if (!ulong.TryParse(path, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(path);
        }

        return GetFileFromArchive(hash, openAs);
    }

    /// <summary>
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="hash">The hash of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFileFromArchive(ulong hash, OpenAs openAs)
    {
        if (hash == 0)
        {
            return null;
        }

        foreach (var archive in _archiveManager.GetGameArchives())
        {
            if (archive.Files.TryGetValue(hash, out var fileEntry))
            {
                return ConvertGameFile(fileEntry, openAs);
            }
        }

        return null;
    }

    /// <summary>
    /// Check if file exists in the game archives
    /// </summary>
    /// <param name="path">file path to check</param>
    /// <returns></returns>
    public virtual bool FileExistsInArchive(string path) => GetFileFromArchive(path, OpenAs.GameFile) != null;

    /// <summary>
    /// Check if file exists in the game archives
    /// </summary>
    /// <param name="hash">hash value to be checked</param>
    /// <returns></returns>
    public virtual bool FileExistsInArchive(ulong hash) => GetFileFromArchive(hash, OpenAs.GameFile) != null;

    /// <summary>
    /// Converts a YAML string to a JSON string
    /// </summary>
    /// <param name="yamlText">The YAML string to convert</param>
    /// <returns>The converted JSON string</returns>
    public virtual string YamlToJson(string yamlText)
    {
        try
        {
            return YamlHelper.YamlToJson(yamlText);
        }
        catch (Exception e)
        {
            _loggerService.Error("Failed to read YAML: " + e.Message);
            _loggerService.Error(e);
        }

        return "";
    }

    /// <summary>
    /// Converts a JSON string to a YAML string
    /// </summary>
    /// <param name="jsonText">The JSON string to convert</param>
    /// <returns>The converted YAML string</returns>
    public virtual string JsonToYaml(string jsonText)
    {
        var expConverter = new ExpandoObjectConverter();
        var deserializedObject = JsonConvert.DeserializeObject<ExpandoObject>(jsonText, expConverter);

        var serializer = new Serializer();
        return serializer.Serialize(deserializedObject);
    }

    #region Template Service

    /// <summary>
    /// Reloads all templates from the disk.
    /// </summary>
    public virtual void ReloadTemplates() => _redTypeTemplateService.LoadTemplates();

    /// <summary>
    /// Gets a list of template descriptors for the specified template destination
    /// </summary>
    /// <param name="src">The source for the template list can be "TemplateDestination.System" or "TemplateDestination.User"</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <remarks>The list is passed via copy, changes to it will not be reflected upstream.</remarks>
    public virtual List<ScriptRedTypeTemplateDescriptor> GetTemplateDescriptors(TemplateDestination src) => src switch
    {
        TemplateDestination.System => _redTypeTemplateService.SystemTemplates
            .Select(t => new ScriptRedTypeTemplateDescriptor(t)).ToList(),
        TemplateDestination.User => _redTypeTemplateService.UserTemplates
            .Select(t => new ScriptRedTypeTemplateDescriptor(t)).ToList(),
        _ => throw new ArgumentOutOfRangeException(nameof(src), src, null)
    };

    /// <inheritdoc cref="RedTypeTemplateService.GetTemplateDescriptor(Type, string, TemplateSource)"/>
    /// <exception cref="ArgumentException">String does not represent a valid C# type</exception>
    public virtual ScriptRedTypeTemplateDescriptor? GetTemplateDescriptor(string type, string templateName = "default", TemplateSource src = TemplateSource.Auto)
    {
        var parsedType = RedTypeTemplateService.ParseType(type);
        if (parsedType == null)
        {
            throw new ArgumentException("Invalid type: " + type, nameof(type));
        }

        var desc = _redTypeTemplateService.GetTemplateDescriptor(parsedType, templateName);
        if (desc == null)
        {
            return null;
        }

        return new ScriptRedTypeTemplateDescriptor(desc);
    }

    /// <inheritdoc cref="RedTypeTemplateService.CreateTypeInstance(Type, string, TemplateSource)"/>
    public virtual object CreateTemplatedTypeInstance(string type, string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        CreateTemplatedTypeInstance(new ScriptRedTypeTemplateDescriptor(templateName, type), src);

    /// <inheritdoc cref="RedTypeTemplateService.CreateTypeInstance(RedTypeTemplateDescriptor, TemplateSource)"/>
    public virtual object CreateTemplatedTypeInstance(ScriptRedTypeTemplateDescriptor templateDescriptor, TemplateSource src = TemplateSource.Auto)
        => _redTypeTemplateService.CreateTypeInstance(templateDescriptor.ToRedTypeTemplateDescriptor(), src);


    /// <inheritdoc cref="RedTypeTemplateService.ReadTemplate(Type, string, TemplateSource)"/>
    public virtual ScriptRedTypeTemplate? ReadTemplate(string type, string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        ReadTemplate(new ScriptRedTypeTemplateDescriptor(templateName, type), src);

    /// <inheritdoc cref="RedTypeTemplateService.ReadTemplate(RedTypeTemplateDescriptor, TemplateSource)"/>
    public virtual ScriptRedTypeTemplate? ReadTemplate(ScriptRedTypeTemplateDescriptor templateDescriptor,
        TemplateSource src = TemplateSource.Auto)
    {
        var template = _redTypeTemplateService.ReadTemplate(templateDescriptor.ToRedTypeTemplateDescriptor(), src);
        if (template == null)
        {
            return null;
        }

        return new ScriptRedTypeTemplate(template);
    }

    // rider doesn't support inheritdocs path property, hence all XML docs that need to filter the content they're inheriting need to be duplicated
    /// <summary>
    /// Writes a template to the user directory.
    /// </summary>
    /// <param name="template">Instance of the template</param>
    /// <param name="templateName">Name of the template</param>
    /// <remarks>If a template with that name already exists, it will be overwritten.</remarks>
    /// <exception cref="ArgumentNullException">Template Data property is null</exception>
    /// <exception cref="ArgumentException">Template Data type is not templateable</exception>
    public virtual void WriteTemplate(ScriptRedTypeTemplate template, string templateName)
        => _redTypeTemplateService.WriteTemplate(template.ToRedTypeTemplate(), templateName);

    /// <summary>
    /// Deletes a template from the user directory.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="templateName"></param>
    public virtual void DeleteTemplate(string type, string templateName)
        => DeleteTemplate(new ScriptRedTypeTemplateDescriptor(templateName, type));

    /// <summary>
    /// Deletes a template from the user directory.
    /// </summary>
    /// <param name="templateDescriptor"></param>
    public virtual void DeleteTemplate(ScriptRedTypeTemplateDescriptor templateDescriptor)
        => _redTypeTemplateService.DeleteTemplate(templateDescriptor.ToRedTypeTemplateDescriptor());

    /// <inheritdoc cref="RedTypeTemplateService.TemplateExists(Type, string, TemplateSource)"/>
    public virtual bool TemplateExists(string type, string templateName, TemplateSource src = TemplateSource.Auto)
        => TemplateExists(new ScriptRedTypeTemplateDescriptor(templateName, type), src);

    /// <inheritdoc cref="RedTypeTemplateService.TemplateExists(RedTypeTemplateDescriptor, TemplateSource)"/>
    public virtual bool TemplateExists(ScriptRedTypeTemplateDescriptor templateDesc, TemplateSource src = TemplateSource.Auto)
        => _redTypeTemplateService.TemplateExists(templateDesc.ToRedTypeTemplateDescriptor(), src);

    /// <summary>
    /// Checks if the specified type is templatable.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">String does not represent a valid C# type</exception>
    public virtual bool IsTypeTemplatable(string type)
    {
        var parsedType = RedTypeTemplateService.ParseType(type);
        if (parsedType == null)
        {
            throw new ArgumentException("Invalid type: " + type, nameof(type));
        }
        return RedTypeTemplateService.IsTypeTemplatable(parsedType);
    }

    /// <summary>
    /// Checks if a template of the specified type is available.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="src"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">String does not represent a valid C# type</exception>
    public virtual bool IsAnyTemplateOfTypeAvailable(string type, TemplateSource src = TemplateSource.Auto)
    {
        var parsedType = RedTypeTemplateService.ParseType(type);
        if (parsedType == null)
        {
            throw new ArgumentException("Invalid type: " + type, nameof(type));
        }
        return _redTypeTemplateService.IsAnyTemplateOfTypeAvailable(parsedType, src);
    }

    #endregion
}

public enum OpenAs
{
    GameFile,
    CR2W,
    Json
}
