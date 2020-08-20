using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.Common.Model;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    public partial class frmOtherDocument : DockContent, IThemedContent, INotifyPropertyChanged, IWolvenkitDocument
    {
        private readonly DocumentViewModel vm;

        public frmOtherDocument(DocumentViewModel documentViewModel)
        {
            vm = documentViewModel;

            vm.ClosingRequest += (sender, e) => this.Close();
            vm.ActivateRequest += (sender, e) => this.Activate();
            vm.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();
            ApplyCustomTheme();

            

            // kinda stupid because the viewmodel lives before the form exists derp
            UpdateFormText(vm.FormText);
            UpdatePropertyGrid(vm.File);
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(vm.FormText))
            {
                Invoke(new strDelegate(UpdateFormText), (vm.FormText));
            }
            else if (e.PropertyName == nameof(vm.File))
            {
                Invoke(new wolvenkitFileDelegate(UpdatePropertyGrid), (vm.File));
            }
        }
        private delegate void strDelegate(string t);
        protected void UpdateFormText(string val) => this.Text = val;

        private delegate void wolvenkitFileDelegate(IWolvenkitFile f);
        protected void UpdatePropertyGrid(IWolvenkitFile val) => this.propertyGrid1.SelectedObject = val;

        public string FileName => vm.FileName;

        public event EventHandler<FileSavedEventArgs> OnFileSaved;
        public event PropertyChangedEventHandler PropertyChanged;


        public bool GetIsDisposed() => this.GetIsDisposed();

        public DocumentViewModel GetViewModel() => vm;

        public void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();
            
        }
    }
}
