using System;
using System.Collections.Generic;
using System.IO;
using HelixToolkit.SharpDX.Core.Model;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ReactiveObject, ISelectableViewModel
    {
        /// <summary>
        /// BaseFile "FileModel"
        /// </summary>
        protected string BaseFile { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        [Reactive] public ImportExportArgs Properties { get; set; }

        public string ExportTaskIdentifier => Properties.ToString();

        public string Extension => Path.GetExtension(BaseFile).TrimStart('.');
        public string FullName => BaseFile;
        public string Name => Path.GetFileName(BaseFile);

        [Reactive] public bool IsChecked { get; set; }
    }
}
