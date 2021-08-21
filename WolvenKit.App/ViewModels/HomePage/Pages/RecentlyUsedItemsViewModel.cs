using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using WolvenKit.Functionality.ProjectManagement;

namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class RecentlyUsedItemsViewModel : ReactiveObject
    {
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly ReadOnlyObservableCollection<RecentlyUsedItemModel> _recentlyUsedItems;


        public RecentlyUsedItemsViewModel()
        {
            
        }

    }
}
