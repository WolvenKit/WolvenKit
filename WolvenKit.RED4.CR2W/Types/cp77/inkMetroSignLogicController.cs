using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMetroSignLogicController : inkIStreetNameSignLogicController
	{
		private inkTextWidgetReference _stationName;
		private inkTextWidgetReference _subDistrictName;
		private inkCompoundWidgetReference _metroStationsContainer;
		private CName _metroStationLibraryName;
		private CName _metroStationTextWidgetName;

		[Ordinal(1)] 
		[RED("stationName")] 
		public inkTextWidgetReference StationName
		{
			get
			{
				if (_stationName == null)
				{
					_stationName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "stationName", cr2w, this);
				}
				return _stationName;
			}
			set
			{
				if (_stationName == value)
				{
					return;
				}
				_stationName = value;
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
		[RED("metroStationsContainer")] 
		public inkCompoundWidgetReference MetroStationsContainer
		{
			get
			{
				if (_metroStationsContainer == null)
				{
					_metroStationsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "metroStationsContainer", cr2w, this);
				}
				return _metroStationsContainer;
			}
			set
			{
				if (_metroStationsContainer == value)
				{
					return;
				}
				_metroStationsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("metroStationLibraryName")] 
		public CName MetroStationLibraryName
		{
			get
			{
				if (_metroStationLibraryName == null)
				{
					_metroStationLibraryName = (CName) CR2WTypeManager.Create("CName", "metroStationLibraryName", cr2w, this);
				}
				return _metroStationLibraryName;
			}
			set
			{
				if (_metroStationLibraryName == value)
				{
					return;
				}
				_metroStationLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("metroStationTextWidgetName")] 
		public CName MetroStationTextWidgetName
		{
			get
			{
				if (_metroStationTextWidgetName == null)
				{
					_metroStationTextWidgetName = (CName) CR2WTypeManager.Create("CName", "metroStationTextWidgetName", cr2w, this);
				}
				return _metroStationTextWidgetName;
			}
			set
			{
				if (_metroStationTextWidgetName == value)
				{
					return;
				}
				_metroStationTextWidgetName = value;
				PropertySet(this);
			}
		}

		public inkMetroSignLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
