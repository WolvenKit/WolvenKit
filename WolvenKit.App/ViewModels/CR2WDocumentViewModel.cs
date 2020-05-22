using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.App.Commands;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Radish.Model;

namespace WolvenKit.App.ViewModels
{
    public class CR2WDocumentViewModel : ViewModel
    {

        public CR2WDocumentViewModel()
        {
            LaunchQuestEditorCommand = new RelayCommand(LaunchQuestEditor, CanLaunchQuestEditor);
            FullRebuildCommand = new RelayCommand(FullRebuild, CanFullRebuild);

        }

        #region Fields
        #endregion

        #region Properties

        #region SelectedItem
        private RadishWorkflow _currentWorkflow = null;
        public RadishWorkflow CurrentWorkflow
        {
            get => _currentWorkflow;
            set
            {
                if (_currentWorkflow != value)
                {
                    _currentWorkflow = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #endregion

        #region Commands
        public ICommand LaunchQuestEditorCommand { get; }
        public ICommand FullRebuildCommand { get; }
        public ICommand RunSelectedCommand { get; }
        public ICommand BuildUntilPackCommand { get; }
        public ICommand PackCommand { get; }
        public ICommand ReCreateLinksCommand { get; }
        public ICommand StartGameCommand { get; }
        #endregion

        #region Commands Implementation
        protected bool CanLaunchQuestEditor() => RadishController.Get().IsHealthy();
        protected void LaunchQuestEditor() { }
        protected bool CanFullRebuild() => RadishController.Get().IsHealthy();
        protected void FullRebuild() { }
        protected bool CanRunSelected() => RadishController.Get().IsHealthy();
        
        #endregion

        #region Methods
        
        #endregion

    }
}
