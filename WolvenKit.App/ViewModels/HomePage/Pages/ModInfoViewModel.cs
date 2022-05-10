using System.IO;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.HomePage
{
    public class ModInfoViewModel : ReactiveObject
    {
        public ModInfoViewModel(ModInfo mod, string folder)
        {
            Mod = mod;
            Folder = folder;

            RemoveCommand = ReactiveCommand.Create(() => Remove());
        }

        public ModInfo Mod { get; init; }

        public string Folder { get; init; }

        [Reactive] public int LoadOrder { get; set; }

        public bool IsEnabled { get; set; }

        public string Name => Mod.Name;

        public ICommand RemoveCommand { get; private set; }
        private void Remove()
        {
            try
            {
                var folderPath = Path.Combine(Folder);
                Directory.Delete(folderPath, true);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
