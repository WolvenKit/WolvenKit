// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Project.cs" company="WildGums"> //TODO
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Orc.ProjectManagement;

namespace WolvenKit.App.Model
{
    public class Project : ProjectBase, IEquatable<Project>
    {
        public Project(string location)
            : base(location)
        {
        }



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
