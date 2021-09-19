using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using System.Xml.Serialization;
using System.Reflection;

namespace WolvenKit.ViewModels.Dialogs
{
    public class NewFileViewModel : DialogViewModel
    {
        public NewFileViewModel()
        {
            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(() => { });
            CancelCommand = ReactiveCommand.Create(() => { });

            Title = "Add new file";

            try
            {
                var serializer = new XmlSerializer(typeof(WolvenKitFileDefinitions));
                using (var stream = Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream(@"WolvenKit.App.Resources.WolvenKitFileDefinitions.xml"))
                {
                    var newdef = (WolvenKitFileDefinitions)serializer.Deserialize(stream);
                    Categories = new ObservableCollection<FileCategoryModel>(newdef.Categories);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           

            this.WhenAnyValue(x => x.SelectedFile)
                .Subscribe(x =>
            {
                if (x != null)
                {
                    FileName = $"{x.Name.Split(' ').First()}1.{x.Extension.ToLower()}";
                }
            });
        }


        [Reactive] public string Text { get; set; }

        [Reactive] public string FileName { get; set; }

        public sealed override string Title { get; set; }

        public sealed override ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> OkCommand { get; set; }


        [Reactive] public ObservableCollection<FileCategoryModel> Categories { get; set; } = new();

        [Reactive] public FileCategoryModel SelectedCategory { get; set;  }

        [Reactive] public AddFileModel SelectedFile { get; set; }








    }

   

    
}
