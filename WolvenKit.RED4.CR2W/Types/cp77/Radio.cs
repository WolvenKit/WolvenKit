using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Radio : InteractiveDevice
	{
		private CArray<RadioStationsMap> _stations;
		private CInt32 _startingStation;
		private CBool _isInteractive;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(93)] 
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

		[Ordinal(94)] 
		[RED("startingStation")] 
		public CInt32 StartingStation
		{
			get
			{
				if (_startingStation == null)
				{
					_startingStation = (CInt32) CR2WTypeManager.Create("Int32", "startingStation", cr2w, this);
				}
				return _startingStation;
			}
			set
			{
				if (_startingStation == value)
				{
					return;
				}
				_startingStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
				{
					_isInteractive = (CBool) CR2WTypeManager.Create("Bool", "isInteractive", cr2w, this);
				}
				return _isInteractive;
			}
			set
			{
				if (_isInteractive == value)
				{
					return;
				}
				_isInteractive = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		public Radio(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
