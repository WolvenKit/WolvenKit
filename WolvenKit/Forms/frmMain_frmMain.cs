using System;

using System.Collections.Generic;

using System.Diagnostics;

using System.Diagnostics.CodeAnalysis;

using System.Drawing;

using System.IO;

using System.Linq;

using System.Reflection;

using System.Text;

using System.Threading;

using System.Threading.Tasks;

using System.Windows.Forms;

using System.Xml.Linq;

using System.Xml.Serialization;

using AutoUpdaterDotNET;

using Dfust.Hotkeys;

using ICSharpCode.SharpZipLib.Core;

using ICSharpCode.SharpZipLib.Zip;

using Newtonsoft.Json;

using SharpPresence;

using WeifenLuo.WinFormsUI.Docking;

using WolvenKit.CR2W;

using WolvenKit.CR2W.Types;

using WolvenKit.Mod;

using SearchOption = System.IO.SearchOption;

using WolvenKit.Common;

using WolvenKit.Cache;

using WolvenKit.Bundles;

using WolvenKit.Forms;

using Enums = Dfust.Hotkeys.Enums;


WolvenKit::frmMain::frmMain()
{
    
            InitializeComponent();

            UpdateTitle();

            MainController.Get().PropertyChanged += MainControllerUpdated;

            #region Load recent files into toolstrip

            recentFilesToolStripMenuItem.DropDownItems.Clear();

            if (File.Exists("recent_files.xml"))

            {

                var doc = XDocument.Load("recent_files.xml");

                recentFilesToolStripMenuItem.Enabled = doc.Descendants("recentfile").Any();

                foreach (var f in doc.Descendants("recentfile"))

                {

                    recentFilesToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(f.Value, null, RecentFile_click));

                }

            }

            else

            {

                recentFilesToolStripMenuItem.Enabled = false;

            }

            #endregion

            hotkeys = new HotkeyCollection(Enums.Scope.Application);

            hotkeys.RegisterHotkey(Keys.Control | Keys.S, HKSave, "Save");

            hotkeys.RegisterHotkey(Keys.Control | Keys.Shift | Keys.S, HKSaveAll , "SaveAll");

            hotkeys.RegisterHotkey(Keys.F1, HKHelp, "Help");

            hotkeys.RegisterHotkey(Keys.Control | Keys.C, HKCopy, "Copy");

            hotkeys.RegisterHotkey(Keys.Control | Keys.V, HKPaste,"Paste");            

            MainController.Get().InitForm(this);
}