using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.RED3.CR2W;
using WolvenKit.RED3.CR2W.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Editor.Old
{
    public class BulkEditOptions
    {
        #region Enums

        public enum AvailableOperations
        {
            Replace,
            Multiply,
            Divide,
            Add,
            Subtract
        }

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

        #endregion Enums

        #region Properties

        [Description("Specify the chunk name. \n\r" +
            "Example: CMesh")]
        [Category("Is Required")]
        public string ChunkName { get; set; }

        // Optional lists
        [Description("Exclude the following values.\n\r" +
            "Example: 0,64,1028,2053")]
        public string Exclude { get; set; }

        // Optional string
        [Description("Specify the file extensions to edit. \n\r" +
            "Example: w2mesh,w2l,xbm")]
        public string Extension { get; set; }

        [Description("Include only the following values.\n\r" +
                    "Example: 0,32,64")]
        public string Include { get; set; }

        // Required
        [Description("Specify the variable name. \n\r" +
            "Example: autohidedistance")]
        [Category("Is Required")]
        public string Name { get; set; }

        [Description("Specify the option type. Default is replace.")]
        public AvailableOperations Operation { get; set; }

        [Description("Specify the variable type.")]
        public AvailableTypes Type { get; set; }

        [Description("Specify the new variable value. \n\r" +
                            "Example: 9999")]
        [Category("Is Required")]
        public string Value { get; set; }

        #endregion Properties
    }

    public class BulkEditorViewModel : ToolViewModel
    {
        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Bulk Editor";

        #region Fields

        private readonly IProjectManager _projectManager;
        private readonly ILoggerService Logger;

        #endregion Fields

        #region Constructors

        public BulkEditorViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService
            ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            Logger = loggerService;

            RunCommand = new RelayCommand(Run, CanRun);
            Options = new BulkEditOptions();

            ProgressReport = new ProgressReport();
        }

        #endregion Constructors

        #region Events

        public event EventHandler PerformStep = delegate { };

        #endregion Events

        #region Methods

        protected void OnPerformStepRequest() => PerformStep?.Invoke(this, new EventArgs());

        protected void OnResetRequest() => PerformStep?.Invoke(this, new EventArgs());

        #endregion Methods

        #region Properties

        public BulkEditOptions Options { get; set; }

        #region ProgressReport

        [Reactive] public ProgressReport ProgressReport { get; set; }

        #endregion ProgressReport

        #endregion Properties

        #region Commands

        public ICommand RunCommand { get; }

        #endregion Commands

        #region Commands Implementation

        protected bool CanRun()
        {
            //if (MainVM.GetOpenDocuments().Any())
            //{
            //    Logger.LogString("Please close all open documents before running the bulk editor.", Logtype.Error);
            //    return false;
            //}
            if (!(Options.Name != null && Options.Value != null && Options.ChunkName != null))
            {
                Logger.LogString("Please fill in all required variables.", Logtype.Error);
                return false;
            }
            return true;
        }

        protected async void Run() => await Task.Run(() => RunBulkEditInternal(Options));

        #endregion Commands Implementation

        #region Methods

        public async Task<int> RunBulkEditInternal(BulkEditOptions opts)
        {
            if (!(opts.Name != null && opts.Value != null && opts.ChunkName != null))
            {
                Logger.LogString("Please fill in all required variables.", Logtype.Error);
                return 0;
            }

            var files = _projectManager.ActiveProject.Files;
            if (opts.Extension != null)
            {
                files = _projectManager.ActiveProject.Files.Where(_ => Path.GetExtension(_).Contains(opts.Extension)).ToList();
            }

            Logger.LogString($"Starting bulk edit. Found {files.Count} files to edit. \r\n", Logtype.Success);
            ProgressReport.Max = files.Count;
            ProgressReport.Min = 0;
            ProgressReport.Value = 0;
            ProgressReport = new ProgressReport(ProgressReport);

            foreach (var path in files)
            {
                var fullpath = Path.Combine(_projectManager.ActiveProject.FileDirectory, path);

                CR2WFile cr2w;
                using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    cr2w = new CR2WFile();
                    await cr2w.ReadAsync(reader);
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
            {
                return;
            }

            if (opts.ChunkName != null && !file.Chunks.Any(_ => opts.ChunkName.Contains(_.REDType)))
            {
                return;
            }

            var excludedvalues = opts.Exclude == null ? new List<string>() : opts.Exclude.Split(',').ToList();
            var includedvalues = opts.Include == null ? new List<string>() : opts.Include.Split(',').ToList();

            // get chunks that match chunkname
            var chunks = opts.ChunkName != null ? file.Chunks.Where(_ => _.Data.GetType().Name == opts.ChunkName).ToList() : file.Chunks;

            var splits = opts.Name.Split('.');

            foreach (var chunk in chunks.Select(_ => _.Data))
            {
                CheckProperties(chunk);
            }

            void CheckProperties(IEditableVariable cvar)
            {
                // edit lists
                if (cvar is IList && cvar.GetType().IsGenericType)
                {
                    foreach (var listitem in cvar as IList)
                    {
                        if (listitem is CVariable clistitem)
                        {
                            CheckProperties(clistitem);
                        }
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

            void TrySetValue(IEditableVariable cvar)
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
                            {
                                if (proptoedit.GetType().Name != opts.Type.ToString())
                                {
                                    return;
                                }
                            }

                            // check if the user specified a parent
                            if (splits.Length > 1)
                            {
                                var parent = proptoedit.ParentVar;
                                for (var i = splits.Length; i > 0; i--)
                                {
                                    if (parent.REDName != splits[i])
                                    {
                                        return;
                                    }

                                    parent = parent.ParentVar;
                                }
                            }

                            // check the value
                            dynamic dyn = proptoedit;
                            if (!(dyn.val is string x))
                            {
                                x = dyn.val.ToString();
                            }

                            if (excludedvalues.Count != 0 && excludedvalues.Contains(x))
                            {
                                return;
                            }

                            if (includedvalues.Count != 0 && !includedvalues.Contains(x))
                            {
                                return;
                            }

                            // access the val property of the CVariable because there's typeconverters from string available
                            var member = proptoedit.accessor.GetMembers().First(_ => _.Name == "val");
                            var converter = TypeDescriptor.GetConverter(member.Type);
                            var convertedRequestedValue = converter.ConvertFrom(opts.Value);      // convert the requested balue to the type of the cvariable

                            // if a replace operation is requested
                            if (opts.Operation == BulkEditOptions.AvailableOperations.Replace)
                            {
                                // value is already set to the desired value
                                if (x == opts.Value)
                                {
                                    return;
                                }

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
                        {
                            Logger.LogString($"{proptoedit.GetType()} not supported in {cvar.REDName}: {path}.\r\n", Logtype.Normal);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.LogString($"An error occurred: {ex.Message}.\r\n", Logtype.Error);
                    }
                }
            }
        }

        #endregion Methods
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

        #endregion Min

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

        #endregion Max

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

        #endregion Value

        #region Constructors

        public ProgressReport()
        {
        }

        public ProgressReport(ProgressReport old)
        {
            Min = old.Min;
            Max = old.Max;
            Value = old.Value;
        }

        #endregion Constructors
    }
}
