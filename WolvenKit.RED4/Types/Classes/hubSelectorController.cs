using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hubSelectorController : inkSelectorController
	{
		[Ordinal(15)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("menuLabelHolder")] 
		public inkHorizontalPanelWidgetReference MenuLabelHolder
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("selectedMenuLabel")] 
		public CWeakHandle<HubMenuLabelController> SelectedMenuLabel
		{
			get => GetPropertyValue<CWeakHandle<HubMenuLabelController>>();
			set => SetPropertyValue<CWeakHandle<HubMenuLabelController>>(value);
		}

		[Ordinal(19)] 
		[RED("previouslySelectedMenuLabel")] 
		public CWeakHandle<HubMenuLabelController> PreviouslySelectedMenuLabel
		{
			get => GetPropertyValue<CWeakHandle<HubMenuLabelController>>();
			set => SetPropertyValue<CWeakHandle<HubMenuLabelController>>(value);
		}

		[Ordinal(20)] 
		[RED("hubElementsData")] 
		public CArray<MenuData> HubElementsData
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		[Ordinal(21)] 
		[RED("previousIndex")] 
		public CInt32 PreviousIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public hubSelectorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
