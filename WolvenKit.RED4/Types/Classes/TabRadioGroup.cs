using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TabRadioGroup : inkRadioGroupController
	{
		[Ordinal(5)] 
		[RED("root")] 
		public inkCompoundWidgetReference Root
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("toggles")] 
		public CArray<CWeakHandle<TabButtonController>> Toggles
		{
			get => GetPropertyValue<CArray<CWeakHandle<TabButtonController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<TabButtonController>>>(value);
		}

		[Ordinal(7)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		public TabRadioGroup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
