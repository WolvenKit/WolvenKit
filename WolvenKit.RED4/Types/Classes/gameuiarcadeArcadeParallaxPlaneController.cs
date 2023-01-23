using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeParallaxPlaneController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("segmentList")] 
		public CArray<inkWidgetReference> SegmentList
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public gameuiarcadeArcadeParallaxPlaneController()
		{
			SegmentList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
