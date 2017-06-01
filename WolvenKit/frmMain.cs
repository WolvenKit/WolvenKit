using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic.FileIO;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Bundles;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Mod;
using SearchOption = System.IO.SearchOption;

namespace WolvenKit
{
	public partial class frmMain : Form
	{
		private readonly string BaseTitle = "Wolven kit";
		private frmCR2WDocument _activedocument;
		public List<frmCR2WDocument> OpenDocuments = new List<frmCR2WDocument>();

		public frmMain()
		{
			InitializeComponent();
			UpdateTitle();
			buildDateToolStripMenuItem.Text = Assembly.GetExecutingAssembly().GetLinkerTime().ToString("yyyy MMMM dd");
		}

		public W3Mod ActiveMod
		{
			get { return ModManager.Get().ActiveMod; }
			set
			{
				ModManager.Get().ActiveMod = value;
				UpdateTitle();
			}
		}

		public string Version
		{
			get
			{
				var assembly = Assembly.GetExecutingAssembly();
				var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
				return fvi.FileVersion;
			}
		}

		public frmModExplorer ModExplorer { get; set; }

		public frmOutput Output { get; set; }

		public frmCR2WDocument ActiveDocument
		{
			get { return _activedocument; }
			set
			{
				_activedocument = value;
				UpdateTitle();
			}
		}

		private void UpdateTitle()
		{
			Text = BaseTitle + " v" + Version;
			if (ActiveMod != null)
			{
				Text += " [" + ActiveMod.Name + "] ";
			}

			if (ActiveDocument != null && !ActiveDocument.IsDisposed)
			{
				Text += Path.GetFileName(ActiveDocument.FileName);
			}
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			var config = MainController.Get().Configuration;

			config.MainState = WindowState;

			WindowState = FormWindowState.Normal;
			config.MainSize = Size;
			config.MainLocation = Location;

			dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"));
		}

		private void frmMain_Shown(object sender, EventArgs e)
		{
			var config = MainController.Get().Configuration;
			Size = config.MainSize;
			Location = config.MainLocation;
			WindowState = config.MainState;
			try
			{
				dockPanel.LoadFromXml(
					Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"),
					DeserializeDockContent);
			}
			catch
			{
				// ignored
			}
		}

		public IDockContent DeserializeDockContent(string persistString)
		{
			return null;
		}

		public frmCR2WDocument LoadDocument(string filename, MemoryStream memoryStream = null, bool suppressErrors = false)
		{
			if (memoryStream == null && !File.Exists(filename))
				return null;

			foreach (var t in OpenDocuments.Where(t => t.FileName == filename))
			{
				t.Activate();
				return null;
			}

			var doc = new frmCR2WDocument();
			OpenDocuments.Add(doc);

			try
			{
				if (memoryStream != null)
				{
					doc.LoadFile(filename, memoryStream);
				}
				else
				{
					doc.LoadFile(filename);
				}
			}
			catch (InvalidFileTypeException ex)
			{
				if (!suppressErrors)
					MessageBox.Show(this, ex.Message, @"Error opening file.");

				OpenDocuments.Remove(doc);
				doc.Dispose();
				return null;
			}
			catch (MissingTypeException ex)
			{
				if (!suppressErrors)
					MessageBox.Show(this, ex.Message, @"Error opening file.");

				OpenDocuments.Remove(doc);
				doc.Dispose();
				return null;
			}
			switch (Path.GetExtension(filename))
			{
				case ".w2scene":
				{
					doc.flowDiagram = new frmChunkFlowDiagram
					{
						File = doc.File,
						DockAreas = DockAreas.Document
					};
					doc.flowDiagram.OnSelectChunk += doc.frmCR2WDocument_OnSelectChunk;
					doc.flowDiagram.Show(doc.FormPanel, DockState.Document);
					break;
				}
				case ".journal":
				{
					doc.JournalEditor = new frmJournalEditor
					{
						File = doc.File,
						DockAreas = DockAreas.Document
					};
					doc.JournalEditor.Show(doc.FormPanel, DockState.Document);
					break;
				}
				case ".xbm":
				{
					doc.ImageViewer = new frmImagePreview
					{
						File = doc.File,
						DockAreas = DockAreas.Document
					};
					doc.ImageViewer.Show(doc.FormPanel,DockState.Document);
					break;
				}
                //TODO: Remove this once it's done
#if DEBUG
                case ".redfur":
                case ".redcloth":
			    {
                    var apexfile = new Apex(doc.File);
			        using (var sf = new SaveFileDialog())
			        {
			            sf.Filter = "XML Files | *.xml";
			            if (sf.ShowDialog() == DialogResult.OK)
			            {
			                apexfile.Write(sf.FileName);
			            }
			        }
                    break;
			    }
#endif
                default:
				{
					break;
				}
			}
			if (doc.File.block7.Count > 0)
			{
				doc.embeddedFiles = new frmEmbeddedFiles
				{
					File = doc.File,
					DockAreas = DockAreas.Document
				};
				doc.embeddedFiles.Show(doc.FormPanel, DockState.Document);
			}
			doc.Activated += doc_Activated;
			doc.Show(dockPanel, DockState.Document);
			doc.FormClosed += doc_FormClosed;

			var output = new StringBuilder();

			if (doc.File.UnknownTypes.Any())
			{
				ShowOutput();

				output.Append(doc.FileName + ": contains " + doc.File.UnknownTypes.Count + " unknown type(s):\n");
				foreach (var unk in doc.File.UnknownTypes)
				{
					output.Append("\"" + unk + "\", \n");
				}

				output.Append("-------\n\n");
			}

			var hasUnknownBytes = false;

			foreach (var t in doc.File.chunks.Where(t => t.unknownBytes?.Bytes != null && t.unknownBytes.Bytes.Length > 0))
			{
				output.Append(t.Name + " contains " + t.unknownBytes.Bytes.Length + " unknown bytes. \n");
				hasUnknownBytes = true;
			}

			if (hasUnknownBytes)
				output.Append("-------\n\n");

			AddOutput(output.ToString());
			return doc;
		}


		private void frmMain_MdiChildActivate(object sender, EventArgs e)
		{
			if (sender is frmCR2WDocument)
			{
				doc_Activated(sender, e);
			}
		}

		private void dockPanel_ActiveDocumentChanged(object sender, EventArgs e)
		{
			if (dockPanel.ActiveDocument is frmCR2WDocument)
			{
				doc_Activated(dockPanel.ActiveDocument, e);
			}
		}

		private void doc_Activated(object sender, EventArgs e)
		{
			ActiveDocument = (frmCR2WDocument) sender;
		}

		private void doc_FormClosed(object sender, FormClosedEventArgs e)
		{
			var doc = (frmCR2WDocument) sender;
			OpenDocuments.Remove(doc);

			if (doc == ActiveDocument)
			{
				ActiveDocument = null;
			}
		}

		private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addModFile(false);
		}

		private void addModFile(bool loadmods,string browseToPath = "")
		{
			if (ActiveMod == null)
				return;
			if (Process.GetProcessesByName("Witcher3").Length != 0)
			{
				MessageBox.Show(@"Please close The Witcher 3 before tinkering with the files!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			var explorer = new frmBundleExplorer(loadmods ? MainController.Get().ModBundleManager : MainController.Get().BundleManager);
			explorer.OpenPath(browseToPath);
			if (explorer.ShowDialog() == DialogResult.OK)
			{
				foreach (ListViewItem depotpath in explorer.SelectedPaths)
				{
					AddToMod(depotpath.Text, loadmods ? MainController.Get().ModBundleManager : MainController.Get().BundleManager);
				}              
				SaveMod();
			}
		}

		private void AddToMod(string depotpath,BundleManager bmanager)
		{
			var manager = bmanager;

			if (!manager.Items.Any(x=> x.Value.Any(y=> y.Name == depotpath)))
				return;

			BundleItem selectedBundle;

			if (manager.Items.Any(x => x.Value.Any(y => y.Name == depotpath)))
			{
				var bundles = manager.FileList.Where(x=> x.Name == depotpath).Select(y=>new KeyValuePair<string,BundleItem>(y.Bundle.FileName, y));

				var dlg = new frmExtractAmbigious(bundles.Select(x=> x.Key).ToList());
				if (dlg.ShowDialog() == DialogResult.Cancel)
				{
					return;
				}

				selectedBundle = bundles.FirstOrDefault(x=> x.Key == dlg.SelectedBundle).Value;
			}
			else
			{
				selectedBundle = manager.Items[depotpath].Last();
			}

			var filename = Path.Combine(ActiveMod.FileDirectory, depotpath);

			try
			{
				Directory.CreateDirectory(Path.GetDirectoryName(filename));
			}
			catch { }

			if (File.Exists(filename))
			{
				FileSystem.DeleteFile(filename, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
			}
			selectedBundle.Extract(filename);
		}

		/// <summary>
		/// Update the list of files in the ModExplorer
		/// </summary>
		/// <param name="clear">if true files or completely redrawn</param>
		private void UpdateModFileList(bool clear = false)
		{           
			ModExplorer.UpdateModFileList(true,clear);
		}

		private void openModToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openMod();
		}

		private void openMod(string file = "")
		{
			if (file == "")
			{
				var dlg = new OpenFileDialog
				{
					Title = "Open Witcher 3 Mod Project",
					Filter = "Witcher 3 Mod|*.w3modproj",
					InitialDirectory = MainController.Get().Configuration.InitialModDirectory
				};
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					file = dlg.FileName;
				}
				else
				{
					return;
				}
			}
			MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(file);

			var ser = new XmlSerializer(typeof(W3Mod));
			var modfile = new FileStream(file, FileMode.Open, FileAccess.Read);
			ActiveMod = (W3Mod)ser.Deserialize(modfile);
			ActiveMod.FileName = file;
			modfile.Close();
			ResetWindows();
			UpdateModFileList(true);
			AddOutput("\"" + ActiveMod.Name + "\" loaded successfully!\n");
		}

		/// <summary>
		/// Closes all the "file documents", resets modexplorer and clears the output.
		/// </summary>
		private void ResetWindows()
		{
			if (ActiveMod != null)
			{
				foreach (var t in OpenDocuments)
				{
					t.Close();
					break;
				}
			}
			ModExplorer?.Close();
			ModExplorer = null;
			ShowModExplorer();
			ShowOutput();
			ClearOutput();
		}

		private void ShowModExplorer()
		{
			if (ModExplorer == null || ModExplorer.IsDisposed)
			{
				ModExplorer = new frmModExplorer();
				ModExplorer.Show(dockPanel, DockState.DockLeft);
				ModExplorer.RequestFileOpen += ModExplorer_RequestFileOpen;
				ModExplorer.RequestFileDelete += ModExplorer_RequestFileDelete;
				ModExplorer.RequestFileAdd += ModExplorer_RequestAddFile;
				ModExplorer.RequestFileRename += ModExplorer_RequestFileRename;
			}
			ModExplorer.Activate();
		}

		private void ModExplorer_RequestFileRename(object sender, RequestFileArgs e)
		{
			var filename = e.File;

			var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
			if (!File.Exists(fullpath))
				return;

			var dlg = new frmRenameDialog();
			dlg.FileName = filename;
			if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != filename)
			{
				var newfullpath = Path.Combine(ActiveMod.FileDirectory, dlg.FileName);

				if (File.Exists(newfullpath))
					return;

				// Rename file in file structure
				try
				{
					Directory.CreateDirectory(Path.GetDirectoryName(newfullpath));
				}
				catch
				{
				}

				File.Move(fullpath, newfullpath);

				// Rename file in mod explorer
				if (ModExplorer != null)
				{
					ModExplorer.DeleteNode(filename);
					ModExplorer.UpdateModFileList(true,true);
				}
			}
		}

		private void ModExplorer_RequestAddFile(object sender, RequestFileArgs e)
		{
			addModFile(false,e.File);
		}

		private void ModExplorer_RequestFileDelete(object sender, RequestFileArgs e)
		{
			var filename = e.File;

			if ( MessageBox.Show(
					 "Are you sure you want to permanently delete this?", "Confirmation", MessageBoxButtons.OKCancel
				 ) == DialogResult.OK   )
			{
				removeFromMod(filename);
			}
		}

		private void removeFromMod(string filename)
		{
			// Close open documents
			foreach (var t in OpenDocuments.Where(t => t.FileName == filename))
			{
				t.Close();
				break;
			}


			// Delete from file structure
			var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
			if (File.Exists(fullpath))
			{
				File.Delete(fullpath);
			}
			else
			{
				try
				{
					Directory.Delete(fullpath, true);
				}
				catch (Exception)
				{
					AddOutput("Failed to delete " + fullpath + "!");
				}
			}

			// Delete from mod explorer
			ModExplorer?.DeleteNode(filename);

			SaveMod();
		}

		private void ModExplorer_RequestFileOpen(object sender, RequestFileArgs e)
		{
			var fullpath = Path.Combine(ActiveMod.FileDirectory, e.File);

			var ext = Path.GetExtension(fullpath);

			switch (ext)
			{
				case ".csv":
				case ".xml":
				case ".txt":
					ShellExecute(fullpath);
					break;
				case ".subs":
					PolymorphExecute(fullpath, ".txt");
					break;
				case ".usm":
					LoadUsmFile(fullpath);
					break;
				case ".ws":
					PolymorphExecute(fullpath,".txt");
					break;
				default:
					LoadDocument(fullpath);
					break;
			}
		}

		private static void ShellExecute(string fullpath)
		{
			var proc = new ProcessStartInfo(fullpath) {UseShellExecute = true};
			Process.Start(proc);
		}

		private static void PolymorphExecute(string fullpath, string extension)
		{
			File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] {0x01});
			var programname = new StringBuilder();
			Win32.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
			if (programname.ToString().ToUpper().Contains(".EXE"))
			{
				Process.Start(programname.ToString(), fullpath);
			}
			else
			{
				throw new InvalidFileTypeException("Invalid file type");
			}
		}

		public void LoadUsmFile(string path)
		{
			if (!File.Exists(path) || Path.GetExtension(path) != ".usm")
				return;
			var usmplayer = new frmUsmPlayer(path);
			usmplayer.Show(dockPanel,DockState.Document);

		}

		private void ShowOutput()
		{
			if (Output == null || Output.IsDisposed)
			{
				Output = new frmOutput();
				Output.Show(dockPanel, DockState.DockBottom);
			}

			Output.Focus();
		}

		private void newModToolStripMenuItem_Click(object sender, EventArgs e)
		{
			createNewMod();
		}

		private void createNewMod()
		{
			var dlg = new SaveFileDialog
			{
				Title = @"Create Witcher 3 Mod Project",
				Filter = @"Witcher 3 Mod|*.w3modproj",
				InitialDirectory = MainController.Get().Configuration.InitialModDirectory
			};

			while (dlg.ShowDialog() == DialogResult.OK)
			{
				if (dlg.FileName.Contains(' '))
				{
					MessageBox.Show(
						@"The mod path should not contain spaces because wcc_lite.exe will have trouble with that.",
						"Invalid path");
					continue;
				}

				MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(dlg.FileName);
				var modname = Path.GetFileNameWithoutExtension(dlg.FileName);
				var dirname = Path.GetDirectoryName(dlg.FileName);

				var moddir = Path.Combine(dirname, modname);
				try
				{
					Directory.CreateDirectory(moddir);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Failed to create mod directory: \n" + moddir + "\n\n" + ex.Message);
					return;
				}

				ActiveMod = new W3Mod
				{
					FileName = dlg.FileName,
					Name = modname
				};
				ResetWindows();
				UpdateModFileList(true);
				SaveMod();
				AddOutput("\"" + ActiveMod.Name + "\" sucesfully created and loaded!\n");
				break;
			}
		}

		private void SaveMod()
		{
			var ser = new XmlSerializer(typeof (W3Mod));
			var modfile = new FileStream(ActiveMod.FileName, FileMode.Create, FileAccess.Write);
			ser.Serialize(modfile, ActiveMod);
			modfile.Close();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var settings = new frmSettings();
			settings.ShowDialog();
		}

		private void modExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowModExplorer();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tbtOpen_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Title = "Open CR2W File";
			dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
				LoadDocument(dlg.FileName);
			}
		}

		private void tbtSave_Click(object sender, EventArgs e)
		{
			saveActiveFile();
		}

		private void saveActiveFile()
		{
			if (ActiveDocument != null && !ActiveDocument.IsDisposed)
			{
				saveFile(ActiveDocument);
				AddOutput("Saved!\n");
			}
			
		}

		private void tbtSaveAll_Click(object sender, EventArgs e)
		{
			saveAllFiles();
		}

		private void saveAllFiles()
		{
			foreach (var d in OpenDocuments.Where(d => d.SaveTarget != null))
			{
				saveFile(d);
			}

			foreach (var d in OpenDocuments.Where(d => d.SaveTarget == null))
			{
				saveFile(d);
			}
			AddOutput("All files saved!\n");
		}

		private void saveFile(frmCR2WDocument d)
		{
			d.SaveFile();
		}

		private void btPack_Click(object sender, EventArgs e)
		{
			if (ActiveMod == null)
				return;
			if (Process.GetProcessesByName("Witcher3").Length != 0)
			{
				MessageBox.Show("Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			btPack.Enabled = false;
			var packsettings = new frmPackSettings();
			if (packsettings.ShowDialog() == DialogResult.OK)
			{
				ShowOutput();

				ClearOutput();

				saveAllFiles();

				if (packsettings.PackBundles)
				{
					var taskPackMod = packMod();
					while (!taskPackMod.IsCompleted)
					{
						Application.DoEvents();
					}
				}

				if (packsettings.GenTexCache)
				{
					var taskcookMod = cookMod();
					while (!taskcookMod.IsCompleted)
					{
						Application.DoEvents();
					}
					var taskPackTextureCache = packTextures();
					while (!taskPackTextureCache.IsCompleted)
					{
						Application.DoEvents();
					}
				}
				if (packsettings.GenMetadata)
				{
					var taskMetaData = createModMetaData();
					while (!taskMetaData.IsCompleted)
					{
						Application.DoEvents();
					}
				}

				if (Directory.Exists((ActiveMod.FileDirectory + "\\scripts")) && Directory.GetFiles((ActiveMod.FileDirectory + "\\scripts")).Any())
				{
					if (!Directory.Exists(Path.Combine(ActiveMod.Directory, @"packed\\content\\scripts\\")))
						Directory.CreateDirectory(Path.Combine(ActiveMod.Directory, @"packed\\content\\scripts\\"));
					Directory.GetFiles((ActiveMod.FileDirectory + "\\scripts")).ToList().ForEach(x => File.Copy(x, Path.Combine(ActiveMod.Directory, @"packed\\content\\scripts\\") + Path.GetFileName(x)));
				}

				InstallMod();
			}
			btPack.Enabled = true;
		}

		private void ClearOutput()
		{
			if (Output != null && !Output.IsDisposed)
			{
				Output.Clear();
			}
		}

		private void AddOutput(string text,frmOutput.Logtype type = frmOutput.Logtype.Normal)
		{
			if (Output != null && !Output.IsDisposed)
			{
				if (string.IsNullOrWhiteSpace(text))
					return;

				Output.AddText(text,type);
			}
		}

		private void installMod(string W3ModPackagePath)
		{
			if(!File.Exists(W3ModPackagePath) || Path.GetExtension(W3ModPackagePath) != ".W3ModPackage")
			{
				MessageBox.Show("Corrupted or wrong file!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
				return;
			}
			//TODO: Finish this
		}

		/// <summary>
		/// Installs the mod from the packed folder of the project to the game
		/// </summary>
		private void InstallMod()
		{
			var packedDir = Path.Combine(ActiveMod.Directory, "packed");
			var modName = ActiveMod.Name;

			if (!ActiveMod.InstallAsDLC && !modName.StartsWith("mod"))
				modName = "mod" + modName;

			string gameModDir = null;

			gameModDir = Path.Combine(Path.GetDirectoryName(MainController.Get().Configuration.ExecutablePath),
				ActiveMod.InstallAsDLC ? @"..\..\DLC\" : @"..\..\Mods\", modName);

			if (!Directory.Exists(gameModDir))
				Directory.CreateDirectory(gameModDir);

			var dirs = Directory.GetDirectories(packedDir, "*", SearchOption.AllDirectories);
			foreach (var dir in dirs)
			{
				var relativePath = dir.Substring(packedDir.Length + 1);

				var fulldir = Path.Combine(gameModDir, relativePath);

				if (!Directory.Exists(fulldir))
					Directory.CreateDirectory(fulldir);
			}

			var files = Directory.GetFiles(packedDir, "*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				var relativePath = file.Substring(packedDir.Length + 1);

				var fullpath = Path.Combine(gameModDir, relativePath);

				File.Copy(file, fullpath, true);
			}

			AddOutput("Mod Installed to " + gameModDir + "\n",frmOutput.Logtype.Success);
		}

		private void CreateInstaller()
		{
			if (ActiveMod == null)
				return;
			ShowOutput();
			var packeddir = Path.Combine(ActiveMod.Directory, @"packed\");
			var contentdir = Path.Combine(ActiveMod.Directory, @"packed\content\");
			if (!Directory.Exists(contentdir))
			{
				Directory.CreateDirectory(contentdir);
			}
			else
			{
				var di = new DirectoryInfo(contentdir);
				foreach (var file in di.GetFiles())
				{
					file.Delete();
				}
				foreach (var dir in di.GetDirectories())
				{
					dir.Delete(true);
				}
			}
			var taskPackMod = packMod();
			while (!taskPackMod.IsCompleted)
			{
				Application.DoEvents();
			}

			var taskMetaData = createModMetaData();
			while (!taskMetaData.IsCompleted)
			{
				Application.DoEvents();
			}
			var installdir = Path.Combine(ActiveMod.Directory, @"Installer/");
			if (!Directory.Exists(installdir))
				Directory.CreateDirectory(installdir);
			FileStream fsOut = File.Create(Path.Combine(installdir,ActiveMod.Name + ".W3ModPackage"));
			ZipOutputStream zipStream = new ZipOutputStream(fsOut);
			int folderOffset = packeddir.Length + (packeddir.EndsWith("\\") ? 0 : 1);
			CompressFolder(packeddir,zipStream,folderOffset);
			CompressFile(ActiveMod.FileName,zipStream);
			zipStream.IsStreamOwner = true;
			zipStream.Close();
			AddOutput("Installer created: " + fsOut.Name + "\n",frmOutput.Logtype.Success);
			if (!File.Exists(fsOut.Name))
			{
				AddOutput("Couldn't create installer. Something went wrong.",frmOutput.Logtype.Error);
				return;
			}
			Process.Start("explorer.exe", "/select, \"" + fsOut.Name + "\"");
		}

		private void CompressFile(string filename, ZipOutputStream zipStream)
		{
			FileInfo fi = new FileInfo(filename);

			string entryName = Path.GetFileName(filename);
			entryName = ZipEntry.CleanName(entryName);
			ZipEntry newEntry = new ZipEntry(entryName);
			newEntry.DateTime = fi.LastWriteTime;
			newEntry.Size = fi.Length;
			zipStream.PutNextEntry(newEntry);
			byte[] buffer = new byte[4096];
			using (FileStream streamReader = File.OpenRead(filename))
			{
				StreamUtils.Copy(streamReader, zipStream, buffer);
			}
			zipStream.CloseEntry();
		}

		private void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
		{

			string[] files = Directory.GetFiles(path);

			foreach (string filename in files)
			{

				FileInfo fi = new FileInfo(filename);

				string entryName = filename.Substring(folderOffset);
				entryName = ZipEntry.CleanName(entryName);
				ZipEntry newEntry = new ZipEntry(entryName);
				newEntry.DateTime = fi.LastWriteTime; 
				newEntry.Size = fi.Length;
				zipStream.PutNextEntry(newEntry);
				byte[] buffer = new byte[4096];
				using (FileStream streamReader = File.OpenRead(filename))
				{
					StreamUtils.Copy(streamReader, zipStream, buffer);
				}
				zipStream.CloseEntry();
			}
			string[] folders = Directory.GetDirectories(path);
			foreach (string folder in folders)
			{
				CompressFolder(folder, zipStream, folderOffset);
			}
		}

		private async Task cookMod()
		{
			var config = MainController.Get().Configuration;
			var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
			var cookedDir = Path.Combine(ActiveMod.Directory, @"cooked\content\");
			var uncookedDir = ActiveMod.FileDirectory;
			proc.Arguments = $"cook -platform=pc -mod={uncookedDir} -basedir={uncookedDir}  -outdir={cookedDir}";
			proc.UseShellExecute = false;
			proc.RedirectStandardOutput = true;
			proc.WindowStyle = ProcessWindowStyle.Hidden;
			proc.CreateNoWindow = true;
			if (!Directory.Exists(cookedDir))
			{
				Directory.CreateDirectory(cookedDir);
			}
			else
			{
				var di = new DirectoryInfo(cookedDir);
				foreach (var file in di.GetFiles())
				{
					file.Delete();
				}
				foreach (var dir in di.GetDirectories())
				{
					dir.Delete(true);
				}
			}
			AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n",frmOutput.Logtype.Important);

			using (var process = Process.Start(proc))
			{
				using (var reader = process.StandardOutput)
				{
					while (true)
					{
						var result = await reader.ReadLineAsync();

						AddOutput(result + "\n", frmOutput.Logtype.Wcc);

						Application.DoEvents();

						if (reader.EndOfStream)
							break;
					}
				}
			}
		}

		private async Task packTextures()
		{
			var config = MainController.Get().Configuration;
			var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
			var packedDir = Path.Combine(ActiveMod.Directory, @"packed\content\");
			var cookedDir = Path.Combine(ActiveMod.Directory, @"cooked\content\");
			var uncookedDir = ActiveMod.FileDirectory;
			proc.Arguments = $"buildcache textures -basedir={uncookedDir} -platform=pc -db={cookedDir}\\cook.db  -out={packedDir}\\texture.cache";
			proc.UseShellExecute = false;
			proc.RedirectStandardOutput = true;
			proc.WindowStyle = ProcessWindowStyle.Hidden;
			proc.CreateNoWindow = true;

			AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

			using (var process = Process.Start(proc))
			{
				using (var reader = process.StandardOutput)
				{
					while (true)
					{
						var result = await reader.ReadLineAsync();

						AddOutput(result + "\n", frmOutput.Logtype.Wcc);

						Application.DoEvents();

						if (reader.EndOfStream)
							break;
					}
				}
			}
		}

		private async Task packMod()
		{
			var config = MainController.Get().Configuration;
			var proc = new ProcessStartInfo(config.WccLite) {WorkingDirectory = Path.GetDirectoryName(config.WccLite)};
			var packedDir = Path.Combine(ActiveMod.Directory, @"packed\content\");
			var uncookedDir = ActiveMod.FileDirectory;
			if (!Directory.Exists(packedDir))
			{
				Directory.CreateDirectory(packedDir);
			}
			else
			{
				var di = new DirectoryInfo(packedDir);
				foreach (var file in di.GetFiles())
				{
					file.Delete();
				}
				foreach (var dir in di.GetDirectories())
				{
					dir.Delete(true);
				}
			}

			proc.Arguments = $"pack -dir={uncookedDir} -outdir={packedDir}";
			proc.UseShellExecute = false;
			proc.RedirectStandardOutput = true;
			proc.WindowStyle = ProcessWindowStyle.Hidden;
			proc.CreateNoWindow = true;

			AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

			using (var process = Process.Start(proc))
			{
				using (var reader = process.StandardOutput)
				{
					while (true)
					{
						var result = await reader.ReadLineAsync();

						AddOutput(result + "\n", frmOutput.Logtype.Wcc);

						Application.DoEvents();

						if (reader.EndOfStream)
							break;
					}
				}
			}
		}

		private async Task createModMetaData()
		{
			var config = MainController.Get().Configuration;
			var proc = new ProcessStartInfo(config.WccLite) {WorkingDirectory = Path.GetDirectoryName(config.WccLite)};
			var packedDir = Path.Combine(ActiveMod.Directory, @"packed\content\");

			proc.Arguments = $"metadatastore -path={packedDir}";
			proc.UseShellExecute = false;
			proc.RedirectStandardOutput = true;
			proc.WindowStyle = ProcessWindowStyle.Hidden;
			proc.CreateNoWindow = true;

			AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

			using (var process = Process.Start(proc))
			{
				using (var reader = process.StandardOutput)
				{
					while (true)
					{
						var result = await reader.ReadLineAsync();

						AddOutput(result + "\n",frmOutput.Logtype.Wcc);

						Application.DoEvents();

						if (reader.EndOfStream)
							break;
					}
				}
			}
		}

		private async void executeGame(string args = "")
		{
			if(ActiveMod == null)
				return;
			if (Process.GetProcessesByName("Witcher3").Length != 0)
			{
				MessageBox.Show(@"Game is already running!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			var config = MainController.Get().Configuration;
			var proc = new ProcessStartInfo(config.ExecutablePath)
			{
				WorkingDirectory = Path.GetDirectoryName(config.ExecutablePath),
				Arguments = args == "" ? "-net -debugscripts" : args,
				UseShellExecute = false,
				RedirectStandardOutput = true
			};


			AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n");

			var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
			if (File.Exists(scriptlog))
				File.Delete(scriptlog);

			using (var process = Process.Start(proc))
			{
				var task2 = RedirectScriptlogOutput(process);

				await task2;
			}
		}

		private async Task RedirectScriptlogOutput(Process process)
		{
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
			using (var fs = new FileStream(scriptlog, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
			{
				using (var fsr = new StreamReader(fs))
				{
					while (!process.HasExited)
					{
						var result = await fsr.ReadToEndAsync();

						AddOutput(result);

						Application.DoEvents();
					}
				}
				fs.Close();
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			var Exit = false;
			while (!File.Exists(MainController.Get().Configuration.ExecutablePath))
			{
				var sets = new frmSettings();
				if (sets.ShowDialog() != DialogResult.OK)
				{
					Exit = true;
					break;
				}
			}

			if (Exit)
				Close();
		}

		private void tbtNewMod_Click(object sender, EventArgs e)
		{
			createNewMod();
		}

		private void tbtOpenMod_Click(object sender, EventArgs e)
		{
			openMod();
		}

		private void addFileFromBundleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addModFile(false);
		}

		private void modSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ActiveMod == null)
				return;
			//With this cloned it won't get modified when we change it in dlg
			var oldmod = (W3Mod)ActiveMod.Clone();
			using (var dlg = new frmModSettings())
			{
				dlg.Mod = ActiveMod;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					if (oldmod.Name != dlg.Mod.Name)
					{
						MainController.Get()?.Window?.ModExplorer?.StopMonitoringDirectory();
						//Close all docs so they won't cause problems
						OpenDocuments.ForEach(x=> x.Close());
						//Move the files directory
						Directory.Move(oldmod.Directory,Path.Combine(Path.GetDirectoryName(oldmod.Directory),dlg.Mod.Name));
						//Delete the old directory
						if(Directory.Exists(oldmod.Directory))
							Commonfunctions.DeleteFilesAndFoldersRecursively(oldmod.Directory);
						//Delete the old mod project file
						if(File.Exists(oldmod.FileName))
							File.Delete(oldmod.FileName);
					}
					//Save the new settings and update the title
					UpdateTitle();
					SaveMod();
					if (File.Exists(ModManager.Get().ActiveMod?.FileName))
					{
						openMod(ModManager.Get().ActiveMod?.FileName);
					}
					Commonfunctions.SendNotification("Succesfully updated mod settings!");
				}
			}
		}

		private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var cf = new frmAbout())
				cf.ShowDialog();
		}

		private void addFileToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Title = "Open CR2W File";
			dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
				LoadDocument(dlg.FileName);
			}
		}

		private void saveExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var sef = new frmSaveEditor())
				sef.ShowDialog();
		}

		private void stringsGUIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var sg = new frmStringsGui())
				sg.ShowDialog();
		}

		private void joinOurDiscordToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show(@"Are you sure you would like to join the modding discord?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
				Process.Start("https://discord.gg/qBNgDEX");
		}

		private void wcclitePatcherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var pw = new frmWCCPatch())
				pw.ShowDialog();
		}

		private void outputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowOutput();
		}

		private void WitcherScriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://witcherscript.readthedocs.io");
		}

		private void reloadProjectToolStripMenuItem_Click(object sender, EventArgs e)
		{	
			if (File.Exists(ModManager.Get().ActiveMod?.FileName))
			{
				openMod(ModManager.Get().ActiveMod?.FileName);
			}
		}

		private void addFileFromOtherModToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			addModFile(true);
		}

		private void createPackedInstallerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CreateInstaller();
		}

		private void witcherIIIModdingToolLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var wcclicense = new frmWCCLicense();
			wcclicense.Show();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveActiveFile();
		}

		private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveAllFiles();
		}

		private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ActiveMod == null)
				return;

			var scriptsdirectory = (ActiveMod.FileDirectory + "\\scripts");
			if (!Directory.Exists(scriptsdirectory))
			{
				Directory.CreateDirectory(scriptsdirectory);
			}
			var fullPath = scriptsdirectory + "\\" + "blank_script.ws";
			var count = 1;
			var fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
			var extension = Path.GetExtension(fullPath);
			var path = Path.GetDirectoryName(fullPath);
			var newFullPath = fullPath;
			while (File.Exists(newFullPath))
			{
				string tempFileName = $"{fileNameOnly}({count++})";
				if (path != null) newFullPath = Path.Combine(path, tempFileName + extension);
			}
			File.WriteAllLines(newFullPath, new[] {@"/*",$"Wolven kit - {Version}",DateTime.Now.ToString("d"),@"*/"});
		}

		private void chunkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"Not implemented yet. I'm not sure how this should work yet.",@"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void launchWithCostumParametersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var getparams = new Input("Please give the commands to launch the game with!");
			if (getparams.ShowDialog() == DialogResult.OK)
			{
				executeGame(getparams.Resulttext);
			}
		}

		private void launchGameForDebuggingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			executeGame();
		}

		private void menuCreatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var fmc = new frmMenuCreator())
			{
				fmc.ShowDialog();
			}
		}

		private void recordStepsToReproduceBugToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(@"This will launch an app that will help you record the steps needed to reproduce the bug/problem.
After its done it saves a zip file.
Please send that to hambalko.bence@gmail.com with a short description about the problem.
Would you like to open the problem steps recorder?","Bug reporting",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Process.Start("psr.exe");
			}
		}

		private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("When reporting a bug please create a reproducion file at Help->Record steps to reproduce.",
				"Bug reporting",
				MessageBoxButtons.OK,MessageBoxIcon.Information);
			Process.Start($"mailto:{"hambalko.bence@gmail.com"}?Subject={"WolvenKit bug report"}&Body={"Short description of bug:"}");
		}

		private void gameDebuggerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var gdb = new frmDebug();
			gdb.Show();
		}
	}
}