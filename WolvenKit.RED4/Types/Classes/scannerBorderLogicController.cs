using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scannerBorderLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("braindanceSetVisible")] 
		public CArray<inkWidgetReference> BraindanceSetVisible
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(2)] 
		[RED("braindanceSetHidden")] 
		public CArray<inkWidgetReference> BraindanceSetHidden
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public scannerBorderLogicController()
		{
			BraindanceSetVisible = new();
			BraindanceSetHidden = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
