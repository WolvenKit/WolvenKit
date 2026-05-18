using System.Collections.Generic;

namespace WolvenKit.Common.Model
{
    public class WolvenKitFileDefinitions
    {
        public List<FileCategoryModel> Categories { get; set; } = new();
    }

    public class FileCategoryModel
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<AddFileModel>? Files { get; set; }
    }

    public enum RedTypeTemplateFileModelDescriptorType
    {
        User,
        System,
        Raw // Raw as in the default as defined by the RTTI
    }

    public class RedTypeTemplateFileModelDescriptor
    {
        public string Name { get; set; } = "";
        public RedTypeTemplateFileModelDescriptorType Type { get; set; } = RedTypeTemplateFileModelDescriptorType.Raw;

        public RedTypeTemplateFileModelDescriptor() { }

        public RedTypeTemplateFileModelDescriptor(string name, RedTypeTemplateFileModelDescriptorType type)
        {
            Name = name;
            Type = type;
        }
    }

    public class AddFileModel
    {
        public AddFileModel()
        {

        }

        public AddFileModel(string? name, string? description, string? extension, EWolvenKitFile type, string? template, List<RedTypeTemplateFileModelDescriptor>? redTypeTemplates)
        {
            Name = name;
            Description = description;
            FullText = $"Name: {name}, Extension: {extension}, Description: {description}";
            Extension = extension;
            Type = type;
            Template = template;
            RedTypeTemplates = redTypeTemplates;
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Extension { get; set; }
        public EWolvenKitFile Type { get; set; }
        public string? Template { get; set; }

        // Just for filtering
        public string? FullText { get; init; }

        public List<RedTypeTemplateFileModelDescriptor>? RedTypeTemplates { get; set; }
    }
}
