using BrightIdeasSoftware;
using CsvHelper;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W;
using WolvenKit.Extensions;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    


    public partial class frmImportUtility : DockContent, IThemedContent
    {
        private List<ImportableFile> importableobjects = new List<ImportableFile>();
        private readonly List<string> importableexts = Enum.GetNames(typeof(EImportable)).Select(_ => $".{_}").ToList();
        private DirectoryInfo importdepot;

        public frmImportUtility()
        {
            InitializeComponent();
            ApplyCustomTheme();


            //toolStripButtonRefresh.DataBindings.Add("Enabled", myClass1, "MyBooleanProperty");
        }

        public void ApplyCustomTheme()
        {
            var theme = MainController.Get().GetTheme();
            MainController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

            this.objectListView.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.objectListView.AlternateRowBackColor = theme.ColorPalette.OverflowButtonHovered.Background;

            this.objectListView.ForeColor = Color.Black;
            HeaderFormatStyle hfs = new HeaderFormatStyle()
            {
                Normal = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.DockTarget.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Hot = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.OverflowButtonHovered.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Pressed = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                }
            };
            this.objectListView.HeaderFormatStyle = hfs;
            objectListView.UnfocusedSelectedBackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background;
        }


        internal class XBMDump
        {
            public string RedName { get; set; }
            public string Width { get; set; }
            public string Height { get; set; }
            public string Format { get; set; }
            public string Compression { get; set; }
            public string TextureGroup { get; set; }
  
        }

        internal class ImportableFile
        {
            public bool IsSelected { get; set; }
            public EObjectState State { get; set; }
            
            public string RelativePath { get; set; }
            public string Name { get => Path.GetFileName(RelativePath); }
            public EImportable Type { get; set; }
            public Enum ImportType { get; set; }

            public ETextureGroup Texturegroup { get; set; }



            public ImportableFile(string path, EImportable type, Enum importtype)
            {
                RelativePath = path;
                Type = type;
                ImportType = importtype;
            }

            public enum EObjectState
            {
                NoTextureGroup, //Orange
                Ready,  //Green
                Error //Read
            }

        }

        private void toolStripButtonLocalResources_Click(object sender, EventArgs e)
        {
            
            var importablefiles = (from file in MainController.Get().ActiveMod.Files
                                   from ext in importableexts
                                   where file.Contains(ext)
                                   select file).ToList();


            AddObjects(importablefiles, MainController.Get().ActiveMod.FileDirectory);
        }

        private void toolStripButtonOpenFolder_Click(object sender, EventArgs e)
        {
            List<string> importablefiles = new List<string>();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                importablefiles = (from file in Directory.GetFiles(dialog.FileName, "*.*")
                                       from ext in importableexts
                                       where file.Contains(ext)
                                       select file).ToList();
                AddObjects(importablefiles, dialog.FileName);
            }

            
        }

        private void AddObjects(List<string> importablefiles, string dirpath)
        {
            importableobjects.Clear();
            importdepot = new DirectoryInfo(dirpath);

            foreach (var f in importablefiles)
            {
                string ext = Path.GetExtension(f);
                EImportable type = (EImportable)Enum.Parse(typeof(EImportable), ext.TrimStart('.'));
                //var filedir = new DirectoryInfo(f);

                var relpath = f.TrimStart(importdepot.FullName);
                relpath = relpath.TrimStart(Path.DirectorySeparatorChar);


                var importableobj = new ImportableFile(
                    relpath, 
                    type, 
                    REDTypes.RawExtensionToEnum(ext)
                    );

                // non-texture imports are ready by default (no texture group must be set)
                if (importableobj.Type == EImportable.apb ||
                    importableobj.Type == EImportable.fbx ||
                    importableobj.Type == EImportable.nxs
                    )
                {
                    importableobj.State = ImportableFile.EObjectState.Ready;
                    importableobj.IsSelected = true;
                }

                importableobjects.Add(importableobj);
            }

            objectListView.SetObjects(importableobjects);

            
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            if (objectListView.Objects == null)
                return;

            using (var reader = new StringReader(Properties.Resources.__xbmdump_37685553661))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<XBMDump>();
                var recordsl = csv.GetRecords<XBMDump>().ToList();

                foreach (var obj in objectListView.Objects)
                {
                    ImportableFile importable = obj as ImportableFile;
                    
                    // check for non-texture files
                    if (importable.Type != EImportable.bmp &&
                        importable.Type != EImportable.dds &&
                        importable.Type != EImportable.jpg &&
                        importable.Type != EImportable.png &&
                        importable.Type != EImportable.tga
                        )
                        continue;
                    
                    // try getting texture group from vanilla files
                    try
                    {
                        string xbmfullpath = Path.ChangeExtension(importable.RelativePath, "xbm");
                        var xpath = xbmfullpath.Split(Path.DirectorySeparatorChar).Last();

                        var foundrecords = recordsl.FirstOrDefault(_ => _.RedName.Contains(xpath));
                        if (foundrecords != null)
                        {
                            string stxtgroup = foundrecords.TextureGroup;
                            ETextureGroup etxtgroup = (ETextureGroup)Enum.Parse(typeof(ETextureGroup), stxtgroup);
                            importable.Texturegroup = etxtgroup;

                            importable.State = ImportableFile.EObjectState.Ready;
                            importable.IsSelected = true;
                        }
                        else
                            importable.State = ImportableFile.EObjectState.NoTextureGroup;
                    }
                    catch (Exception)
                    {
                        importable.State = ImportableFile.EObjectState.Error;
                    }
                }
            }
            objectListView.SetObjects(objectListView.Objects);
        }

        private async void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            if (objectListView.Objects == null)
                return;

            MainController.Get().Window.ModExplorer.PauseMonitoring();

            var filesToImport = objectListView.Objects.Cast<ImportableFile>().Where(_ => _.IsSelected).ToList();
            var ActiveMod = MainController.Get().ActiveMod;

            foreach (var file in filesToImport)
            {
                if (file.State != ImportableFile.EObjectState.Ready)
                    continue;

                var fullpath = Path.Combine(importdepot.FullName, file.RelativePath);
                if (!File.Exists(fullpath))
                    return;
                
                try
                {
                    await StartImport(file);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            MainController.Get().Window.ModExplorer.ResumeMonitoring();


            async Task StartImport(ImportableFile file)
            {
                var relPath = file.RelativePath;
                string importext = $".{file.ImportType:G}";
                string rawext = $".{file.Type:G}";
                var filepath = Path.Combine(importdepot.FullName, file.RelativePath);
                string type = REDTypes.RawExtensionToCacheType(rawext);

                if (relPath.Substring(0, 3) == "Raw") relPath = relPath.TrimStart("Raw".ToCharArray());
                relPath = relPath.TrimStart(Path.DirectorySeparatorChar);
                if (relPath.Substring(0, 3) == "Mod") relPath = relPath.TrimStart("Mod".ToCharArray());
                relPath = relPath.TrimStart(Path.DirectorySeparatorChar);
                if (relPath.Substring(0, 3) == "DLC") relPath = relPath.TrimStart("DLC".ToCharArray());
                relPath = relPath.TrimStart(Path.DirectorySeparatorChar);


                //var newpath = Path.Combine(ActiveMod.ModDirectory, $"{relPath.TrimEnd(rawext.ToCharArray())}{importext}");
                var newpath = Path.Combine(ActiveMod.ModDirectory, relPath);
                newpath = Path.ChangeExtension(newpath, importext);
                var split = relPath.Split(Path.DirectorySeparatorChar).First();
                if (split != type)
                    newpath = Path.Combine(ActiveMod.ModDirectory, type, $"{relPath.TrimEnd(rawext.ToCharArray())}{importext}");

                var import = new Wcc_lite.import()
                {
                    File = filepath,
                    Out = newpath,
                    Depot = MainController.DepotDir,
                    texturegroup = file.Texturegroup
                };
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(import));
            }
        }

        private void objectListView_FormatRow(object sender, FormatRowEventArgs e)
        {
            ImportableFile importable = (ImportableFile)e.Model;
            switch (importable.State)
            {
                case ImportableFile.EObjectState.NoTextureGroup:
                    e.Item.BackColor = Color.LightSalmon;
                    break;
                case ImportableFile.EObjectState.Ready:
                    e.Item.BackColor = Color.LightGreen;
                    break;
                case ImportableFile.EObjectState.Error:
                    e.Item.BackColor = Color.OrangeRed;
                    break;
                default:
                    e.Item.BackColor = Color.Orange;
                    break;
            }
        }

        private void objectListView_CellEditFinished(object sender, CellEditEventArgs e)
        {
            if (e.NewValue.GetType() == typeof(ETextureGroup))
            {
                ETextureGroup textureGroup = (ETextureGroup)e.NewValue;
                if (textureGroup != ETextureGroup.None)
                {
                    (e.RowObject as ImportableFile).State = ImportableFile.EObjectState.Ready;
                }
            }
        }
    }
}
