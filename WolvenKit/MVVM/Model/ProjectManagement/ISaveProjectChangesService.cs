// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SaveChangesReason.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISaveProjectChangesService.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.MVVM.Model.ProjectManagement
{
    public enum SaveChangesReason
    {
        Refreshing,
        Closing
    }

    public interface ISaveProjectChangesService
    {
        Task<bool> EnsureChangesSavedAsync(EditorProject project, SaveChangesReason reason);
    }
}
