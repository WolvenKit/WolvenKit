using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WolvenKit.App;
using WolvenKit.App.Model;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Forms.Editors
{
    public partial class ArrayEditor : UserControl
    {
        public event EventHandler<RequestByteArrayFileOpenArgs> RequestBytesOpen;
        public frmChunkProperties parentref;

        public ArrayEditor()
        {
            InitializeComponent();
        }

        public IArrayAccessor WrappedArray { get; set; }

        private void btOpen_Click(object sender, EventArgs e)
        {
            // opens a new form (spreadsheet editor)
            RequestBytesOpen?.Invoke(this, new RequestByteArrayFileOpenArgs((CVariable)WrappedArray));
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Multiselect = true;
                of.Filter = "Comma separated file | *.csv;";
                of.Title = "Please select a csv file for importing";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var records = CsvCommonFunctions.FromCsv(WrappedArray.InnerType, new FileInfo(of.FileName), true);

                    // decorate the Cvariables properly and add to wrapped array
                    WrappedArray.Clear();
                    foreach (var o in records)
                    {
                        if (o is CVariable co)
                        {
                            // set cr2w file, parent CVar and isserialized property
                            co.cr2w = WrappedArray.cr2w;
                            co.ParentVar = WrappedArray;
                            co.IsSerialized = true;
                            WrappedArray.AddVariable(co);
                        }
                        else
                            throw new NotImplementedException();
                    }

                    // refresh object in treeView
                    parentref.RefreshObject(WrappedArray);
                }
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            // export a csv
            var s = WrappedArray.ToCsvString(true);
            if (string.IsNullOrEmpty(s))
            {
                MainController.LogString("Creating Csv file failed, please double-check your input.", Logtype.Error);
                return;
            }

            using (var sf = new SaveFileDialog())
            {
                sf.Title = "Choose a location to save the file to.";
                sf.Filter = "Comma separated file (.csv) | *.csv";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sf.FileName, s);
                }
            }
        }




    }
}