using System.Collections.Generic;
using WolvenKit.App.ViewModels;
using WolvenKit.Common;
using WolvenKit.App;

namespace WolvenKit
{
    /// <summary>
    /// View models
    /// </summary>
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
        private BulkEditorViewModel BulkEditVM { get; set; }
        private ModkitViewModel ModkitVM { get; set; }
        private ViewModel ImportVM { get; set; }
        private ViewModel ModExplorertVM { get; set; }


        public MainViewModel GetMainViewModel()
        {
            if ((MainViewModel)MainVM == null)
                MainVM = new MainViewModel(UIController.Get().WindowFactory);
            return (MainViewModel)MainVM;
        }

        public BulkEditorViewModel GetBulkEditorViewModel()
        {
            if ((BulkEditorViewModel)BulkEditVM == null)
                BulkEditVM = new BulkEditorViewModel(UIController.Get().WindowFactory, GetMainViewModel());
            return (BulkEditorViewModel)BulkEditVM;
        }

        public ModkitViewModel GetModkitViewModel()
        {
            if ((ModkitViewModel)ModkitVM == null)
                ModkitVM = new ModkitViewModel(UIController.Get().WindowFactory);
            return (ModkitViewModel)ModkitVM;
        }

        public RadishViewModel GetRadishViewModel()
        {
            if ((RadishViewModel)RadishVM == null)
                RadishVM = new RadishViewModel(UIController.Get().WindowFactory);
            return (RadishViewModel)RadishVM;
        }

        public ImportViewModel GetImportViewModel()
        {
            if ((ImportViewModel)ImportVM == null)
                ImportVM = new ImportViewModel(UIController.Get().WindowFactory);
            return (ImportViewModel)ImportVM;
        }

        public ModExplorerViewModel GetModExplorerModel()
        {
            if ((ModExplorerViewModel)ModExplorertVM == null)
                ModExplorertVM = new ModExplorerViewModel(UIController.Get().WindowFactory, GetMainViewModel());
            return (ModExplorerViewModel)ModExplorertVM;
        }

        private Dictionary<string, ViewModel> DocumentViewModels { get; set; } = new Dictionary<string, ViewModel>();



        




    }
}
