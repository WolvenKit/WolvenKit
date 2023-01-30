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
            Author = project.Author;
            Email = project.Email;
            Name = project.Name;
            Version = project.Version;
        }

        public string? Author { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }

        public string? Version { get; set; }
        public bool IsRedMod { get; set; }
        public bool ExecuteDeploy { get; set; }
    }
}
