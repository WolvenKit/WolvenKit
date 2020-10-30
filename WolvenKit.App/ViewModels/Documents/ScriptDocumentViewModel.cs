using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.SRT;
using WolvenKit.CR2W.Types;
using WolvenKit.Radish.Model;

namespace WolvenKit.App.ViewModels
{
    public class ScriptDocumentViewModel : CloseableViewModel, IDocumentViewModel
    {
        public ScriptDocumentViewModel()
        {
            
        }

        #region Fields
        public event EventHandler<FileSavedEventArgs> OnFileSaved;
        #endregion

        #region Properties
        public object SaveTarget { get; set; }
        public string Title => FileName;
        public bool IsUnsaved { get; set; }

        public string FilePath { get; set; }
        public string FileName => Path.GetFileName(FilePath);

        public string Text { get; set; }
        public string FormTitle { get; set; }
        #endregion



        #region Commands

        #endregion

        #region Commands Implementation

        #endregion

        #region Methods
        

        public void SaveFile()
        {
            MainController.Get().ProjectStatus = EProjectStatus.Busy;
            // encode in UTF-16LE
            Encoding enc = Encoding.Unicode;

            File.WriteAllText(FilePath, Text, enc);

            //using (var streamWriter = File.AppendText(FilePath))
            //{
            //    streamWriter.Write(scintillaControl.Text);
            //}
            MainController.LogString(FilePath + " saved!", Logtype.Normal);

            // register all new classes
            CR2WManager.ReloadAssembly();


            IsUnsaved = false;
            FormTitle = Path.GetFileName(FilePath);

            // Logging
            MainController.LogString(FileName + " saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = EProjectStatus.Ready;
        }









        #endregion


        
    }
}
