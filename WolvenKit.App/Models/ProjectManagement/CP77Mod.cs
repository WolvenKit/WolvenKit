using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Services;

public partial class ProjectManager
{
    public class CP77Mod
    {
        // Default constructor for serialization
        public CP77Mod()
        {
            
        }

        public CP77Mod(Cp77Project project)
        {
            Name = project.Name;
            ModName = project.ModName;

            Author = project.Author;
            Email = project.Email;
            Description = project.Description;
            Version = project.Version;
            ProjectColor = project.ProjectColor.ToString();

            OpenProjectFiles = project.OpenProjectFiles.OrderBy(x => x.Key)
                .Select(x => x.Value).ToList();
        }

        public string? Name { get; set; }

        public string? ModName { get; set; }

        public string? Author { get; set; }

        public string? Email { get; set; }

        public string? Description { get; set; }

        public string? Version { get; set; }

        public string? ProjectColor { get; set; }

        [XmlElement(IsNullable = true)] public List<string>? OpenProjectFiles { get; set; }

    }
}
