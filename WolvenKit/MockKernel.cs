using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.App.ViewModels;
using WolvenKit.Common;

namespace WolvenKit.App
{
    public class MockKernel : ObservableObject
    {
        private static MockKernel mainController;
        private MockKernel() { }

        public static MockKernel Get()
        {
            if (mainController == null)
            {
                mainController = new MockKernel();
            }
            return mainController;
        }

        // Singletons
        private ViewModel MainVM { get; set; }
        private ViewModel RadishVM { get; set; }
        private ViewModel ImportVM { get; set; }
        private ViewModel ModExplorertVM { get; set; }


        public MainViewModel GetMainViewModel()
        {
            if ((MainViewModel)MainVM == null)
                MainVM = new MainViewModel();
            return (MainViewModel)MainVM;
        }

        public RadishViewModel GetRadishViewModel()
        {
            if ((RadishViewModel)RadishVM == null)
                RadishVM = new RadishViewModel();
            return (RadishViewModel)RadishVM;
        }

        public ImportViewModel GetImportViewModel()
        {
            if ((ImportViewModel)ImportVM == null)
                ImportVM = new ImportViewModel();
            return (ImportViewModel)ImportVM;
        }

        public ModExplorerViewModel GetModExplorerModel()
        {
            if ((ModExplorerViewModel)ModExplorertVM == null)
                ModExplorertVM = new ModExplorerViewModel(GetMainViewModel());
            return (ModExplorerViewModel)ModExplorertVM;
        }

        private Dictionary<string, ViewModel> DocumentViewModels { get; set; } = new Dictionary<string, ViewModel>();



        




    }
}
