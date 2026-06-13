using System;

namespace WolvenKit.Common.Model;

public class RedTypeTemplateManagerOption : RedTypeTemplateSelectionOption
{
    public bool CanEdit
    {
        get => Source == RedTypeTemplateSelectionOptionSource.User;
    }

    public string TypeName => Type.Name;

    public RedTypeTemplateManagerOption(RedTypeTemplateDescriptor template,
        RedTypeTemplateSelectionOptionSource src)
    {
        Name = template.Name;
        Type = template.Type;
        FilePath = template.FilePath;
        Source = src;
    }

    public RedTypeTemplateManagerOption(string name, Type type, string filepath,
        RedTypeTemplateSelectionOptionSource src)
        : base(name, type, filepath, src) { }

    public RedTypeTemplateManagerOption() : base() { }
}
