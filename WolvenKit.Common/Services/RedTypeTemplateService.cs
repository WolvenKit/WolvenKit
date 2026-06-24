using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using Activator = System.Activator;

namespace WolvenKit.Common.Services;

public class RedTypeTemplateService
{
    private readonly ILoggerService _logger;
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        Converters = { new RedTypeTemplateConverter() },
        WriteIndented = true
    };

    private readonly string _systemTemplateDir;
    private readonly string _userTemplateDir;

    public readonly List<RedTypeTemplateDescriptor> SystemTemplates = [];
    public readonly List<RedTypeTemplateDescriptor> UserTemplates = [];

    private object _lock = new();

    public RedTypeTemplateService(ILoggerService logger, string systemTemplateDir, string userTemplateDir)
    {
        _logger = logger;

        _systemTemplateDir = systemTemplateDir;
        _userTemplateDir = userTemplateDir;

        Directory.CreateDirectory(_systemTemplateDir);
        Directory.CreateDirectory(_userTemplateDir);

        LoadTemplates();
    }

    #region Template Registry

    /// <summary>
    /// Loads all templates from the system and user template directories after clearing the internal state.
    /// </summary>
    public void LoadTemplates()
    {
        lock (_lock)
        {
            SystemTemplates.Clear();
            UserTemplates.Clear();

            LoadTemplatesFromDirectory(_systemTemplateDir, SystemTemplates);
            LoadTemplatesFromDirectory(_userTemplateDir, UserTemplates);
        }
    }

    private void LoadTemplatesFromDirectory(string dir, List<RedTypeTemplateDescriptor> templates)
    {
        foreach (var f in new DirectoryInfo(dir).EnumerateFiles("*", SearchOption.TopDirectoryOnly))
        {
            if (!f.Name.EndsWith(".json"))
            {
                _logger.Warning($"Skipping non-json file {f.FullName}");
                continue;
            }

            var sections = f.Name.Split('.');
            if (sections.Length != 3)
            {
                _logger.Warning($"Skipping filename with malformed filename {f.FullName}");
                continue;
            }

            var type = ParseType(sections[1]);
            if (type == null)
            {
                _logger.Warning($"Skipping file with unknown type {f.FullName}");
                continue;
            }

            try
            {
                var template = DeserializeTemplate(type, File.ReadAllText(f.FullName));

                if (template.Data is null)
                {
                    _logger.Warning($"Failed to deserialize template {f.FullName}");
                    continue;
                }
            }
            catch (Exception e)
            {
                _logger.Warning($"Failed to deserialize template {f.FullName} with exception {e.Message}");
                continue;
            }

            templates.Add(new RedTypeTemplateDescriptor(sections[0], type, f.FullName));
            _logger.Debug($"Loaded file {f.FullName} with type {type.Name} and name {sections[0]}");
        }
    }

    #endregion

    #region Read Templates

    /// <summary>
    /// Creates an instance of the given type by first attempting to read the template, if no template is found, a blank instance is created instead.
    /// </summary>
    /// <param name="templateDescriptor">Descriptor of the Template</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public IRedType? CreateTypeInstance(RedTypeTemplateDescriptor templateDescriptor, TemplateSource src = TemplateSource.Auto) =>
        CreateTypeInstance(templateDescriptor.Type, templateDescriptor.Name, src);

    /// <summary>
    /// Creates an instance of the given type by first attempting to read the template, if no template is found, a blank instance is created instead.
    /// </summary>
    /// <param name="templateName">Name of the template, defaults to "default"</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public IRedType? CreateTypeInstance<T>(string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        CreateTypeInstance(typeof(T), templateName, src);

    /// <summary>
    /// Creates an instance of the given type by first attempting to read the template, if no template is found, a blank instance is created instead.
    /// </summary>
    /// <param name="templateName">Name of the template, defaults to "default"</param>
    /// <param name="type">Type of the template</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public IRedType? CreateTypeInstance(Type type, string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        ReadTemplate(type, templateName, src)?.Data ?? ReadTemplate(type, "default", src)?.Data ?? (IRedType?)Activator.CreateInstance(type);

    /// <summary>
    /// Reads a template from the system or user template directory and returns an instance of the templated object.
    /// </summary>
    /// <param name="templateDescriptor">Descriptor of the Template</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public RedTypeTemplate? ReadTemplate(RedTypeTemplateDescriptor templateDescriptor, TemplateSource src = TemplateSource.Auto) => ReadTemplate(templateDescriptor.Type, templateDescriptor.Name, src);

    /// <summary>
    /// Reads a template from the system or user template directory and returns an instance of the templated object.
    /// </summary>
    /// <param name="templateName">Name of the template, defaults to "default"</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public RedTypeTemplate? ReadTemplate<T>(string templateName = "default", TemplateSource src = TemplateSource.Auto) => ReadTemplate(typeof(T), templateName, src);

    /// <summary>
    /// Reads a template from the system or user template directory and returns an instance of the templated object.
    /// </summary>
    /// <param name="templateName">Name of the template, defaults to "default"</param>
    /// <param name="type">Type of the template</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public RedTypeTemplate? ReadTemplate(Type type, string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        src switch
        {
            TemplateSource.Auto => ReadTemplate(type, templateName, UserTemplates) ??
                                   ReadTemplate(type, templateName, SystemTemplates),
            TemplateSource.System => ReadTemplate(type, templateName, SystemTemplates),
            TemplateSource.User => ReadTemplate(type, templateName, UserTemplates),
            _ => throw new ArgumentOutOfRangeException(nameof(src), src, null)
        };

    private RedTypeTemplate? ReadTemplate(Type templateType, string templateName, List<RedTypeTemplateDescriptor> templates)
    {
        lock (_lock)
        {
            var template = templates.FirstOrDefault(t => t.Name == templateName && t.Type == templateType);
            return template == null ? null : DeserializeTemplate(templateType, File.ReadAllText(template.FilePath));
        }
    }

    #endregion

    #region Write Templates

    /// <summary>
    /// Writes a template to the system or user template directory.
    /// </summary>
    /// <param name="template">Instance of the template</param>
    /// <param name="templateName">Name of the template</param>
    /// <param name="dst">Template category destination</param>
    /// <remarks>If a template with that name already exists, it will be overwritten.</remarks>
    /// <exception cref="ArgumentNullException">Template Data property is null</exception>
    public void WriteTemplate(RedTypeTemplate template, string templateName, TemplateDestination dst = TemplateDestination.User)
    {
        ArgumentNullException.ThrowIfNull(template.Data, nameof(template.Data));

        _logger.Debug($"{template.Data.GetType()} / {template.Data.RedType}");

        Type dataType;
        IRedType data;
        switch (template.Data)
        {
            case DataBuffer dataBuffer:
                dataType = dataBuffer.Data?.GetType() ?? typeof(DataBuffer);
                data = dataBuffer.Data?.Data ?? throw new Exception("DataBuffer value is null");
                break;
            case IRedBaseHandle handle:
                dataType = handle.GetValue()?.GetType() ?? typeof(IRedBaseHandle);
                data = handle.GetValue() ?? throw new Exception("Handle value is null");
                break;
            case IRedEnum cenum:
                dataType = cenum.GetEnumValue().GetType();
                data = template.Data;
                break;
            default:
                dataType = template.Data.GetType();
                data = template.Data;
                break;
        }

        template.Data = data;

        var fn = Path.Join(dst == TemplateDestination.User ? _userTemplateDir : _systemTemplateDir, $"{templateName}.{dataType.Name}.json");
        var js = JsonSerializer.Serialize(template, _jsonOptions);

        lock (_lock)
        {
            File.WriteAllText(fn, js);

            var templateList = dst == TemplateDestination.User ? UserTemplates : SystemTemplates;
            if (!templateList.Any(t => t.Name.Equals(templateName, StringComparison.CurrentCultureIgnoreCase) && t.Type == dataType))
            {
                templateList.Add(new RedTypeTemplateDescriptor(templateName, dataType, fn));
            }
        }
    }

    #endregion

    #region Delete Templates

    /// <summary>
    /// Deletes a template from the system or user template directory.
    /// </summary>
    /// <param name="templateDescriptor"></param>
    /// <param name="dst"></param>
    public void DeleteTemplate(RedTypeTemplateDescriptor templateDescriptor, TemplateDestination dst = TemplateDestination.User) => DeleteTemplate(templateDescriptor.Type, templateDescriptor.Name, dst);

    /// <summary>
    /// Deletes a template from the system or user template directory.
    /// </summary>
    /// <param name="templateName"></param>
    /// <param name="dst"></param>
    public void DeleteTemplate<T>(string templateName, TemplateDestination dst = TemplateDestination.User) => DeleteTemplate(typeof(T), templateName, dst);

    /// <summary>
    /// Deletes a template from the system or user template directory.
    /// </summary>
    /// <param name="templateType"></param>
    /// <param name="templateName"></param>
    /// <param name="dst"></param>
    public void DeleteTemplate(Type templateType, string templateName, TemplateDestination dst = TemplateDestination.User)
    {
        var fn = GetTemplateFilePath(templateType, templateName, dst);
        var templateList = dst == TemplateDestination.User ? UserTemplates : SystemTemplates;
        lock (_lock)
        {
            File.Delete(fn);
            templateList.RemoveAll(t => t.Name == templateName && t.Type == templateType);
        }
    }

    #endregion

    #region Misc

    /// <summary>
    /// Checks if a template with the given type and name exists in the system or user template directory.
    /// </summary>
    /// <param name="templateDesc"></param>
    /// <param name="src"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public bool TemplateExists(RedTypeTemplateDescriptor templateDesc, TemplateSource src = TemplateSource.Auto) => TemplateExists(templateDesc.Type, templateDesc.Name, src);

    /// <summary>
    /// Checks if a template with the given type and name exists in the system or user template directory.
    /// </summary>
    /// <param name="templateName"></param>
    /// <param name="src"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public bool TemplateExists<T>(string templateName, TemplateSource src = TemplateSource.Auto) => TemplateExists(typeof(T), templateName, src);

    /// <summary>
    /// Checks if a template with the given type and name exists in the system or user template directory.
    /// </summary>
    /// <param name="templateType"></param>
    /// <param name="templateName"></param>
    /// <param name="src"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public bool TemplateExists(Type templateType, string templateName, TemplateSource src = TemplateSource.Auto) => src switch
    {
        TemplateSource.Auto => SystemTemplates.Any(t => t.Name.Equals(templateName, StringComparison.CurrentCultureIgnoreCase) && t.Type == templateType) ||
                               UserTemplates.Any(t => t.Name.Equals(templateName, StringComparison.CurrentCultureIgnoreCase) && t.Type == templateType),
        TemplateSource.System => SystemTemplates.Any(t => t.Name.Equals(templateName, StringComparison.CurrentCultureIgnoreCase) && t.Type == templateType),
        TemplateSource.User => UserTemplates.Any(t => t.Name.Equals(templateName, StringComparison.CurrentCultureIgnoreCase) && t.Type == templateType),
        _ => throw new ArgumentOutOfRangeException(nameof(src), src, null)
    };

    #endregion

    #region Helper Methods

    private string GetTemplateFilePath(Type type, string name, TemplateDestination src) => Path.Join(
        src == TemplateDestination.User ? _userTemplateDir : _systemTemplateDir, $"{name}.{type.Name}.json");

    public static Type? ParseType(string typeName) => AppDomain.CurrentDomain
        .GetAssemblies()
        .SelectMany(a => a.GetTypes())
        .FirstOrDefault(t => t.Name == typeName);

    private RedTypeTemplate DeserializeTemplate(Type type, string json)
    {
        var options = new JsonSerializerOptions(_jsonOptions);
        options.Converters.Remove(options.Converters.First(c => c is RedTypeTemplateConverter));
        options.Converters.Add(new RedTypeTemplateConverter(type));

        var template = JsonSerializer.Deserialize<RedTypeTemplate>(json, options);
        return template ?? throw new Exception("Failed to deserialize template");
    }

    #endregion
}
