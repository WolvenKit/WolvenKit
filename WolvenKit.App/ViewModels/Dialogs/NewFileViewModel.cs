using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Functionality.Services;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.ViewModels.Dialogs
{
    public class NewFileViewModel : DialogViewModel
    {

        public delegate Task ReturnHandler(NewFileViewModel file);
        public ReturnHandler FileHandler;

        public NewFileViewModel()
        {
            CreateCommand = ReactiveCommand.Create(() =>
            {
                IsCreating = true;
                FileHandler(this);
            }, this.WhenAnyValue(
                x => x.FileName, x => x.FullPath, x => x.IsCreating,
                (file, path, isCreating) =>
                    !isCreating &&
                    file is not null &&
                    !string.IsNullOrEmpty(file) &&
                    !File.Exists(path)));

            CancelCommand = ReactiveCommand.Create(() => FileHandler(null));

            Title = "Create new file";

            try
            {
                var serializer = new XmlSerializer(typeof(WolvenKitFileDefinitions));
                using var stream = Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream(@"WolvenKit.App.Resources.WolvenKitFileDefinitions.xml");
                var newdef = (WolvenKitFileDefinitions)serializer.Deserialize(stream);
                foreach (ERedExtension ext in Enum.GetValues(typeof(ERedExtension)))
                {
                    if (CommonFunctions.GetResourceClassesFromExtension(ext) is not null)
                    {
                        newdef.Categories[2].Files.Add(new AddFileModel()
                        {
                            Name = CommonFunctions.GetResourceClassesFromExtension(ext),
                            Description = $"A .{ext} File",
                            Extension = ext.ToString(),
                            Type = EWolvenKitFile.Cr2w,
                            Template = ""
                        });
                    }
                }
                Categories = new ObservableCollection<FileCategoryModel>(newdef.Categories);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //CanCreate = Observable.Empty<bool>().StartsWith(false);

            //=> FileName != null && !string.IsNullOrEmpty(FileName) && !File.Exists(FullPath);


            this.WhenAnyValue(x => x.SelectedFile)
                .Subscribe(x =>
                {
                    if (x is not null)
                    {
                        FileName = $"{x.Name.Split(' ').First()}1.{x.Extension.ToLower()}";
                    }
                    else
                    {
                        FileName = null;
                    }
                });
            this.WhenAnyValue(x => x.FileName)
                .Subscribe(x =>
                {
                    if (SelectedFile is not null && x is not null)
                    {
                        FullPath = Path.Combine(GetDefaultDir(SelectedFile.Type), x);
                        WhyNotCreate = File.Exists(FullPath) ? "Filename already in use" : "";
                    }
                    else
                    {
                        WhyNotCreate = "";
                    }
                });
        }

        [Reactive] public string Text { get; set; }

        [Reactive] public bool IsCreating { get; set; }

        [Reactive] public string FileName { get; set; }
        [Reactive] public string FullPath { get; set; }

        public string Title { get; set; }

        [Reactive] public ObservableCollection<FileCategoryModel> Categories { get; set; } = new();

        [Reactive] public FileCategoryModel SelectedCategory { get; set; }

        [Reactive] public AddFileModel SelectedFile { get; set; }

        public ICommand CreateCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }
        [Reactive] public string WhyNotCreate { get; set; }
        //private async Task ExecuteCreate()
        //{

        //    //var fullPath = string.IsNullOrEmpty(inputDir)
        //    //? Path.Combine(GetDefaultDir(SelectedFile.Type), filename)
        //    //: Path.Combine(inputDir, filename);

        //    switch (SelectedFile.Type)
        //    {
        //        case EWolvenKitFile.Redscript:
        //        case EWolvenKitFile.Tweak:
        //            if (!string.IsNullOrEmpty(SelectedFile.Template))
        //            {
        //                await using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"WolvenKit.App.Resources.{SelectedFile.Template}"))
        //                {
        //                    using var fileStream = new FileStream(FullPath, FileMode.Create, FileAccess.Write);
        //                    resource.CopyTo(fileStream);
        //                }
        //            }
        //            else
        //            {
        //                File.Create(FullPath);
        //            }
        //            break;
        //        case EWolvenKitFile.Cr2w:
        //            //CreateCr2wFile(SelectedFile);
        //            break;
        //    }

        //    // Open file
        //    await Locator.Current.GetService<AppViewModel>().RequestFileOpen(FullPath);
        //}

        private string GetDefaultDir(EWolvenKitFile type)
        {
            var project = Locator.Current.GetService<IProjectManager>().ActiveProject as Cp77Project;
            return type switch
            {
                EWolvenKitFile.Redscript => project.ScriptDirectory,
                EWolvenKitFile.Tweak => project.TweakDirectory,
                EWolvenKitFile.Cr2w => project.ModDirectory,
                _ => throw new ArgumentOutOfRangeException(nameof(type)),
            };
        }
    }




}
