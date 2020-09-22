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
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    public partial class frmOtherDocument : DockContent, IThemedContent, INotifyPropertyChanged, IWolvenkitView
    {
        private readonly CommonDocumentViewModel vm;

        public frmOtherDocument(CommonDocumentViewModel documentViewModel)
        {
            vm = documentViewModel;

            vm.ClosingRequest += (sender, e) => this.Close();
            vm.ActivateRequest += (sender, e) => this.Activate();
            vm.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();
            ApplyCustomTheme();

            UpdatePropertyGrid(vm.File);
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(vm.FormText))
            //{
            //    Invoke(new strDelegate(UpdateFormText), (vm.FormText));
            //}
            /*else*/ if (e.PropertyName == nameof(vm.File))
            {
                Invoke(new wolvenkitFileDelegate(UpdatePropertyGrid), (vm.File));
            }
        }
        private delegate void strDelegate(string t);
        protected void UpdateFormText(string val) => this.Text = val;

        private delegate void wolvenkitFileDelegate(IWolvenkitFile f);
        protected void UpdatePropertyGrid(IWolvenkitFile val) => this.propertyGrid.SelectedObject = val;

        public string FileName => vm.FileName;

        public event EventHandler<FileSavedEventArgs> OnFileSaved;
        public event PropertyChangedEventHandler PropertyChanged;


        //public bool GetIsDisposed() => this.IsDisposed;

        public IDocumentViewModel GetViewModel() => vm;

        public void ApplyCustomTheme()
        {
            Color background = UIController.GetBackColor();
            Color highlight = UIController.GetHighlightColor();
            Color textStyle = UIController.GetForeColor();

            // propertygrid
            // backgrounds
            propertyGrid.HelpBackColor = background;
            propertyGrid.ViewBackColor = background;
            propertyGrid.HelpForeColor = textStyle;
            propertyGrid.ViewForeColor = textStyle;
            propertyGrid.CategoryForeColor = textStyle;
            // highlighted
            propertyGrid.BackColor = highlight;
            propertyGrid.CategorySplitterColor = highlight;
            propertyGrid.LineColor = highlight;
        }
    }
}
