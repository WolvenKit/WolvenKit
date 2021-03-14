using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxControllerPS : ScriptableDeviceComponentPS
	{
		private JukeboxSetup _jukeboxSetup;
		private CArray<RadioStationsMap> _stations;
		private CInt32 _activeStation;
		private CBool _isPlaying;

		[Ordinal(103)] 
		[RED("jukeboxSetup")] 
		public JukeboxSetup JukeboxSetup
		{
			get
			{
				if (_jukeboxSetup == null)
				{
					_jukeboxSetup = (JukeboxSetup) CR2WTypeManager.Create("JukeboxSetup", "jukeboxSetup", cr2w, this);
				}
				return _jukeboxSetup;
			}
			set
			{
				if (_jukeboxSetup == value)
				{
					return;
				}
				_jukeboxSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
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

		[Ordinal(105)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get
			{
				if (_activeStation == null)
				{
					_activeStation = (CInt32) CR2WTypeManager.Create("Int32", "activeStation", cr2w, this);
				}
				return _activeStation;
			}
			set
			{
				if (_activeStation == value)
				{
					return;
				}
				_activeStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get
			{
				if (_isPlaying == null)
				{
					_isPlaying = (CBool) CR2WTypeManager.Create("Bool", "isPlaying", cr2w, this);
				}
				return _isPlaying;
			}
			set
			{
				if (_isPlaying == value)
				{
					return;
				}
				_isPlaying = value;
				PropertySet(this);
			}
		}

		public JukeboxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
