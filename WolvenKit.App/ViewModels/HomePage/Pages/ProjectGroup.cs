using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.HomePage.Pages;

public partial class WelcomePageViewModel
{
    // Represents a project group (header + list of cards) on the welcome page.
    public partial class ProjectGroup : ObservableObject
    {
        public ProjectGroup(string name, IEnumerable<FancyProjectObject> projects)
        {
            Name = name;
            Projects = new ObservableCollection<FancyProjectObject>(projects);
        }

        public string Name { get; }
        public ObservableCollection<FancyProjectObject> Projects { get; }

        // true = group expanded (cards visible), false = collapsed.
        [ObservableProperty]
        private bool _isExpanded = true;
    }
}
