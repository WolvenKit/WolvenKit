using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Catel.IoC;
using Catel.MVVM.Views;
using DynamicData.Binding;
using Feather.Controls;
using Syncfusion.Windows.Controls.Layout;
using WolvenKit.ViewModels.HomePage.Pages;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class SettingsPageView
    {
        #region Constructors

        public SettingsPageView()
        {
            InitializeComponent();
            var vm = ServiceLocator.Default.ResolveType<SettingsPageViewModel>();
            AccordionItems = SfAccordion.Items;
        }

        #endregion Constructors

        #region properties

        [ViewToViewModel(MappingType = ViewToViewModelMappingType.TwoWayViewWins)]
        public ItemCollection AccordionItems
        {
            get
            {
                return (ItemCollection)GetValue(AccordionItemsProperty);
            }
            set
            {
                SetValue(AccordionItemsProperty, value);
            }
        }

        public static readonly DependencyProperty AccordionItemsProperty =
            DependencyProperty.Register(nameof(AccordionItems), typeof(ItemCollection), typeof(SettingsPageView));

        #endregion

        #region Methods

        private void TabControlDemo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // I wanted to add logic that the selected tab item moves to be the first in the row but I am not sure it works with the HC tabcontrol. If someone feels liek testing this later go ahead :D
        }

        #endregion Methods
    }
}
