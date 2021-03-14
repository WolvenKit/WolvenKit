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
			get
			{
				if (_districtName == null)
				{
					_districtName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "districtName", cr2w, this);
				}
				return _districtName;
			}
			set
			{
				if (_districtName == value)
				{
					return;
				}
				_districtName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("subDistrictName")] 
		public inkTextWidgetReference SubDistrictName
		{
			get
			{
				if (_subDistrictName == null)
				{
					_subDistrictName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "subDistrictName", cr2w, this);
				}
				return _subDistrictName;
			}
			set
			{
				if (_subDistrictName == value)
				{
					return;
				}
				_subDistrictName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("metroStationIconLeft")] 
		public inkImageWidgetReference MetroStationIconLeft
		{
			get
			{
				if (_metroStationIconLeft == null)
				{
					_metroStationIconLeft = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "metroStationIconLeft", cr2w, this);
				}
				return _metroStationIconLeft;
			}
			set
			{
				if (_metroStationIconLeft == value)
				{
					return;
				}
				_metroStationIconLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("metroStationIconRight")] 
		public inkImageWidgetReference MetroStationIconRight
		{
			get
			{
				if (_metroStationIconRight == null)
				{
					_metroStationIconRight = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "metroStationIconRight", cr2w, this);
				}
				return _metroStationIconRight;
			}
			set
			{
				if (_metroStationIconRight == value)
				{
					return;
				}
				_metroStationIconRight = value;
				PropertySet(this);
			}
		}

		public inkHighwaySignLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
