using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.CR2W.Types;
using WolvenKit.Services;
using WolvenKit.App.Model;

namespace WolvenKit.Forms.Editors
{
    public partial class frmCsvEditor : DockContent, IThemedContent
    {
        public frmCR2WDocument parentref;

        private IArrayAccessor wrappedArray;
        public IArrayAccessor WrappedArray
        {
            get => wrappedArray;
            set
            {
                wrappedArray = value;
                SetView();
            }
        }

        public frmCsvEditor()
        {
            InitializeComponent();
            ApplyCustomTheme();
        }

        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetThemeBase());
        }

        #region Methods
        /// <summary>
        /// Write wrapped IArray to csv and display in textbox
        /// </summary>
        private void SetView()
        {
            string s = WrappedArray.ToCsvString();
            if (string.IsNullOrEmpty(s))
            {
                MainController.LogString("Creating Csv file failed, please double-check your input.", Logtype.Error);
                return;
            }
            this.textBox1.Text = s;
        }
        #endregion

        /// <summary>
        /// Read textbox and write to array
        /// </summary>
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            var s = this.textBox1.Text;
            // get records as list of objects (CVariable)
            var records = CsvCommonFunctions.FromCsv(WrappedArray.InnerType, s);

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

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
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

        private void toolStripButtonImport_Click(object sender, EventArgs e)
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


                    SetView();
                    // refresh object in treeView
                    parentref.RefreshObject(WrappedArray);
                }
            }

        }
    }
}
