using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W.JSON;
using Activator = System.Activator;

namespace WolvenKit.Common.Services;

public class RedTypeTemplateService
{
    private readonly ILoggerService _logger;

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
                var template = ReadTemplate(type, File.ReadAllText(f.FullName));

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
    /// <param name="templateName">Name of the template, defaults to "default"</param>
    /// <param name="type">Type of the template</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public object? CreateTypeInstance(Type type, string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        ReadTemplate(type, templateName, src) ?? Activator.CreateInstance(type);

    /// <summary>
    /// Creates an instance of the given type by first attempting to read the template, if no template is found, a blank instance is created instead.
    /// </summary>
    /// <param name="templateName">Name of the template, defaults to "default"</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public object? CreateTypeInstance<T>(string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        ReadTemplate(typeof(T), templateName, src) ?? Activator.CreateInstance(typeof(T));

    /// <summary>
    /// Reads a template from the system or user template directory and returns an instance of the templated object.
    /// </summary>
    /// <param name="templateName">Name of the template, defaults to "default"</param>
    /// <param name="src">Source of the template, defaults to "Auto"</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="Exception">Template File contains invalid or mismatched data</exception>
    /// <remarks>When using <see cref="TemplateSource.Auto"/>, user templates are preferred over system templates.</remarks>
    public object? ReadTemplate<T>(string templateName = "default", TemplateSource src = TemplateSource.Auto) => ReadTemplate(typeof(T), templateName, src);

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
    public object? ReadTemplate(Type type, string templateName = "default", TemplateSource src = TemplateSource.Auto) =>
        src switch
        {
            TemplateSource.Auto => ReadTemplate(type, templateName, UserTemplates) ??
                                   ReadTemplate(type, templateName, SystemTemplates),
            TemplateSource.System => ReadTemplate(type, templateName, SystemTemplates),
            TemplateSource.User => ReadTemplate(type, templateName, UserTemplates),
            _ => throw new ArgumentOutOfRangeException(nameof(src), src, null)
        };

    private object? ReadTemplate(Type templateType, string templateName, List<RedTypeTemplateDescriptor> templates)
    {
        lock (_lock)
        {
            var template = templates.FirstOrDefault(t => t.Name == templateName && t.Type == templateType);
            return template == null ? null : ReadTemplate(templateType, File.ReadAllText(template.FilePath)).Data;
        }
    }

    #endregion

    #region Write Templates

    /// <summary>
    /// Writes a template to the system or user template directory.
    /// </summary>
    /// <param name="template">Instance of the object to act as a template</param>
    /// <param name="templateName">Name of the template</param>
    /// <param name="dst">Template category destination</param>
    /// <remarks>If a template with that name already exists, it will be overwritten.</remarks>
    public void WriteTemplate(object templateData, string templateName, TemplateDestination dst = TemplateDestination.User)
    {
        var fn = Path.Join(dst == TemplateDestination.User ? _userTemplateDir : _systemTemplateDir, $"{templateName}.{templateData.GetType().Name}.json");
        var template = new RedTypeTemplate()
        {
            Version = 1,
            Data = templateData
        };
        var js = RedJsonSerializer.Serialize(template);

        lock (_lock)
        {
            File.WriteAllText(fn, js);
        }

        var templateList = dst == TemplateDestination.User ? UserTemplates : SystemTemplates;
        if (!templateList.Any(t => t.Name == templateName && t.Type == template.GetType()))
        {
            templateList.Add(new RedTypeTemplateDescriptor(templateName, template.GetType(), fn));
        }
    }

    #endregion

    #region Helper Methods

    public static Type? ParseType(string typeName) => AppDomain.CurrentDomain
        .GetAssemblies()
        .SelectMany(a => a.GetTypes())
        .FirstOrDefault(t => t.Name == typeName);

    private static RedTypeTemplate ReadTemplate(Type type, string json)
    {
        var doc = JsonDocument.Parse(json);

        var versionPresent = doc.RootElement.TryGetProperty("Version", out var version);
        var dataPresent = doc.RootElement.TryGetProperty("Data", out var data);

        if (!versionPresent)
        {
            throw new Exception("Template file is missing version property");
        }

        if (!dataPresent)
        {
            throw new Exception("Template file is missing data property");
        }

        return new RedTypeTemplate
        {
            Version = version.GetInt32(),
            Data = RedJsonSerializer.Deserialize(type, data)
        };
    }

    #endregion
}
