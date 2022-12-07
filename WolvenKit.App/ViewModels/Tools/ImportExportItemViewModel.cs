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

        public EExportState ExportState => CanImport(BaseFile) ? EExportState.Importable : EExportState.Exportable;

        private static bool CanImport(string x)
        {
            var ext = Path.GetExtension(x).TrimStart('.');

            if (!Enum.TryParse<ERawFileFormat>(ext, out var _))
            {
                return false;
            }

            var dbg_disabled = new List<string>()
                {
                    "bmp",
                    "jpg",
                    //"png",
                    //"tga",
                    "tiff",
                };

            return !dbg_disabled.Contains(ext);
        }
    }
}
