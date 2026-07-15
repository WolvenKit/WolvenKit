using System;

namespace WolvenKit.Common.Model;

public class RedTypeTemplateDescriptor
{
    public string Name { get; set; }
    public Type Type { get; set; }
    public string FilePath { get; set; }

    public RedTypeTemplateDescriptor()
    {
        Name = "";
        Type = typeof(object);
        FilePath = "";
    }

    public RedTypeTemplateDescriptor(string name, Type type, string filePath)
    {
        Name = name;
        Type = type;
        FilePath = filePath;
    }
}
