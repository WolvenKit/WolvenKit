using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Services;

public partial class ProjectManager
{
    public class CP77Mod
    {
        // Default contructor for serialization
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
        }

        public string? Name { get; set; }

        public string? ModName { get; set; }


        public string? Author { get; set; }

        public string? Email { get; set; }

        public string? Description { get; set; }

        public string? Version { get; set; }
    }
}
