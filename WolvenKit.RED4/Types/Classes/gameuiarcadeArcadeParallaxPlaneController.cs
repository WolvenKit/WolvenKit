using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeParallaxPlaneController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("displacementAxis")] 
		public CEnum<gameuiarcadeArcadeParallaxPlaneControllerDisplacementAxis> DisplacementAxis
		{
			get => GetPropertyValue<CEnum<gameuiarcadeArcadeParallaxPlaneControllerDisplacementAxis>>();
			set => SetPropertyValue<CEnum<gameuiarcadeArcadeParallaxPlaneControllerDisplacementAxis>>(value);
		}

		[Ordinal(2)] 
		[RED("loopType")] 
		public CEnum<gameuiarcadeArcadeParallaxPlaneControllerLoopType> LoopType
		{
			get => GetPropertyValue<CEnum<gameuiarcadeArcadeParallaxPlaneControllerLoopType>>();
			set => SetPropertyValue<CEnum<gameuiarcadeArcadeParallaxPlaneControllerLoopType>>(value);
		}

		[Ordinal(3)] 
		[RED("segmentList")] 
		public CArray<inkWidgetReference> SegmentList
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public gameuiarcadeArcadeParallaxPlaneController()
		{
			LoopType = Enums.gameuiarcadeArcadeParallaxPlaneControllerLoopType.Repeat;
			SegmentList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
