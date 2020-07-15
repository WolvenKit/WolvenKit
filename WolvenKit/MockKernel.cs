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


        public MainViewModel GetMainViewModel() => (MainViewModel)MainVM ?? new MainViewModel();
        public RadishViewModel GetRadishViewModel() => (RadishViewModel)RadishVM ?? new RadishViewModel();
        public ImportViewModel GetImportViewModel() => (ImportViewModel)ImportVM ?? new ImportViewModel();
        public ModExplorerViewModel GetModExplorerModel() => (ModExplorerViewModel)ModExplorertVM ?? new ModExplorerViewModel();




        private Dictionary<string, ViewModel> DocumentViewModels { get; set; } = new Dictionary<string, ViewModel>();



        




    }
}
