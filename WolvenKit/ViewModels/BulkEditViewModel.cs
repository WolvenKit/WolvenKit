using FastMember;
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
using WolvenKit.Commands;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Radish.Model;

namespace WolvenKit.ViewModels
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

        public enum AvailableOperations
        {
            Replace,
            Multiply,
            Divide,
            Add,
            Subtract
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

        [Description("Specify the variable type.")]
        public AvailableTypes Type { get; set; }

        [Description("Specify the option type. Default is replace.")]
        public AvailableOperations Operation { get; set; }

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
        private readonly MainViewModel MainVM;

        public BulkEditorViewModel(IWindowFactory windowFactory, MainViewModel mainViewModel) : base(windowFactory)
        {
            MainVM = mainViewModel;
            Logger = MainController.Get().Logger;
            

            RunCommand = new RelayCommand(Run, CanRun);
            Options = new BulkEditOptions();


            ProgressReport = new ProgressReport();
        }

        public event EventHandler PerformStep = delegate { };
        protected void OnPerformStepRequest() => this.PerformStep?.Invoke(this, new EventArgs());
        public event EventHandler Reset = delegate { };
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
                    var oldValue = _progressReport;
                    _progressReport = value;
                    RaisePropertyChanged(() => ProgressReport, oldValue, value);
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
            if (MainVM.GetOpenDocuments().Any())
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
            if (!(opts.Name != null && opts.Value != null && opts.ChunkName != null))
            {
                Logger.LogString("Please fill in all required variables.", Logtype.Error);
                return 0;
            }
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
                    cr2w = new CR2WFile();
                    cr2w.Read(reader);
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
            if (opts.ChunkName != null && !file.Chunks.Any(_ => opts.ChunkName.Contains(_.REDType)))
                return;

            List<string> excludedvalues = opts.Exclude == null ? new List<string>() : opts.Exclude.Split(',').ToList();
            List<string> includedvalues = opts.Include == null ? new List<string>() : opts.Include.Split(',').ToList();

            // get chunks that match chunkname
            List<CR2WExportWrapper> chunks = opts.ChunkName != null ? file.Chunks.Where(_ => _.data.GetType().Name == opts.ChunkName).ToList() : file.Chunks;
            
            var splits = opts.Name.Split('.');


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
                var propname = splits.Last();

                var propnameslist = cvar.accessor.GetMembers().Select(_ => _.Name).ToList();
                if (propnameslist.Contains(propname))
                {
                    try
                    {
                        // check if type is supported
                        var proptoedit = cvar.GetEditableVariables().First(_ => _.REDName == propname) as CVariable;
                        if (Enum.GetValues(typeof(BulkEditOptions.AvailableTypes))
                                .Cast<BulkEditOptions.AvailableTypes>()
                                .Select(_ => _.ToString())
                                .Contains(proptoedit.GetType().Name))
                        {
                            // check if the user specified a file type
                            if (opts.Type != BulkEditOptions.AvailableTypes.ANY)
                                if ( proptoedit.GetType().Name != opts.Type.ToString())
                                    return;

                            // check if the user specified a parent
                            if (splits.Length > 1)
                            {
                                var parent = proptoedit.ParentVar;
                                for (int i = splits.Length; i > 0 ; i--)
                                {
                                    if (parent.REDName != splits[i])
                                        return;

                                    parent = parent.ParentVar;
                                }
                            }

                            // check the value 
                            dynamic dyn = proptoedit;
                            if (!(dyn.val is string x))
                                x = dyn.val.ToString();

                            if (excludedvalues.Count != 0 && excludedvalues.Contains(x))
                                return;
                            if (includedvalues.Count != 0 && !includedvalues.Contains(x))
                                return;

                            // access the val property of the CVariable because there's typeconverters from string available
                            Member member = proptoedit.accessor.GetMembers().First(_ => _.Name == "val");
                            var converter = TypeDescriptor.GetConverter(member.Type);
                            var convertedRequestedValue = converter.ConvertFrom(opts.Value);      // convert the requested balue to the type of the cvariable

                            // if a replace operation is requested
                            if (opts.Operation == BulkEditOptions.AvailableOperations.Replace)
                            {
                                // value is already set to the desired value
                                if (x == opts.Value)
                                    return;


                                

                                // set via reflection
                                proptoedit.accessor[proptoedit, "val"] = convertedRequestedValue;
                                Logger.LogString($"Succesfully edited a variable in {cvar.REDName}: {x} ===> {convertedRequestedValue}.\r\n", Logtype.Normal);
                            }
                            // if a multiply etc operation is requested
                            else
                            {
                                if (opts.Type != BulkEditOptions.AvailableTypes.CBool && opts.Type != BulkEditOptions.AvailableTypes.CString)
                                {
                                    dynamic dresult = proptoedit.accessor[proptoedit, "val"];
                                    string original = dresult.ToString();
                                    dynamic dconvertedRequestedValue = convertedRequestedValue;
                                    switch (opts.Operation)
                                    {
                                        case BulkEditOptions.AvailableOperations.Multiply:
                                            dresult *= dconvertedRequestedValue;
                                            break;
                                        case BulkEditOptions.AvailableOperations.Divide:
                                            dresult /= dconvertedRequestedValue;
                                            break;
                                        case BulkEditOptions.AvailableOperations.Add:
                                            dresult += dconvertedRequestedValue;
                                            break;
                                        case BulkEditOptions.AvailableOperations.Subtract:
                                            dresult -= dconvertedRequestedValue;
                                            break;
                                        default:
                                            break;
                                    }
                                    // set via reflection
                                    var obj = (object)dresult;

                                    var xconverter = TypeDescriptor.GetConverter(obj.GetType());
                                    if (xconverter.CanConvertTo(member.Type))
                                    {
                                        var convertedresult = xconverter.ConvertTo(obj, member.Type);
                                        proptoedit.accessor[proptoedit, "val"] = convertedresult;

                                        Logger.LogString($"Succesfully edited a variable in {cvar.REDName}: {original} ===> {convertedresult}.\r\n", Logtype.Normal);
                                    }
                                }
                            }
                            

                            
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
