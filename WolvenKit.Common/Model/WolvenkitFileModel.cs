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

    public class AddFileModel
    {
        public AddFileModel()
        {

        }
        public AddFileModel(string? name, string? description, string? extension, EWolvenKitFile type, string? template)
        {
            Name = name;
            Description = description;
            FullText = $"Name: {name}, Extension: {extension}, Description: {description}";
            Extension = extension;
            Type = type;
            Template = template;
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Extension { get; set; }
        public EWolvenKitFile Type { get; set; }
        public string? Template { get; set; }

        // Just for filtering
        public string? FullText { get; init; }
    }
}
