using System;
using System.Collections;
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
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Radish.Model;

namespace WolvenKit.App.ViewModels
{
    public class BulkEditOptions
    {
        public enum AvailableTypes
        { 
            ANY, 
            CUInt64, 
            CUInt32, 
            CUInt16, 
            CUInt8,
            CInt64, 
            CInt32, 
            CInt16, 
            CInt8,
            CBool, 
            CString
        }

        // Required
        [Description("Specify the variable name. \n\r" +
            "Example: autohidedistance")]
        [Category("Is Required")]
        public string Name { get; set; }

        [Description("Specify the new variable value. \n\r" +
            "Example: 9999")]
        [Category("Is Required")]
        public string Value { get; set; }

        [Description("Specify the chunk name. \n\r" +
    "Example: CMesh")]
        [Category("Is Required")]
        public string ChunkName { get; set; }




        // Optional string
        [Description("Specify the file extensions to edit. \n\r" +
            "Example: w2mesh,w2l,xbm")]
        public string Extension { get; set; }

        [Description("Specify the variable type. \n\r" +
            "Available types are Bool, Uint64, Int64, Uint32, Int32, Uint16, Int16, Uint8, Int8")]
        public AvailableTypes Type { get; set; }

        //[Option('o', HelpText = "Specify the option type. Default is replace. This option requires a valid type to be set with -t !!\n\r" +
        //   "Available types are Multiplication (*), Division (/), Addition (+), Subtraction (-),\n\r" +
        //    "Example: -o + -t Uint16\n\r" +
        //    "Example: -o / -t Int32"
        //   , Required = false)]
        //public string option { get; set; }

        // Optional lists
        [Description("Exclude the following values.\n\r" +
            "Example: 0,64,1028,2053")]
        public string Exclude { get; set; }

        [Description("Include only the following values.\n\r" +
            "Example: 0,32,64")]
        public string Include { get; set; }
    }

    public class ProgressReport : ObservableObject
    {
        #region Min
        private int _min;
        public int Min
        {
            get => _min;
            set
            {
                if (_min != value)
                {
                    _min = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region Max
        private int _max;
        public int Max
        {
            get => _max;
            set
            {
                if (_max != value)
                {
                    _max = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region Value
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        public ProgressReport()
        {

        }

        public ProgressReport(ProgressReport old)
        {
            Min = old.Min;
            Max = old.Max;
            Value = old.Value;
        }
    }

    public class BulkEditorViewModel : ViewModel
    {
        

        public BulkEditorViewModel()
        {
            Logger = MainController.Get().Logger;
            

            RunCommand = new RelayCommand(Run, CanRun);
            Options = new BulkEditOptions();


            ProgressReport = new ProgressReport();
        }

        public event EventHandler PerformStep;
        protected void OnPerformStepRequest() => this.PerformStep?.Invoke(this, new EventArgs());
        public event EventHandler Reset;
        protected void OnResetRequest() => this.PerformStep?.Invoke(this, new EventArgs());

        #region Fields
        private /*readonly*/ LoggerService Logger;

        #endregion

        #region Properties
        public BulkEditOptions Options { get; set; }

        #region ProgressReport
        private ProgressReport _progressReport;
        public ProgressReport ProgressReport
        {
            get => _progressReport;
            set
            {
                if (_progressReport != value)
                {
                    _progressReport = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #endregion

        #region Commands
        public ICommand RunCommand { get; }

        #endregion

        #region Commands Implementation
        protected bool CanRun()
        {
            if (WolvenKit.App.MockKernel.Get().GetMainViewModel().OpenDocuments.Any())
            {
                Logger.LogString("Please close all open documents before running the bulk editor.", Logtype.Error);
                return false;
            }
            if (!(Options.Name != null && Options.Value != null && Options.ChunkName != null))
            {
                Logger.LogString("Please fill in all required variables.", Logtype.Error);
                return false;
            }
            return true;
        }

        protected async void Run()
        {
            await Task.Run(() => RunBulkEditInternal(Options));
        }

        #endregion

        #region Methods
        public async Task<int> RunBulkEditInternal(BulkEditOptions opts)
        {
            if (Logger == null)
                Logger = MainController.Get().Logger;

            if (MainController.Get().ActiveMod == null)
                return 0;
            List<string> files = MainController.Get().ActiveMod.Files;
            if (opts.Extension != null)
                files = MainController.Get().ActiveMod.Files.Where(_ => Path.GetExtension(_).Contains(opts.Extension)).ToList();

            Logger.LogString($"Starting Bulk edit. Found {files.Count} files to edit. \r\n", Logtype.Success);
            ProgressReport.Max = files.Count;
            ProgressReport.Min = 0;
            ProgressReport.Value = 0;
            ProgressReport = new ProgressReport(ProgressReport);


            foreach (var path in files)
            {
                var fullpath = Path.Combine(MainController.Get().ActiveMod.FileDirectory, path);

                CR2WFile cr2w;
                using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    cr2w = new CR2WFile(reader);
                    fs.Close();
                }

                await Task.Run(() => EditVariablesInFile(path, cr2w, opts))
                    .ContinueWith(antecedent =>
                    {
                        using (var fs = new FileStream($"{fullpath}", FileMode.Create, FileAccess.ReadWrite))
                        using (var writer = new BinaryWriter(fs))
                        {
                            cr2w.Write(writer);
                        }
                        // logging
                        Logger.LogString($"Finished {path}.\r\n", Logtype.Success);
                        OnPerformStepRequest();
                    });
            }

            return 0;
        }

        private void EditVariablesInFile(string path, CR2WFile file, BulkEditOptions opts)
        {
            if (file == null)
                return;
            if (opts.ChunkName != null && !file.chunks.Any(_ => opts.ChunkName.Contains(_.REDType)))
                return;

            List<string> excludedvalues = opts.Exclude == null ? new List<string>() : opts.Exclude.Split(',').ToList();
            List<string> includedvalues = opts.Include == null ? new List<string>() : opts.Include.Split(',').ToList();

            // get chunks that match chunkname
            List<CR2WExportWrapper> chunks = opts.ChunkName != null ? file.chunks.Where(_ => _.data.GetType().Name == opts.ChunkName).ToList() : file.chunks;

            foreach (var chunk in chunks.Select(_ => _.data))
            {
                CheckProperties(chunk);
            }

            void CheckProperties(CVariable cvar)
            {
                // edit lists
                if (cvar is IList && cvar.GetType().IsGenericType)
                {
                    foreach (var listitem in (cvar as IList))
                    {
                        if (listitem is CVariable clistitem)
                            CheckProperties(clistitem);
                    }
                }
                else
                {
                    // try to set the value in the class
                    TrySetValue(cvar);

                    // goes through all properties
                    var props = cvar.GetEditableVariables();
                    foreach (var prop in props)
                    {
                        if (prop is CVariable cprop)
                        {
                            CheckProperties(cprop);
                        }
                    }
                }
            }

            void TrySetValue(CVariable cvar)
            {
                var propnameslist = cvar.accessor.GetMembers().Select(_ => _.Name).ToList();
                if (propnameslist.Contains(opts.Name))
                {
                    try
                    {
                        // check if type is supported
                        var proptoedit = cvar.GetEditableVariables().First(_ => _.REDName == opts.Name) as CVariable;
                        if (Enum.GetValues(typeof(BulkEditOptions.AvailableTypes))
                                .Cast<BulkEditOptions.AvailableTypes>()
                                .Select(_ => _.ToString())
                                .Contains(proptoedit.GetType().Name))
                        {
                            if (opts.Type != BulkEditOptions.AvailableTypes.ANY)
                                if ( proptoedit.GetType().Name != opts.Type.ToString())
                                return;

                            // check the value 
                            dynamic dyn = proptoedit;
                            if (!(dyn.val is string x))
                                x = dyn.val.ToString();

                            if (x == opts.Value)
                                return;
                            if (excludedvalues.Count != 0 && excludedvalues.Contains(x))
                                return;
                            if (includedvalues.Count != 0 && !includedvalues.Contains(x))
                                return;

                            // access the val property of the CVariable baecause there's typecopnverters from string available
                            var value = proptoedit.accessor.GetMembers().First(_ => _.Name == "val");
                            var converter = TypeDescriptor.GetConverter(value.Type);
                            var result = converter.ConvertFrom(opts.Value);

                            // set via reflection
                            proptoedit.accessor[proptoedit, "val"] = result;
                            Logger.LogString($"Succesfully edited a variable in {cvar.REDName}: {path}.\r\n", Logtype.Normal);
                        }
                        else
                            Logger.LogString($"{proptoedit.GetType()} not supported in {cvar.REDName}: {path}.\r\n", Logtype.Normal);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogString($"Some error occored: {ex.Message}.\r\n", Logtype.Error);
                    }
                }
            }

        }
        #endregion



    }
}
