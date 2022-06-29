using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Input;
using Prism.Commands;
using ReactiveUI;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Functionality.Commands;
using WolvenKit.Interaction;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Models
{
    public class FileModel : ReactiveObject
    {
        private readonly string _extension = ".default";

        public const string s_moddir = "wkitmoddir";

        public const string s_rawdir = "wkitrawdir";

        public FileModel(string path, EditorProject project)
        {
            FullName = path;
            Project = project;
            string parentfullname;
            if (Directory.Exists(path))
            {
                IsDirectory = true;
                var di = new DirectoryInfo(path);
                parentfullname = di.Parent.FullName;
                Name = di.Name;
                _extension = ECustomImageKeys.OpenDirImageKey.ToString();
                if (project is Cp77Project cpp)
                {
                    if (FullName.StartsWith(cpp.ModDirectory))
                    {
                        _extension = "ModDirectoryTop";
                    }
                    else if (FullName.ToLower().StartsWith(cpp.RawDirectory.ToLower()))
                    {
                        _extension = "RawDirectoryTop";
                    }
                    else if (FullName.StartsWith(cpp.ScriptDirectory))
                    {
                        _extension = "ScriptDirectoryTop";
                    }
                    else if (FullName.StartsWith(cpp.TweakDirectory))
                    {
                        _extension = "TweakDirectoryTop";
                    }
                }
            }
            else if (File.Exists(path))
            {
                IsDirectory = false;
                var fi = new FileInfo(path);
                parentfullname = fi.Directory.FullName;
                Name = fi.Name;
                _extension = fi.Extension;
                if (project is Cp77Project cpp)
                {
                    if (FullName.StartsWith(cpp.TweakDirectory) && _extension == "bin")
                    {
                        _extension = "tweak";
                    }
                }
                /*if (_extension == "")
                {
                    var guessedExtensions = FileTypeHelper.GetFileExtensions(FullName);
                    if (guessedExtensions.Length == 1)
                    {
                        _extension = guessedExtensions[0];
                    }
                }*/
            }
            else
            {
                throw new FileNotFoundException();
            }

            Hash = GenerateKey(FullName, project);
            ParentHash = GenerateKey(parentfullname, project);
            RelativePath = GetRelativeName(FullName, project);
            OpenFileCommand = new DelegateCommand(ExecuteOpenFile);
            DeleteFileCommand = new DelegateCommand(ExecuteDeleteFile);
            RenameFileCommand = new DelegateCommand(ExecuteRenameFile, CanRenameFile).ObservesProperty(() => IsDirectory);
        }

        #region properties

        [Display(Name = "System Path")] public string FullName { get; }

        [Display(Name = "Relative Path")] public string RelativePath { get; }

        public string Name { get; }

        public string Extension => GetExtension();

        [Display(Name = "Hash")] public string HashStr => Hash.ToString();


        [Browsable(false)] public EditorProject Project { get; }

        [Browsable(false)] public ulong Hash { get; }

        [Browsable(false)] public bool IsDirectory { get; }

        [Browsable(false)] public ulong ParentHash { get; }

        [Browsable(false)] public bool IsExpanded { get; set; }

        [Browsable(false)]
        public bool IsConvertable => !IsDirectory
                                                       && !string.IsNullOrEmpty(GetExtension())
                                                       && Enum.GetNames(typeof(EConvertableFileFormat)).Contains(GetExtension());
        [Browsable(false)]
        public bool IsImportable
        {
            get
            {
                var ext = GetExtension();
                var dbg_disabled = new List<string>()
                {
                    "bmp",
                    "jpg",
                    //"png",
                    //"tga",
                    "tiff",
                };

                return !IsDirectory
              && !string.IsNullOrEmpty(ext)
              && Enum.GetNames(typeof(ERawFileFormat)).Contains(ext)
              && !dbg_disabled.Contains(ext);
            }
        }

        [Browsable(false)]
        public bool IsExportable => !IsDirectory
                                                       && !string.IsNullOrEmpty(GetExtension())
                                                       && Enum.GetNames(typeof(ECookedFileFormat)).Contains(GetExtension());

        #endregion

        public string GetExtension() => _extension.TrimStart('.');

        public override int GetHashCode() => (int)Hash;

        public ulong GetRedHash(EditorProject project) => FNV1A64HashAlgorithm.HashString(GetRelativeName(FullName, project));

        public static string GetRelativeName(string FullName, EditorProject project)
        {
            if (project == null)
            {
                return FullName;
            }

            var filedir = project.FileDirectory;
            var moddir = project.ModDirectory;
            var rawDirectory = project.RawDirectory;
            var packedDir = project.PackedRootDirectory;

            if (FullName.Equals(filedir, StringComparison.Ordinal))
            {
                return "";
            }
            // hack so that we get proper hashes
            if (FullName.Equals(moddir, StringComparison.Ordinal))
            {
                return s_moddir;
            }
            if (FullName.Equals(rawDirectory, StringComparison.Ordinal))
            {
                return s_rawdir;
            }
            if (FullName.Equals(packedDir, StringComparison.Ordinal))
            {
                return "wkitpackeddir";
            }

            if (FullName.StartsWith(moddir, StringComparison.Ordinal))
            {
                return FullName[(moddir.Length + 1)..];
            }
            if (FullName.StartsWith(rawDirectory, StringComparison.Ordinal))
            {
                var rel = FullName[(rawDirectory.Length + 1)..];
                return rel;
            }

            if (FullName.StartsWith(filedir, StringComparison.Ordinal))
            {
                return FullName[(filedir.Length + 1)..];
            }

            if (FullName.StartsWith(packedDir, StringComparison.Ordinal))
            {
                return FullName[(packedDir.Length + 1)..];
            }

            return FullName;
            //throw new System.NullReferenceException("fuzzy exception");
        }

        public static ulong GenerateKey(string fullname, EditorProject project)
        {
            if (project == null)
            {
                return 0;
            }

            if (fullname.Equals(project.FileDirectory, StringComparison.Ordinal))
            {
                return 0;
            }
            else if (fullname.Equals(project.PackedRootDirectory, StringComparison.Ordinal))
            {
                return 0;
            }
            else
            {
                if (fullname.StartsWith(project.ModDirectory))
                {
                    var tmpName = Path.GetRelativePath(project.ModDirectory, fullname);
                    if (tmpName != ".")
                    {
                        if (ulong.TryParse(tmpName, out var hash))
                        {
                            return hash;
                        }
                        return FNV1A64HashAlgorithm.HashString(tmpName);
                    }
                }

                return FNV1A64HashAlgorithm.HashString(fullname);
            }
        }

        [Browsable(false)] public ICommand OpenFileCommand { get; private set; }
        private bool CanOpenFile() => true;
        private void ExecuteOpenFile() => Locator.Current.GetService<AppViewModel>().OpenFileCommand.SafeExecute(this);

        /// <summary>
        /// Delets selected node.
        /// </summary>
        [Browsable(false)] public ICommand DeleteFileCommand { get; private set; }
        private bool CanDeleteFile() => true;
        private async void ExecuteDeleteFile()
        {
            var delete = await Interactions.DeleteFiles.Handle(new List<string>() { Name });
            if (!delete)
            {
                return;
            }

            // Delete from file structure
            var fullpath = FullName;
            try
            {
                if (IsDirectory)
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(fullpath
                        , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                        , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
                else
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(fullpath
                        , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                        , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
            }
            catch (Exception)
            {
                //_loggerService.Error("Failed to delete " + fullpath + ".\r\n");
            }
        }


        /// <summary>
        /// Renames selected node.
        /// </summary>
        [Browsable(false)] public ICommand RenameFileCommand { get; private set; }
        private bool CanRenameFile() => !IsDirectory;
        private async void ExecuteRenameFile()
        {
            var filename = FullName;
            var newfilename = await Interactions.Rename.Handle(filename);

            if (string.IsNullOrEmpty(newfilename))
            {
                return;
            }

            var newfullpath = Path.Combine(Path.GetDirectoryName(filename), newfilename);

            if (File.Exists(newfullpath))
            {
                return;
            }

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(newfullpath));
                if (IsDirectory)
                {
                    Directory.Move(filename, newfullpath);
                }
                else
                {
                    File.Move(filename, newfullpath);
                }
            }
            catch
            {
            }


        }

    }
}
