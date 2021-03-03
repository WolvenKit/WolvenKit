using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Orc.ProjectManagement;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.MVVM.Model.ProjectManagement.Project
{
    public abstract class EditorProject : ProjectBase, IEquatable<EditorProject>
    {
        #region Fields

        public EditorProjectData Data;

        #endregion Fields

        #region Constructors

        protected EditorProject(string location)
                    : base(location)
        {
        }

        protected EditorProject() : base("")
        {
        }

        #endregion Constructors



        #region Methods

        public abstract void Load(string path);

        public abstract void Save(string path);

        #endregion Methods

        #region properties

        [XmlIgnore]
        public GameType GameType;

        [Category("About")]
        [Description("The name of your mod.")]
        public string Author { get; set; }

        [Category("About")]
        [Description("Your contact email.")]
        public string Email { get; set; }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public abstract bool IsInitialized { get; }

        [Category("About")]
        [Description("The name of your mod.")]
        public string Name { get; set; }

        [Browsable(false)]
        [Category("About")]
        [Description("The version of your mod. It's a string so 0.1-ALPHA and such is possible.")]
        public string Version { get; set; } = "0.62";

        #region not serialized

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string FileDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "files");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public List<string> Files
        {
            get
            {
                if (!Directory.Exists(FileDirectory))
                {
                    Directory.CreateDirectory(FileDirectory);
                }
                return Directory.EnumerateFiles(FileDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file[(FileDirectory.Length + 1)..])
                    .ToList();
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string ProjectDirectory => Path.Combine(Path.GetDirectoryName(Location), Name);

        #endregion not serialized

        #endregion properties



        #region Methods

        public abstract void Check();

        public abstract Task Initialize();

        #endregion Methods

        #region implements IEquatable

        public bool Equals(EditorProject other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(Location, other.Location);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((EditorProject)obj);
        }

        public override int GetHashCode() => Location != null ? Location.GetHashCode() : 0;

        #endregion implements IEquatable

        public void SetIsDirty(bool isDirty) => IsDirty = isDirty;

        public override string ToString() => Location;
    }
}
