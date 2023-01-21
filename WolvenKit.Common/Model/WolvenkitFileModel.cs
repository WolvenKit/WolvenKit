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

    public record AddFileModel(string Name, string Description, string Extension, EWolvenKitFile Type, string Template);
}
