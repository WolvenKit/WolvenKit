using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioControllerPS : MediaDeviceControllerPS
	{
		private RadioSetup _radioSetup;
		private CArray<RadioStationsMap> _stations;
		private CBool _stationsInitialized;

		[Ordinal(108)] 
		[RED("radioSetup")] 
		public RadioSetup RadioSetup
		{
			get
			{
				if (_radioSetup == null)
				{
					_radioSetup = (RadioSetup) CR2WTypeManager.Create("RadioSetup", "radioSetup", cr2w, this);
				}
				return _radioSetup;
			}
			set
			{
				if (_radioSetup == value)
				{
					return;
				}
				_radioSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get
			{
				if (_stations == null)
				{
					_stations = (CArray<RadioStationsMap>) CR2WTypeManager.Create("array:RadioStationsMap", "stations", cr2w, this);
				}
				return _stations;
			}
			set
			{
				if (_stations == value)
				{
					return;
				}
				_stations = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("stationsInitialized")] 
		public CBool StationsInitialized
		{
			get
			{
				if (_stationsInitialized == null)
				{
					_stationsInitialized = (CBool) CR2WTypeManager.Create("Bool", "stationsInitialized", cr2w, this);
				}
				return _stationsInitialized;
			}
			set
			{
				if (_stationsInitialized == value)
				{
					return;
				}
				_stationsInitialized = value;
				PropertySet(this);
			}
		}

		public RadioControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
