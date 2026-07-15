using System;

namespace WolvenKit.Common.Model;

public class RedTypeTemplateSelectionOption : RedTypeTemplateDescriptor
{
    public RedTypeTemplateSelectionOptionSource Source { get; set; }

    public RedTypeTemplateSelectionOption(RedTypeTemplateDescriptor template,
        RedTypeTemplateSelectionOptionSource src)
    {
        Name = template.Name;
        Type = template.Type;
        FilePath = template.FilePath;
        Source = src;
    }

    public RedTypeTemplateSelectionOption(string name, Type type, string filepath, RedTypeTemplateSelectionOptionSource src)
        : base(name, type, filepath) =>
        Source = src;

    public RedTypeTemplateSelectionOption() : base() { }
}
