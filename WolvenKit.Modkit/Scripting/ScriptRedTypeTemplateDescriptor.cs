using System;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;

namespace WolvenKit.Modkit.Scripting;

public class ScriptRedTypeTemplateDescriptor
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string FilePath { get; set; }

    public ScriptRedTypeTemplateDescriptor()
    {
        Name = "";
        Type = "";
        FilePath = "";
    }

    public ScriptRedTypeTemplateDescriptor(string name, string type, string filePath)
    {
        Name = name;
        Type = type;
        FilePath = filePath;
    }

    public ScriptRedTypeTemplateDescriptor(RedTypeTemplateDescriptor descriptor)
    {
        Name = descriptor.Name;
        Type = descriptor.Type.Name;
        FilePath = descriptor.FilePath;
    }

    public RedTypeTemplateDescriptor ToRedTypeTemplateDescriptor()
    {
        var type = RedTypeTemplateService.ParseType(Type);
        if (type == null)
        {
            throw new ArgumentException("Invalid type: " + Type, nameof(Type));
        }

        return new RedTypeTemplateDescriptor(Name, type, FilePath);
    }
}
