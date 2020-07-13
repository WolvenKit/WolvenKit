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
using WolvenKit.Common.Model;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    public partial class frmOtherDocument : DockContent, IThemedContent, INotifyPropertyChanged, IWolvenkitDocument
    {
        

        public frmOtherDocument()
        {
            InitializeComponent();




        }



        public object SaveTarget { get; set; }

        private IWolvenkitFile file;
        public IWolvenkitFile File
        {
            get => file; set
            {
                file = value;

                //update propertygrid
                propertyGrid1.SelectedObject = file;
                this.Text = Path.GetFileName(FileName);
            }
        }

        public string FileName => File.FileName;

        public event EventHandler<FileSavedEventArgs> OnFileSaved;
        public event PropertyChangedEventHandler PropertyChanged;

        public void ApplyCustomTheme()
        {
            throw new NotImplementedException();
        }

        public void SaveFile()
        {
            if (SaveTarget == null)
                SaveToFileName();
            else
                SaveToMemoryStream();
        }

        private void SaveToMemoryStream()
        {
            using (var mem = new MemoryStream())
            using (var writer = new BinaryWriter(mem))
            {
                File.Write(writer);

                OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = FileName, Stream = mem, File = File });
            }
        }

        private void SaveToFileName()
        {
            using (var mem = new MemoryStream())
            using (var writer = new BinaryWriter(mem))
            {
                File.Write(writer);
                mem.Seek(0, SeekOrigin.Begin);

                using (var fs = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    mem.WriteTo(fs);

                    OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = FileName, Stream = fs, File = File });
                }
            }
        }

        //public bool GetIsDisposed() => this.GetIsDisposed();
    }
}
