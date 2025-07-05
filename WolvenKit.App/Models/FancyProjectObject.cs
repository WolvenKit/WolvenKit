using System;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement;

namespace WolvenKit.App.ViewModels.HomePage.Pages;

public partial class WelcomePageViewModel
{
    public class FancyProjectObject : ObservableObject
    {
        #region Constructors

        public FancyProjectObject(RecentlyUsedItemModel recentlyUsedItemModel, string name, DateTime createdate, string type, string path, string image)
        {
            Item = recentlyUsedItemModel;

            Name = name;
            CreationDate = createdate;
            Type = type;
            ProjectPath = path;
            Image = image;
            SafeName = Path.GetFileNameWithoutExtension(name);
        }

        #endregion Constructors

        #region Properties

        public RecentlyUsedItemModel Item { get; }
        public DateTime CreationDate { get; set; }
        public string Image { get; set; }
        public DateTime LastEditDate { get; set; }
        public string Name { get; set; }

        public string ProjectColor => ((uint)string.GetHashCode(ProjectPath) % 7).ToString();

        public string SafeName { get; set; }
        public string ProjectPath { get; set; }
        public string Type { get; set; }

        public bool IsPinned
        {
            get => Item.IsPinned; 
            set => Item.IsPinned = value;
        }

        #endregion Properties
    }
}
