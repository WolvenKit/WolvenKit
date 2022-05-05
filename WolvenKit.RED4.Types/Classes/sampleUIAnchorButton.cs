using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUIAnchorButton : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("anchorLocation")] 
		public CEnum<inkEAnchor> AnchorLocation
		{
			get => GetPropertyValue<CEnum<inkEAnchor>>();
			set => SetPropertyValue<CEnum<inkEAnchor>>(value);
		}

		public sampleUIAnchorButton()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
