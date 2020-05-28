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


        #region Properties
        private ViewModel RadishVM { get; set; }
        private ViewModel ImportVM { get; set; }

        private Dictionary<string, ViewModel> DocumentViewModels { get; set; } = new Dictionary<string, ViewModel>();

        #endregion

        public ViewModel GetRadishVM() => RadishVM ?? new RadishViewModel();
        public ViewModel GetImportViewModel() => ImportVM ?? new ImportViewModel();
    }
}
