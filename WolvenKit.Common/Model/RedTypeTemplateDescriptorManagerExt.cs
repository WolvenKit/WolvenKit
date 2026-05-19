using System;

namespace WolvenKit.Common.Model;

public class RedTypeTemplateDescriptorManagerExt : RedTypeTemplateDescriptorExt
{
    public bool CanEdit
    {
        get => Source == RedTypeTemplateDescriptorExtSource.User;
    }

    public string TypeName => Type.Name;

    public RedTypeTemplateDescriptorManagerExt(RedTypeTemplateDescriptor template,
        RedTypeTemplateDescriptorExtSource src)
    {
        Name = template.Name;
        Type = template.Type;
        FilePath = template.FilePath;
        Source = src;
    }

    public RedTypeTemplateDescriptorManagerExt(string name, Type type, string filepath,
        RedTypeTemplateDescriptorExtSource src)
        : base(name, type, filepath, src) { }

    public RedTypeTemplateDescriptorManagerExt() : base() { }
}
