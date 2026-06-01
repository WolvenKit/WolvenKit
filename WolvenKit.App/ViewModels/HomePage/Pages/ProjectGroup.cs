using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.HomePage.Pages;

public partial class WelcomePageViewModel
{
    // NOUVEAU : représente un groupe de projets (en-tête + liste de cartes) sur la page d'accueil.
    public partial class ProjectGroup : ObservableObject
    {
        public ProjectGroup(string name, IEnumerable<FancyProjectObject> projects)
        {
            Name = name;
            Projects = new ObservableCollection<FancyProjectObject>(projects);
        }

        public string Name { get; }
        public ObservableCollection<FancyProjectObject> Projects { get; }

        // NOUVEAU : true = groupe déplié (cartes visibles), false = replié.
        [ObservableProperty]
        private bool _isExpanded = true;
    }
}
