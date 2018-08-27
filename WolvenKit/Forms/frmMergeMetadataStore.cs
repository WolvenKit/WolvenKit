using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO
 * TEXTURE and multi-merges
 * Load order
 * 
 * 
 * FIXME
 * code cleanups
 * 
 * BUGS
 * merged mod count - done
 * delete merged mod folders after unmerge - done
 */


namespace WolvenKit.Forms
{
    public partial class frmMergeMetadataStore : Form
    {
        private List<string> MergedModList = new List<string>();
        private List<string> MergedDLCList = new List<string>();

        private string gameModDir;
        private string gameDLCDir;
        private string mergedModsDir;
        private string mergedDLCDir;
        private const string MDmergedModFolder = "mod0000_MergedMods";
        private const string MDmergedDLCFolder = "0000MergedDLC";

        private bool disableModForm = false; //TODO replace
        private bool disableDLCForm = false; //TODO replace

        private static Task ModMerger;
        private static Task BundleReader;

        private struct modType
        {
            public bool bundle;
            public bool cache;
        }
        

        private struct modData
        {
            public string modPath;
            public string modName;
            public modType modType;

            public bool modError;
            public bool isDisabled;
            public bool bundleIsMerged;
            public bool cacheIsMerged;
            public bool metadataIsMerged;

            public List<string> bundles;
            public List<string> bundleFiles;
        }
        


        public frmMergeMetadataStore()
        {
            InitializeComponent();

            PRE_Initialization();

           
        }

        /// <summary>
        /// MAIN Init Methods
        /// </summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Main Init Methods

        private void PRE_Initialization()
        {
            var progress = new Progress<int>(value => { toolStripProgressBar.Value = value; });

            GetListViewConfig();

            PopulateListView(listViewModList, true);
            PopulateListView(listViewDLCList, false);

            if (Directory.Exists(mergedModsDir))
                MergedModList.AddRange(Directory.GetFiles(mergedModsDir, "*.bundle", SearchOption.AllDirectories).ToArray());
            if (Directory.Exists(mergedDLCDir))
                MergedDLCList.AddRange(Directory.GetFiles(mergedDLCDir, "*.bundle", SearchOption.AllDirectories).ToArray());
        

            UpdateStatusLabel();

            BundleReader = GetBundledFiles(progress);
                
                

        }
        private void GetListViewConfig()
        {
            var gameRootDir = MainController.Get().Configuration.GameRootDir;

            gameModDir = Path.Combine(gameRootDir, @"Mods\");
            gameDLCDir = Path.Combine(gameRootDir, @"DLC\");

            mergedModsDir = Path.Combine(gameModDir, MDmergedModFolder);
            mergedDLCDir = Path.Combine(gameDLCDir, MDmergedDLCFolder);

            //TODO remember load order

        }

        private async Task GetBundledFiles(IProgress<int> progress)
        {
            await GetBundledFileListsAsync( gameModDir, true);
            //progress.Report(50);
            //await GetBundledFileListsAsync( gameDLCDir, false);
            progress.Report(100);
        }

        private async Task GetBundledFileListsAsync(string dir, bool isMod)
        {
            ListView list;
            string outfile;
            var config = MainController.Get().Configuration;

            if (isMod)
            {
                list = listViewModList;
                outfile = Path.Combine(Path.GetDirectoryName(config.WccLite), @"outmod.txt"); //FIXME better working dir?
            }
            else
            {
                list = listViewDLCList;
                outfile = Path.Combine(Path.GetDirectoryName(config.WccLite), @"outdlc.txt"); //FIXME better working dir?
            }

            File.Create(outfile).Dispose();
            

            //run wcc lite task
            await wcc_DumpBundleInfo(dir, outfile);

            //read outfile
            using (StreamReader sr = new StreamReader(outfile))
            {
                var modErrors = new List<string>();

                while (true)
                {
                    String result = await sr.ReadLineAsync();

                    string modname = result.Split(new string[] { dir }, StringSplitOptions.None).Last().Split(Path.DirectorySeparatorChar).First();
                    string filename = result.Split(';')[1];

                    if (list.Items.ContainsKey(modname))
                    {
                        var modData = (modData)list.Items.Find(modname, false).First().Tag;
                        modData.bundleFiles.Add(filename);
                    }
                    else
                    {
                        if (!modErrors.Contains(modname))
                            modErrors.Add(modname);
                    }

                    

                    if (sr.EndOfStream)
                        break;
                }
                Output(String.Join(", ", modErrors.ToArray()) + " not found.\n");
                Output("Finished Setup.\n");
                
            }
            
            File.Delete(outfile);
        }
        

        private void PopulateListView( ListView list, bool isMod )
        {
            //get mod dlc var
            string[] modDir;
            if (isMod)
            {
                modDir = Directory.GetDirectories(gameModDir);
            }
            else
            {
                modDir = Directory.GetDirectories(gameDLCDir);
            }
            
            //check
            for (int i = 0; i < modDir.Length; i++)
            {

                //check if not disabled by TW3ModManager (disabled mods start with ~mod) or otherwise 
                var modName = modDir[i].Split(Path.DirectorySeparatorChar).Last();
                if (isMod && modName.Substring(0, 3) != "mod")
                {
                    continue;
                }
                //check if merged dir is empty
                if (Directory.Exists(modDir[i]) && !Directory.GetFiles(modDir[i],"*.*",SearchOption.AllDirectories).Any() && (modName == MDmergedModFolder || modName == MDmergedDLCFolder))
                {
                    continue;
                }
                var currentModDir = modDir[i].ToString();
                

                //create item and data
                var currentModData = new modData
                {
                    modPath = currentModDir,            //mod path
                    modName = modName,                  //mod Name
                    bundles = new List<string>(),       //mod bundles
                    bundleFiles = new List<string>(),   //mod bundle files
                };
                ListViewItem listViewModItem = new ListViewItem()
                {
                    Text = modName,                     //displaytext
                    Name = modName,
                    //UseItemStyleForSubItems = false,
                };


                //Properties
                // 0 ... name
                listViewModItem.SubItems.Add(""); //1 ... bundle
                listViewModItem.SubItems.Add(""); //2 ... cache
                listViewModItem.SubItems.Add(""); //3 ... metadata
                listViewModItem.SubItems.Add(""); //4 ... load order
                //bundle
                var bundles = Directory.GetFiles(currentModDir, "*.bundle*", SearchOption.AllDirectories); //keep bundle* since I want to check for merged mods
                if (bundles.Length > 0)
                {
                    currentModData.modType.bundle = true;
                    currentModData.bundles.AddRange(bundles.ToList());
                }
               
                if (Directory.GetFiles(currentModDir, "*.bundle-merged", SearchOption.AllDirectories).Any())
                {
                    currentModData.bundleIsMerged = true;
                    
                }
                if (Directory.GetFiles(currentModDir, "*.bundle-MDmerged", SearchOption.AllDirectories).Any())
                {
                    currentModData.metadataIsMerged = true;
                   

                }

                //cache
                var caches = Directory.GetFiles(currentModDir, "*.cache*", SearchOption.AllDirectories);
                if (caches.Length > 0)
                {
                    currentModData.modType.cache = true;
                    currentModData.bundles.AddRange(caches.ToList());
                }
               
                if (Directory.GetFiles(currentModDir, "*.cache-merged", SearchOption.AllDirectories).Any())
                {
                    currentModData.cacheIsMerged = true;
                    
                }

                //late do not add non-bundled mods
                if (!currentModData.modType.cache && !currentModData.modType.bundle)
                {
                    continue;
                }

                //only bundle mods are enabled
                currentModData.isDisabled = true;
                if (currentModData.modType.bundle && !currentModData.modError && !currentModData.bundleIsMerged && !IsOfficialDLC(modName))
                {
                    currentModData.isDisabled = false;
                }

                //store data
                listViewModItem.Tag = currentModData;

                //update list
                list.BeginUpdate();
                
                list.Items.Add(listViewModItem);
                list.EndUpdate();
                
            }

            //check for mod Error


            //Update ListView
            UpdateFormating(true);
            UpdateFormating(false);

            //saftey check for existing merged metadata
            if (Directory.Exists(mergedModsDir))
            {
                if (Directory.GetFiles(mergedModsDir, "*.*", SearchOption.AllDirectories).Any())
                    disableModForm = true;
            }
            if (Directory.Exists(mergedDLCDir))
            {
                if (Directory.GetFiles(mergedDLCDir, "*.*", SearchOption.AllDirectories).Any())
                    disableDLCForm = true;
            }


            //buttons
            ButtonsMerged(disableModForm, true);
            ButtonsMerged(disableDLCForm, false);

        }

       

        private void UpdateFormating(bool isMod)
        {
            ListView list;
            if (isMod)
            {
                list = listViewModList;
            }
            else
            {
                list = listViewDLCList;
            }


            foreach (ListViewItem item in list.Items)
            {
                var modData = (modData)item.Tag;
                item.SubItems[4].Text = item.Index.ToString();

                //bundles
                if (modData.modType.bundle)
                {
                    item.SubItems[1].Text = "not merged";
                    item.SubItems[1].ForeColor = Color.Red;
                }
                if (modData.modType.cache)
                {
                    item.SubItems[2].Text = "not merged";
                    item.SubItems[2].ForeColor = Color.Red;
                }


                //merge and unmerge
                if (modData.metadataIsMerged)
                {
                    item.BackColor = Color.LightGreen;
                    item.Font = new Font(list.Font, list.Font.Style | FontStyle.Italic);
                    item.SubItems[1].Text = "merged";
                    item.SubItems[1].ForeColor = Color.Black;
                }
                else
                {
                    item.BackColor = Color.Empty;
                    item.Font = new Font(list.Font, list.Font.Style | FontStyle.Regular);
                }

                


                //overrides
                if (modData.isDisabled)
                {
                    item.ForeColor = Color.Gainsboro;
                    item.UseItemStyleForSubItems = true;
                }
                if (modData.bundleIsMerged) //mod merger
                {
                    item.ForeColor = Color.DarkViolet;
                    item.SubItems[1].Text = "merged";
                    //item.SubItems[1].ForeColor = Color.Green;
                }
                if (modData.cacheIsMerged) //mod merger
                {
                    item.ForeColor = Color.DarkViolet;
                    item.SubItems[2].Text = "merged";
                    //item.SubItems[2].ForeColor = Color.Green;
                }
                if (modData.modError)
                {
                    item.BackColor = Color.IndianRed;
                }
                if ((isMod && modData.modName == MDmergedModFolder) || (!isMod && modData.modName == MDmergedDLCFolder))
                {
                    item.BackColor = Color.SpringGreen;
                    item.Font = new Font(list.Font, list.Font.Style | FontStyle.Bold);
                }
            }
        }



        #region Subroutines
        

        private void ButtonsMerged(bool isMerged, bool isMod)
        {
            if (isMod)
            {
                ts_Mod_MergeMetadata.Enabled = !isMerged;
                ts_Mod_UnmergeMetadata.Enabled = isMerged;
            }
            else
            {
                ts_DLC_MergeMetdadata.Enabled = !isMerged;
                ts_DLC_UnmergeMetdadata.Enabled = isMerged;
            }

        }

        private bool IsOfficialDLC(string dlcName)
        {
            bool isOfficialDLC = false;

            for (int i = 1; i <= 16; i++)
            {
                string modularName = "DLC" + i;
                if (dlcName == modularName || dlcName == "bob" || dlcName == "ep1")
                    isOfficialDLC = true;
            }

            return isOfficialDLC;
        }

        delegate void StringArgReturningVoidDelegate(string text);
        private void Output(string text)
        {
            
            if (richTextBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(Output);
                Invoke(d, new object[] { text });
            }
            else
            {
                richTextBox.AppendText(text);
            }
        }

        private void UpdateStatusLabel()
        {
            int DLCBundles = 0;
            int ModBundles = 0;
            int mergedModBundles = 0;
            int mergedDLCBundles = 0;

            foreach (ListViewItem item in listViewModList.Items)
            {
                modData currentModData = (modData)item.Tag;
                if (!currentModData.bundleIsMerged && currentModData.modName != "mod0000_MergedPack" && currentModData.modName != MDmergedModFolder)
                {
                    ModBundles += currentModData.bundles.Count;
                }
            }
            foreach (ListViewItem item in listViewDLCList.Items)
            {
                modData currentModData = (modData)item.Tag;
                if (!currentModData.bundleIsMerged && !IsOfficialDLC(currentModData.modName) && currentModData.modName != MDmergedDLCFolder)
                {
                    DLCBundles += currentModData.bundles.Count;
                }
            }

            mergedModBundles = MergedModList.Count;
            mergedDLCBundles = MergedDLCList.Count;


            tsLblStatus.Text = "Mod Bundles Merged: " + mergedModBundles.ToString() + "/" + ModBundles.ToString() + ", DLC Bundles Merged: " + mergedDLCBundles.ToString() + "/" + DLCBundles.ToString();
        }
        #endregion

        #endregion

        /// <summary>
        /// MAIN tasks
        /// </summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Main Tasks

        private async Task MAIN_MergeMetadata(IProgress<int> progress, bool isMod)
        {
            //PRE
            #region prep
            
            string mergedDir;
            ListView list;

            if (isMod)
            {
                mergedDir = Path.Combine(mergedModsDir, @"content\");
                list = listViewModList;
            }
            else
            {
                mergedDir = Path.Combine(mergedDLCDir, @"content\"); ;
                list = listViewDLCList;
            }
            if (!Directory.Exists(mergedDir))
            {
                Directory.CreateDirectory(mergedDir);
            }
            progress.Report(10);
            #endregion

            //COPY
            #region Copy
            for (int i = 0; i < list.CheckedItems.Count; i++)
            {
                var currentMod = list.CheckedItems[i];
                var currentModData = (modData)currentMod.Tag;
                var currentModDir = Path.Combine(currentModData.modPath, @"content\");

                if (currentModData.modType.bundle)
                {
                    var bundles = Directory.GetFiles(currentModDir, "*.bundle*", SearchOption.AllDirectories);

                    foreach (string item in bundles)
                    {
                        try
                        {
                            //rename bundles
                            string newpath = item.Replace(currentModDir, mergedDir);
                            if (newpath.Contains("blob0"))
                                newpath = newpath.Replace("blob0", i.ToString().PadLeft(2, '0') + "_" + currentModData.modName);
                            if (newpath.Contains("buffers0"))
                                newpath = newpath.Replace("buffers0", i.ToString().PadLeft(2, '0') + "_" + currentModData.modName + "_buffers");
                            
                            //copy bundles
                            File.Copy(item, newpath, true);
                        }
                        catch (Exception ex)
                        {
                            Output(ex.ToString() + "\n");
                        }
                    }

                    //save mod Name to mod list
                    progress.Report((int)( (i/ list.CheckedItems.Count) * 30));
                    if (isMod)
                        MergedModList.Add(currentModData.modName);
                    else
                        MergedDLCList.Add(currentModData.modName);

                }
            }
            #endregion

            


            //WCC_LITE
            #region wcc_lite
            await Task.Run(() => wcc_MetadatastoreAsync(mergedDir));
            progress.Report(60);
            //catch failed merge
            if (!Directory.GetFiles(mergedDir,"*.store",SearchOption.AllDirectories).Any())
            {
                Output("Metdata Merge Failed." + "\n");
                UnmergeMetadata(isMod);
                progress.Report(100);
                return;
            }
            #endregion


            //POST
            #region cleanup
            for (int i = 0; i < list.CheckedItems.Count; i++)
            {
                var currentMod = list.CheckedItems[i];
                var currentModData = (modData)currentMod.Tag;
                var currentModContentDir = Path.Combine(currentModData.modPath, @"content\");

                //rename merged bundles
                //METADATA
                var storeFiles = Directory.GetFiles(currentModContentDir, "metadata.store", SearchOption.AllDirectories);
                foreach (string item in storeFiles)
                {
                    try
                    {
                        File.Move(item, Path.ChangeExtension(item, "store-MDmerged"));
                    }
                    catch (Exception ex)
                    {
                        Output(ex.ToString() + "\n");
                    }
                }
                //BUNDLES
                if (currentModData.modType.bundle)
                {
                    var bundles = Directory.GetFiles(currentModContentDir, "*.bundle", SearchOption.AllDirectories);
                    foreach (string item in bundles)
                    {
                        try
                        {
                            File.Move(item, Path.ChangeExtension(item, "bundle-MDmerged"));
                        }
                        catch (Exception ex)
                        {
                            Output(ex.ToString() + "\n");
                        }
                    }
                }

                //update mod data for visual
                progress.Report((int)(i / list.CheckedItems.Count * 90));
                currentModData.metadataIsMerged = true;
                currentMod.Tag = currentModData;
                //currentMod.SubItems[3].Text += ""; //TODO
            }

            POST_Cleanup(isMod);
            progress.Report(100);


            #endregion
        }

        private void POST_Cleanup(bool isMod)
        {
            ListView list;
            string modName;
            string modPath;
            if (isMod)
            {
                list = listViewModList;
                modName = MDmergedModFolder;
                modPath = mergedModsDir;
                MergedModList.Clear();
            }
            else
            {
                list = listViewDLCList;
                modName = MDmergedDLCFolder;
                modPath = mergedDLCDir;
                MergedDLCList.Clear();
            }

            #region Update listView
            //create item and data
            var modData = new modData
            {
                modName = modName,
                modPath = modPath,
                bundles = new List<string>(),
                bundleFiles = new List<string>(),
            };
            if (isMod)
                modData.bundles = MergedModList;
            else
                modData.bundles = MergedDLCList;

            ListViewItem mergedItem = new ListViewItem()
            {
                Text = modName,
                Tag = modData,
                Name = modName,
            };

            if (!list.Items.ContainsKey(modName))
            {
                list.BeginUpdate();
                list.Items.Insert(0, mergedItem);
                mergedItem.SubItems.Add(""); //1 ... bundle
                mergedItem.SubItems.Add(""); //2 ... cache
                mergedItem.SubItems.Add(""); //3 ... metadata
                mergedItem.SubItems.Add(""); //4 ... load order
                list.EndUpdate();
            }

            //update form
            if (isMod)
                disableModForm = true;
            else
                disableDLCForm = true;
            ButtonsMerged(true, isMod);
            UpdateFormating(isMod);
            UpdateStatusLabel();


            #endregion

        }
        


        private void UnmergeMetadata(bool isMod)
        {
            //DELETE
            #region delete
            string mergedDir;
            ListView list;

            if (isMod)
            {
                mergedDir = mergedModsDir;
                list = listViewModList;
            }
            else
            {
                mergedDir = mergedDLCDir;
                list = listViewDLCList;
            }

            if (Directory.Exists(mergedDir))
            {
                DeleteDirectory(mergedDir);
            }
            #endregion

            //update listView //TODO cleanup
            list.BeginUpdate();
            if (isMod)
            {
                disableModForm = false;
                if (list.Items.ContainsKey(MDmergedModFolder))
                    list.Items.RemoveByKey(MDmergedModFolder);
            }
            else
            {
                disableDLCForm = false;
                if (list.Items.ContainsKey(MDmergedDLCFolder))
                    list.Items.RemoveByKey(MDmergedDLCFolder);
            }
            list.EndUpdate();

            //re-enable original mods
            #region reenable
            foreach (ListViewItem item in list.Items)
            {
                var currentModData = (modData)item.Tag;
                var currentModDir = currentModData.modPath;

                //METADATA
                var storeFiles = Directory.GetFiles(currentModDir, "*.store-MDmerged", SearchOption.AllDirectories);
                foreach (var store in storeFiles)
                {
                    try
                    {
                        File.Move(store, Path.ChangeExtension(store, ".store"));
                    }
                    catch (Exception ex)
                    {
                        Output(ex.ToString() + "\n");
                    }

                }
                //BUNDLES
                var bundles = Directory.GetFiles(currentModDir, "*.bundle-MDmerged", SearchOption.AllDirectories);
                foreach (var bundle in bundles)
                {
                    try
                    {
                        File.Move(bundle, Path.ChangeExtension(bundle, ".bundle"));
                    }
                    catch (Exception ex)
                    {
                        Output(ex.ToString() + "\n");
                    }
                }

                //update mod data for visual
                currentModData.metadataIsMerged = false;
                item.Tag = currentModData;
            }


            UpdateFormating(isMod);
            ButtonsMerged(false, isMod);
            UpdateStatusLabel();
            #endregion



        }

        /// <summary>
        /// Depth-first recursive delete, with handling for descendant 
        /// directories open in Windows Explorer.
        /// </summary>
        public static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
        #endregion

        /// <summary>
        /// wcc_lite Tasks
        /// </summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region wcc_lite

        private async Task wcc_MetadatastoreAsync(string dir)
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };

            try
            {
                proc.Arguments = $"metadatastore -path={dir}";
                proc.UseShellExecute = false;
                proc.RedirectStandardOutput = true;
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.CreateNoWindow = true;

                
                using (var process = Process.Start(proc))
                {
                    using (var reader = process.StandardOutput)
                    {
                        while (true)
                        {
                            var result = await reader.ReadLineAsync();

                            Output(result + "\n");

                            Application.DoEvents();

                            if (reader.EndOfStream)
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Output(ex.ToString() + "\n");
            }
        }

        private async Task wcc_DumpBundleInfo(string dir, string outfile)
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };

            Output( "Started Dumping Info.\n");

            try
            {
                proc.Arguments = $"dumpbundleinfo -indir={dir} -outfile={outfile}";
                proc.UseShellExecute = false;
                proc.RedirectStandardOutput = true;
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.CreateNoWindow = true;

                //Logging
                using (var process = Process.Start(proc))
                {
                    using (var reader = process.StandardOutput)
                    {
                        while (true)
                        {
                            var result = await reader.ReadLineAsync();
                            
                            Output(result + "\n");

                            Application.DoEvents();

                            if (reader.EndOfStream)
                                break;
                        }
                        //Reporting to Progress Bar
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Output(ex.ToString() + "\n");
            }
        }

        
        
        #endregion

        /// <summary>
        /// Form Control Objects
        /// </summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Form Control Objects
        //MENU
        private void helpToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //MODS
        #region Mod Buttons
        //Merge
        #region Merge
        private void ts_Mod_MergeMetadata_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value => { toolStripProgressBar.Value = value; });

            if (listViewModList.CheckedItems.Count < 1)
            {
                return;
            }


            if (ModMerger != null && (ModMerger.Status == TaskStatus.Running || ModMerger.Status == TaskStatus.WaitingToRun || ModMerger.Status == TaskStatus.WaitingForActivation))
            {
                MessageBox.Show("Merging task already running. Please wait!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ModMerger = MAIN_MergeMetadata(progress, true);
            }
        }
        private void ts_Mod_MergeBundles_Click(object sender, EventArgs e)
        {

        }
        private void ts_Mod_MergeTexture_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //Unmerge
        #region unmerge
        private void ts_Mod_UnmergeMetadata_Click(object sender, EventArgs e)
        {
            if (!disableModForm)
            {
                return;
            }

            UnmergeMetadata(true);
        }

        private void ts_Mod_UnmergeBundles_Click(object sender, EventArgs e)
        {

        }

        private void ts_Mod_UnmergeTexture_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void tsBtnSelectAllMods_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewModList.Items)
            {
                var modData = (modData)item.Tag;
                if (!modData.isDisabled && !item.Checked && !disableModForm)
                {
                    item.Checked = true;
                }
            }
        }
        private void tsBtnUnselectAllMods_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewModList.Items)
            {
                var modData = (modData)item.Tag;
                if (!modData.isDisabled && item.Checked && !disableModForm)
                {
                    item.Checked = false;
                }
            }
        }

        #endregion

        //DLC
        #region DLC buttons

        //Merge
        #region Merge
        private void ts_DLC_MergeMetdadata_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value => { toolStripProgressBar.Value = value; });

            if (listViewDLCList.CheckedItems.Count < 1)
            {
                return;
            }

            if (ModMerger != null && (ModMerger.Status == TaskStatus.Running || ModMerger.Status == TaskStatus.WaitingToRun || ModMerger.Status == TaskStatus.WaitingForActivation))
            {
                MessageBox.Show("Merging task already running. Please wait!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ModMerger = MAIN_MergeMetadata(progress, false);
            }
        }

        private void ts_DLC_MergeBundles_Click(object sender, EventArgs e)
        {

        }

        private void ts_DLC_MergeTextures_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //Unmerge
        #region Unmerge
        private void ts_DLC_UnmergeMetdadata_Click(object sender, EventArgs e)
        {
            if (!disableDLCForm)
            {
                return;
            }

            UnmergeMetadata(false);
        }

        private void ts_DLC_UnmergeBundles_Click(object sender, EventArgs e)
        {

        }

        private void ts_DLC_UnmrgeTextures_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void tsBtnSelectAllDLC_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewDLCList.Items)
            {
                var modData = (modData)item.Tag;
                if (!modData.isDisabled && !item.Checked && !disableDLCForm)
                {
                    item.Checked = true;
                }
            }
        }

        private void tsBtnUnselectAllDLC_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewDLCList.Items)
            {
                var modData = (modData)item.Tag;
                if (!modData.isDisabled && item.Checked && !disableDLCForm)
                {
                    item.Checked = false;
                }
            }
        }

        #endregion
        #endregion

        /// <summary>
        /// Form Events
        /// </summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Form Events

        private void listViewModList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //disable merged and non-bundled mods
            var modData = (modData)listViewModList.Items[e.Index].Tag;
            if (modData.isDisabled || disableModForm)
                e.NewValue = e.CurrentValue;
        }

        private void listViewDLCList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //disable merged and non-bundled mods
            var modData = (modData)listViewDLCList.Items[e.Index].Tag;
            if (modData.isDisabled || disableDLCForm)
                e.NewValue = e.CurrentValue;
        }


        //Drag and Drop
        #region Drag and Drop
        //MOD
        private void listViewModList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewModList.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewModList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void listViewModList_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = listViewModList.PointToClient(new Point(e.X, e.Y));
            int targetIndex = listViewModList.InsertionMark.NearestIndex(targetPoint);

            if (targetIndex > -1)
            {
                Rectangle itemBounds = listViewModList.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    listViewModList.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    listViewModList.InsertionMark.AppearsAfterItem = false;
                }
            }

            listViewModList.InsertionMark.Index = targetIndex;
        }
        private void listViewModList_DragLeave(object sender, EventArgs e)
        {
            listViewModList.InsertionMark.Index = -1;
        }

        private void listViewModList_DragDrop(object sender, DragEventArgs e)
        {
            int targetIndex = listViewModList.InsertionMark.Index;

            if (targetIndex == -1)
            {
                return;
            }
            if (listViewModList.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            listViewModList.Items.Insert(targetIndex, (ListViewItem)draggedItem.Clone());
            listViewModList.Items.Remove(draggedItem);

            UpdateFormating(true);
        }

        //DLC
        private void listViewDLCList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewDLCList.DoDragDrop(e.Item, DragDropEffects.Move);
        }


        private void listViewDLCList_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = listViewDLCList.PointToClient(new Point(e.X, e.Y));
            int targetIndex = listViewDLCList.InsertionMark.NearestIndex(targetPoint);

            if (targetIndex > -1)
            {
                Rectangle itemBounds = listViewDLCList.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    listViewDLCList.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    listViewDLCList.InsertionMark.AppearsAfterItem = false;
                }
            }

            listViewDLCList.InsertionMark.Index = targetIndex;
        }
        private void listViewDLCList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void listViewDLCList_DragLeave(object sender, EventArgs e)
        {
            listViewDLCList.InsertionMark.Index = -1;
        }
        private void listViewDLCList_DragDrop(object sender, DragEventArgs e)
        {
            int targetIndex = listViewDLCList.InsertionMark.Index;

            if (targetIndex == -1)
            {
                return;
            }
            if (listViewDLCList.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            listViewDLCList.Items.Insert(targetIndex, (ListViewItem)draggedItem.Clone());
            listViewDLCList.Items.Remove(draggedItem);

            UpdateFormating(false);
        }


        #endregion

        //Select Item
        #region OnSelect
        private void listViewModList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            UpdateDescription((ListViewItem)e.Item);
        }
        private void listViewDLCList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateDescription((ListViewItem)e.Item);
        }
        private void UpdateDescription(ListViewItem item)
        {
            modData data = (modData)item.Tag;
            string output = "";

            //BUNDLES
            string bundles = "===== BUNDLES =====\n";
            foreach (string bundle in data.bundles)
            {
                bundles += bundle.ToString().Split(Path.DirectorySeparatorChar).Last() + "\n";
            }
            output += bundles + "\n";

            //FILES
            string files = "===== FILES =====\n";
            foreach (string file in data.bundleFiles)
            {
                files += file.ToString() + "\n";
            }
            output += files + "\n";

            //CONFLICTS (only needed for mods)
            string conflicts = "===== HIGHER CONFLICTS =====\n";
            foreach (string file in GetConflictsForMod(item))
            {
                conflicts += file.ToString() + "\n";
            }
            output += conflicts + "\n";

            //Update Text
            richTextBox.Text = output;
            
        }

        private List<string> GetConflictsForMod(ListViewItem item)
        {
            modData data = (modData)item.Tag;
            var modFilesList = data.bundleFiles;
            List<string> conflicts = new List<string>();

            for (int i = 0; i < item.Index; i++)
            {
                modData curdata = (modData)listViewModList.Items[i].Tag;
                var curconflicts = modFilesList.Intersect(curdata.bundleFiles).ToList<string>();

                if (curconflicts.Count > 0)
                {
                    conflicts.Add( "== " + curdata.modName + " ==");
                    conflicts.AddRange(curconflicts);
                }
                


            }

           

            return conflicts;
        }
        #endregion


        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.ScrollToCaret();
        }


        #endregion

       
    }
}
