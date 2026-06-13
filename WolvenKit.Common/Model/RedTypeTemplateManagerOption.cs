using System;

namespace WolvenKit.Common.Model;

public class RedTypeTemplateManagerOption : RedTypeTemplateSelectionOption
{
    public RedTypeTemplate Template;

    public string Author
    {
        get => Template.Author;
        set
        {
            Template.Author = value;
            IsDirty = true;
        }
    }

    public string Description
    {
        get => Template.Description;
        set
        {
            Template.Description = value;
            IsDirty = true;
        }
    }

    public string Version
    {
        get => Template.Version;
        set
        {
            Template.Version = value;
            IsDirty = true;
        }
    }

    public bool IsDirty = false;

    public bool CanEdit
    {
        get => Source == RedTypeTemplateSelectionOptionSource.User;
    }

    public string TypeName => Type.Name;

    public RedTypeTemplateManagerOption(RedTypeTemplateDescriptor templateDesc,
        RedTypeTemplateSelectionOptionSource src, RedTypeTemplate template)
    {
        Name = templateDesc.Name;
        Type = templateDesc.Type;
        FilePath = templateDesc.FilePath;
        Source = src;

        Template = template;
    }
}
