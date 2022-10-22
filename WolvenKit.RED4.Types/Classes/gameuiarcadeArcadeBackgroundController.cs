using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeBackgroundController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("backgroundLayerList")] 
		public CArray<inkWidgetReference> BackgroundLayerList
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public gameuiarcadeArcadeBackgroundController()
		{
			BackgroundLayerList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
