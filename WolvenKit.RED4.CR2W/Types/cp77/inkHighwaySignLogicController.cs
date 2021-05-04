using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHighwaySignLogicController : inkIStreetNameSignLogicController
	{
		private inkTextWidgetReference _districtName;
		private inkTextWidgetReference _subDistrictName;
		private inkImageWidgetReference _metroStationIconLeft;
		private inkImageWidgetReference _metroStationIconRight;

		[Ordinal(1)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetProperty(ref _districtName);
			set => SetProperty(ref _districtName, value);
		}

		[Ordinal(2)] 
		[RED("subDistrictName")] 
		public inkTextWidgetReference SubDistrictName
		{
			get => GetProperty(ref _subDistrictName);
			set => SetProperty(ref _subDistrictName, value);
		}

		[Ordinal(3)] 
		[RED("metroStationIconLeft")] 
		public inkImageWidgetReference MetroStationIconLeft
		{
			get => GetProperty(ref _metroStationIconLeft);
			set => SetProperty(ref _metroStationIconLeft, value);
		}

		[Ordinal(4)] 
		[RED("metroStationIconRight")] 
		public inkImageWidgetReference MetroStationIconRight
		{
			get => GetProperty(ref _metroStationIconRight);
			set => SetProperty(ref _metroStationIconRight, value);
		}

		public inkHighwaySignLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
