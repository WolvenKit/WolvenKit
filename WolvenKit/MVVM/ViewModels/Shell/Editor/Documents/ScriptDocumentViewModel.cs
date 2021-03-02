using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Input;

namespace WolvenKit.ViewModels
{
    using Functionality.Commands;
    using Model;
    using Common;
    using Common.Model;
    using Common.Services;
    using CR2W;
    using CR2W.SRT;
    using CR2W.Types;
    using Radish.Model;
    using WolvenKit.Functionality.Controllers;

    public class ScriptDocumentViewModel : CloseableViewModel, Old_IDocumentViewModel
    {
        public ScriptDocumentViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            
        }

        #region Properties
        public object SaveTarget { get; set; }
        public override string Title => FileName;
        public bool IsUnsaved { get; private set; }

        public string FilePath { get; set; }
        public string FileName => Path.GetFileName(FilePath);

        #region Text
        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    var oldValue = _text;
                    _text = value;
                    RaisePropertyChanged(() => Text, oldValue, value);

                    // notify unsaved
                    IsUnsaved = true;
                    FormTitle = $"{FileName}*";
                }
            }
        }
        #endregion

        #region FormTitle
        private string _formTitle;
        public string FormTitle
        {
            get => _formTitle;
            set
            {
                if (_formTitle != value)
                {
                    var oldValue = _formTitle;
                    _formTitle = value;
                    RaisePropertyChanged(() => FormTitle, oldValue, value);
                }
            }
        }
        #endregion
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
            var enc = Encoding.Unicode;

            File.WriteAllText(FilePath, Text, enc);

            MainController.LogString(FilePath + " saved!", Logtype.Normal);

            // register all new classes
            CR2WManager.ReloadAssembly(MainController.Get().Logger);


            IsUnsaved = false;
            FormTitle = Path.GetFileName(FilePath);

            // Logging
            MainController.LogString(FileName + " saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = EProjectStatus.Ready;
        }
        #endregion


        
    }
}
