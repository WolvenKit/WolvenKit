using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.App.ViewModels;

namespace WolvenKit.App
{
    public class MockKernel : INotifyPropertyChanged
    {
        private static MockKernel mainController;
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel RadishVM { get; set; }


        private MockKernel() { }

        public static MockKernel Get()
        {
            if (mainController == null)
            {
                mainController = new MockKernel();
            }
            return mainController;
        }

        public ViewModel GetRadishVM()
        {
            if (RadishVM == null)
            {
                RadishVM = new RadishViewModel(MainController.Get().Logger);
            }
            return RadishVM;
        }


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
