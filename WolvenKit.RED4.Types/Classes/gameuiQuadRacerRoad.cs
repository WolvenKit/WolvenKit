using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiQuadRacerRoad : gameuiSideScrollerMiniGameDynObjectLogic
	{
		[Ordinal(2)] 
		[RED("roadQuad")] 
		public inkQuadWidgetReference RoadQuad
		{
			get => GetPropertyValue<inkQuadWidgetReference>();
			set => SetPropertyValue<inkQuadWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("leftBackground")] 
		public inkQuadWidgetReference LeftBackground
		{
			get => GetPropertyValue<inkQuadWidgetReference>();
			set => SetPropertyValue<inkQuadWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rightBackground")] 
		public inkQuadWidgetReference RightBackground
		{
			get => GetPropertyValue<inkQuadWidgetReference>();
			set => SetPropertyValue<inkQuadWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("groundParts")] 
		public CArray<CName> GroundParts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("roadParts")] 
		public CArray<CName> RoadParts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameuiQuadRacerRoad()
		{
			RoadQuad = new();
			LeftBackground = new();
			RightBackground = new();
			GroundParts = new();
			RoadParts = new();
		}
	}
}
