using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Catel.IoC;
using CP77.CR2W.Types;
using Orc.ProjectManagement;
using ProtoBuf.Meta;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Model;
using MessageBox = System.Windows.Forms.MessageBox;
using WolvenKit.Common.Services;
using Catel.Services;
using Catel;
using Catel.Threading;

namespace WolvenKit.ViewModels.AssetBrowser
{
    public class AssetBrowserViewModel : ToolViewModel
    {

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "AssetBrowser_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "AssetBrowser";
        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;


        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        public GameFileTreeNode CurrentNode { get; set; } = new GameFileTreeNode();
        public List<AssetBrowserData> CurrentNodeFiles { get; set; } = new List<AssetBrowserData>();
        public GameFileTreeNode RootNode { get; set; }
        public List<IGameFile> SelectedFiles { get; set; }
        public List<IGameArchiveManager> Managers { get; set; }
        public List<string> Extensions { get; set; }
        public string SelectedExtension { get; set; }
        public List<string> Classes { get; set; }
        public string SelectedClass { get; set; }
        public GridLength PreviewWidth { get; set; }
        public bool PreviewVisible { get; set; }
        public AssetBrowserData SelectedNode { get; set; }
        public List<AssetBrowserData> SelectedNodes { get; set; }

        public AssetBrowserViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
         
            SetupToolDefaults();
            ReInit();


        }

        public void ReInit()
        {
            SelectedFiles = new List<IGameFile>();
            Managers = MainController.Get().GetManagers(true);

            this.CurrentNode = new GameFileTreeNode(EArchiveType.ANY)
            {
                Name = "Depot"
            };
            foreach (var mngr in MainController.Get().GetManagers(true))
            {
                if (mngr.RootNode != null)
                {
                    mngr.RootNode.Parent = this.CurrentNode;
                    this.CurrentNode.Directories.Add(mngr.TypeName.ToString(), mngr.RootNode);
                }
            }
            this.CurrentNodeFiles = this.CurrentNode.ToAssetBrowserData();
            this.RootNode = this.CurrentNode;
            this.Extensions = MainController.Get().GetManagers(true).SelectMany(x => x.Extensions).ToList();
            this.Classes = MainController.Get().GetGame().GetAvaliableClasses();
            this.PreviewWidth = new GridLength(0, GridUnitType.Pixel);
            this.PreviewVisible = false;
        }

      
        public void PerformSearch(string query)
        {
            var newnode = new GameFileTreeNode()
            {
                Name = "",
                Parent = CurrentNode,
                Directories = new Dictionary<string, GameFileTreeNode>(),
                Files = new Dictionary<string, List<IGameFile>>()
            };
            newnode.Files = Managers.
                SelectMany(_ => CollectFiles(query, _))
                .GroupBy(x => x.Name)
                .Select(x => x.First())
                .Select(f => new KeyValuePair<string, List<IGameFile>>(f.Name, new List<IGameFile>(){f}))
                .ToDictionary(x => x.Key, x => x.Value);
            this.CurrentNode = newnode;
            CurrentNodeFiles = CurrentNode.ToAssetBrowserData();
        }

        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;           // Define a unique contentid for this toolwindow

            //BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow
            //bi.BeginInit();
            //bi.UriSource = new Uri("pack://application:,,/Resources/Images/property-blue.png");
            //bi.EndInit();
            //IconSource = bi;
        }

        public void ImportFile(AssetBrowserData item)
        {
            switch (item.Type)
            {
                case EntryType.Directory:
                {
                    CurrentNode = item.Children;
                    CurrentNode.Parent = item.This;
                    CurrentNodeFiles = item.Children.ToAssetBrowserData();
                    break;
                }
                case EntryType.File:
                {
                    Task.Run(new Action(() => AddToMod(item.This.Files.First(x => x.Key == item.Name).Value.First())));
                    MessageBox.Show( "Importing file: " + item.Name, "File import");
                    break;
                }
                case EntryType.MoveUP:
                {
                    if (item.Parent != null)
                    {
                        CurrentNode = item.Parent;
                        CurrentNodeFiles = item.Parent.ToAssetBrowserData();
                    }
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void AddToMod(IGameFile file)
        {
            var pm = ServiceLocator.Default.ResolveType<IProjectManager>();
            var project = ((EditorProject) (pm.ActiveProject));
            switch (project.GameType)
            {
                case GameType.Witcher3:
                {
                    var witcherProject = project as Tw3Project;
                    var DiskPath = Path.Combine(witcherProject.ModCookedDirectory, file.Name);
                    Directory.CreateDirectory(Path.GetDirectoryName(DiskPath));
                    using (FileStream fs = new FileStream(DiskPath, FileMode.Create))
                    {
                        file.Extract(fs);
                    }
                    break;
                }
                case GameType.Cyberpunk2077:
                {
                    var cyberpunkProject = project as Cp77Project;
                    var DiskPath = Path.Combine(cyberpunkProject.ModDirectory, file.Name);
                    Directory.CreateDirectory(Path.GetDirectoryName(DiskPath));
                    using (FileStream fs = new FileStream(DiskPath, FileMode.Create))
                    {
                        file.Extract(fs);
                    }
                    break;
                }
                default:
                    break;
            }   
        }

        public List<IGameFile> CollectFiles(string searchkeyword, IGameArchiveManager root)
        {
            var ret = new Dictionary<string, IGameFile>();
            foreach (var f in root.FileList)
            {
                if (f.Name.ToUpper().Contains(searchkeyword.ToUpper()))
                {
                    if(!ret.ContainsKey(f.Name))
                        ret.TryAdd(f.Name, f);
                }
            }
            return ret.Values.ToList();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: Write initialization code here and subscribe to events
        }

        protected override Task CloseAsync()
        {
            // TODO: Unsubscribe from events


            return base.CloseAsync();
        }


    }
}
