// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Project.cs" company="WildGums"> //TODO
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Orc.ProjectManagement;

namespace WolvenKit.App.Model
{
    public abstract class Project : ProjectBase, IEquatable<Project>
    {
        protected Project(string location)
            : base(location)
        {

        }

        #region fields

        private bool _isInitialized;

        #endregion

        #region properties
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public abstract bool IsInitialized { get; }


        [Category("About")]
        [Description("The name of your mod.")]
        public string Name { get; set; }

        [Category("About")]
        [Description("The name of your mod.")]
        public string Author { get; set; }

        [Category("About")]
        [Description("The name of your mod.")]
        public string Email { get; set; }

        [Browsable(false)]
        [Category("About")]
        [Description("The version of your mod. It's a string so 0.1-ALPHA and such is possible.")]
        public string Version { get; set; } = "0.62";


        #region not serialized

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string ProjectDirectory => Path.Combine(Path.GetDirectoryName(Location), Name);

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string FileDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "files");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

        #endregion

        #endregion

        #region Methods

        
        public abstract Task Initialize();
        public abstract void Check();
        #endregion

        #region implements IEquatable
        public bool Equals( Project other)
        {
            if (ReferenceEquals(null, other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return string.Equals(Location, other.Location);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((Project)obj);
        }

        public override int GetHashCode()
        {
            return (Location != null ? Location.GetHashCode() : 0);
        }
        #endregion

        public void SetIsDirty(bool isDirty)
        {
            IsDirty = isDirty;
        }

        public override string ToString()
        {
            //TODO: serialize?
            throw new NotImplementedException();
        }
    }

}
