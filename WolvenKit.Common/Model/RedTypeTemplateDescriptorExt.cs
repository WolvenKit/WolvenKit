using System;

namespace WolvenKit.Common.Model;

public class RedTypeTemplateDescriptorExt : RedTypeTemplateDescriptor
{
    public RedTypeTemplateDescriptorExtSource Source { get; set; }

    public RedTypeTemplateDescriptorExt(RedTypeTemplateDescriptor template,
        RedTypeTemplateDescriptorExtSource src)
    {
        Name = template.Name;
        Type = template.Type;
        FilePath = template.FilePath;
        Source = src;
    }

    public RedTypeTemplateDescriptorExt(string name, Type type, string filepath, RedTypeTemplateDescriptorExtSource src)
        : base(name, type, filepath) =>
        Source = src;

    public RedTypeTemplateDescriptorExt() : base() { }
}
