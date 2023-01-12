using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
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
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class NewFileViewModel : DialogViewModel
    {

        public delegate Task ReturnHandler(NewFileViewModel file);
        public ReturnHandler FileHandler;

        public NewFileViewModel()
        {
            OkCommand = ReactiveCommand.Create(() =>
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

#pragma warning disable IDE0053 // Use expression body for lambda expressions
            CancelCommand = ReactiveCommand.Create(() => { FileHandler(null); });
#pragma warning restore IDE0053 // Use expression body for lambda expressions

            Title = "Create new file";

            try
            {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"WolvenKit.App.Resources.WolvenKitFileDefinitions.xml");

                XmlSerializer serializer = new(typeof(WolvenKitFileDefinitions));
                var newdef = (WolvenKitFileDefinitions)serializer.Deserialize(stream);
                foreach (ERedExtension ext in Enum.GetValues(typeof(ERedExtension)))
                {
                    if (CommonFunctions.GetResourceClassesFromExtension(ext) is not null)
                    {
                        var resourceFiles = newdef.Categories.FirstOrDefault(x => x.Name == "CR2W Files");
                        resourceFiles.Files.Add(new AddFileModel()
                        {
                            Name = CommonFunctions.GetResourceClassesFromExtension(ext),
                            Description = $"A .{ext} File",
                            Extension = ext.ToString(),
                            Type = EWolvenKitFile.Cr2w,
                            Template = ""
                        });
                    }
                }

                var ordered = newdef.Categories.FirstOrDefault(x => x.Name == "CR2W Files").Files.OrderBy(x => x.Name).ToList();
                newdef.Categories.FirstOrDefault(x => x.Name == "CR2W Files").Files = ordered;
                Categories = new ObservableCollection<FileCategoryModel>(newdef.Categories);

                SelectedCategory = Categories.FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


            this.WhenAnyValue(x => x.SelectedFile)
                .WhereNotNull()
                .Subscribe(x =>
                {
                    var project = Locator.Current.GetService<IProjectManager>().ActiveProject;
                    var sep = Path.DirectorySeparatorChar;
#pragma warning disable IDE0072 // Add missing cases
                    FileName = SelectedFile.Type switch
                    {
                        EWolvenKitFile.RedScript => $"r6{sep}scripts{sep}{project.Name}{sep}untitled.{x.Extension.ToLower()}",
                        EWolvenKitFile.CETLua => $"bin{sep}x64{sep}plugins{sep}cyber_engine_tweaks{sep}mods{sep}{project.Name}{sep}init.{x.Extension.ToLower()}",
                        _ => x is not null ? $"{x.Name.Split(' ').First()}1.{x.Extension.ToLower()}" : null,
                    };
#pragma warning restore IDE0072 // Add missing cases
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

        public override ReactiveCommand<Unit, Unit> OkCommand { get; }
        public override ReactiveCommand<Unit, Unit> CancelCommand { get; }
        [Reactive] public string WhyNotCreate { get; set; }

        private string GetDefaultDir(EWolvenKitFile type)
        {
            var project = Locator.Current.GetService<IProjectManager>().ActiveProject;
            return type switch
            {
                EWolvenKitFile.TweakXl => project.ResourcesDirectory,
                EWolvenKitFile.Cr2w => project.ModDirectory,
                EWolvenKitFile.ArchiveXl => project.ResourcesDirectory,
                EWolvenKitFile.RedScript => project.ResourcesDirectory,
                EWolvenKitFile.CETLua => project.ResourcesDirectory,
                EWolvenKitFile.WScript => throw new NotImplementedException(),
                _ => throw new ArgumentOutOfRangeException(nameof(type)),
            };
        }
    }




}
