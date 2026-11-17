using System;
using WolvenKit.Common.Model;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.Scripting;

public class ScriptRedTypeTemplate
{
    public int FormatVersion { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public string Version { get; set; }

    public object? Data { get; set; }

    public ScriptRedTypeTemplate()
    {
        FormatVersion = 1;

        Author = "";
        Description = "";
        Version = "";
    }

    public ScriptRedTypeTemplate(RedTypeTemplate template)
    {
        FormatVersion = template.FormatVersion;
        Author = template.Author;
        Description = template.Description;
        Version = template.Version;
        Data = template.Data;
    }

    public RedTypeTemplate ToRedTypeTemplate()
    {
        if (Data is not IRedType templateData)
        {
            throw new ArgumentException("Template data must be inheriting from IRedType", nameof(Data));
        }

        return new RedTypeTemplate()
        {
            FormatVersion = FormatVersion,
            Author = Author,
            Description = Description,
            Version = Version,
            Data = templateData
        };
    }
}
