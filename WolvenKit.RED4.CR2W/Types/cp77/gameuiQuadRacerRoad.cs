using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerRoad : gameuiSideScrollerMiniGameDynObjectLogic
	{
		private inkQuadWidgetReference _roadQuad;
		private inkQuadWidgetReference _leftBackground;
		private inkQuadWidgetReference _rightBackground;
		private CArray<CName> _groundParts;
		private CArray<CName> _roadParts;

		[Ordinal(2)] 
		[RED("roadQuad")] 
		public inkQuadWidgetReference RoadQuad
		{
			get => GetProperty(ref _roadQuad);
			set => SetProperty(ref _roadQuad, value);
		}

		[Ordinal(3)] 
		[RED("leftBackground")] 
		public inkQuadWidgetReference LeftBackground
		{
			get => GetProperty(ref _leftBackground);
			set => SetProperty(ref _leftBackground, value);
		}

		[Ordinal(4)] 
		[RED("rightBackground")] 
		public inkQuadWidgetReference RightBackground
		{
			get => GetProperty(ref _rightBackground);
			set => SetProperty(ref _rightBackground, value);
		}

		[Ordinal(5)] 
		[RED("groundParts")] 
		public CArray<CName> GroundParts
		{
			get => GetProperty(ref _groundParts);
			set => SetProperty(ref _groundParts, value);
		}

		[Ordinal(6)] 
		[RED("roadParts")] 
		public CArray<CName> RoadParts
		{
			get => GetProperty(ref _roadParts);
			set => SetProperty(ref _roadParts, value);
		}

		public gameuiQuadRacerRoad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
