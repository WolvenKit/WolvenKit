using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystemSetVendorPanelVendorSorting : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("sortMode")] 
		public CInt32 SortMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public UIScriptableSystemSetVendorPanelVendorSorting()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
