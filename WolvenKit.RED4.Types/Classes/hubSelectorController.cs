using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hubSelectorController : inkSelectorController
	{
		private inkWidgetReference _leftArrowWidget;
		private inkWidgetReference _rightArrowWidget;
		private inkHorizontalPanelWidgetReference _menuLabelHolder;
		private CWeakHandle<HubMenuLabelController> _selectedMenuLabel;
		private CWeakHandle<HubMenuLabelController> _previouslySelectedMenuLabel;
		private CArray<MenuData> _hubElementsData;
		private CInt32 _previousIndex;

		[Ordinal(15)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get => GetProperty(ref _leftArrowWidget);
			set => SetProperty(ref _leftArrowWidget, value);
		}

		[Ordinal(16)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get => GetProperty(ref _rightArrowWidget);
			set => SetProperty(ref _rightArrowWidget, value);
		}

		[Ordinal(17)] 
		[RED("menuLabelHolder")] 
		public inkHorizontalPanelWidgetReference MenuLabelHolder
		{
			get => GetProperty(ref _menuLabelHolder);
			set => SetProperty(ref _menuLabelHolder, value);
		}

		[Ordinal(18)] 
		[RED("selectedMenuLabel")] 
		public CWeakHandle<HubMenuLabelController> SelectedMenuLabel
		{
			get => GetProperty(ref _selectedMenuLabel);
			set => SetProperty(ref _selectedMenuLabel, value);
		}

		[Ordinal(19)] 
		[RED("previouslySelectedMenuLabel")] 
		public CWeakHandle<HubMenuLabelController> PreviouslySelectedMenuLabel
		{
			get => GetProperty(ref _previouslySelectedMenuLabel);
			set => SetProperty(ref _previouslySelectedMenuLabel, value);
		}

		[Ordinal(20)] 
		[RED("hubElementsData")] 
		public CArray<MenuData> HubElementsData
		{
			get => GetProperty(ref _hubElementsData);
			set => SetProperty(ref _hubElementsData, value);
		}

		[Ordinal(21)] 
		[RED("previousIndex")] 
		public CInt32 PreviousIndex
		{
			get => GetProperty(ref _previousIndex);
			set => SetProperty(ref _previousIndex, value);
		}
	}
}
