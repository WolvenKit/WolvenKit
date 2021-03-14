using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationMetadataMap : audioAudioMetadata
	{
		private CArray<CName> _radioStations;
		private CName _switchStationEvent;
		private CName _turnOnRadioEvent;
		private CName _turnOffRadioEvent;
		private audioRadioStationJingleMetadata _defaultBackgroundJingle;

		[Ordinal(1)] 
		[RED("radioStations")] 
		public CArray<CName> RadioStations
		{
			get
			{
				if (_radioStations == null)
				{
					_radioStations = (CArray<CName>) CR2WTypeManager.Create("array:CName", "radioStations", cr2w, this);
				}
				return _radioStations;
			}
			set
			{
				if (_radioStations == value)
				{
					return;
				}
				_radioStations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("switchStationEvent")] 
		public CName SwitchStationEvent
		{
			get
			{
				if (_switchStationEvent == null)
				{
					_switchStationEvent = (CName) CR2WTypeManager.Create("CName", "switchStationEvent", cr2w, this);
				}
				return _switchStationEvent;
			}
			set
			{
				if (_switchStationEvent == value)
				{
					return;
				}
				_switchStationEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("turnOnRadioEvent")] 
		public CName TurnOnRadioEvent
		{
			get
			{
				if (_turnOnRadioEvent == null)
				{
					_turnOnRadioEvent = (CName) CR2WTypeManager.Create("CName", "turnOnRadioEvent", cr2w, this);
				}
				return _turnOnRadioEvent;
			}
			set
			{
				if (_turnOnRadioEvent == value)
				{
					return;
				}
				_turnOnRadioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("turnOffRadioEvent")] 
		public CName TurnOffRadioEvent
		{
			get
			{
				if (_turnOffRadioEvent == null)
				{
					_turnOffRadioEvent = (CName) CR2WTypeManager.Create("CName", "turnOffRadioEvent", cr2w, this);
				}
				return _turnOffRadioEvent;
			}
			set
			{
				if (_turnOffRadioEvent == value)
				{
					return;
				}
				_turnOffRadioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("defaultBackgroundJingle")] 
		public audioRadioStationJingleMetadata DefaultBackgroundJingle
		{
			get
			{
				if (_defaultBackgroundJingle == null)
				{
					_defaultBackgroundJingle = (audioRadioStationJingleMetadata) CR2WTypeManager.Create("audioRadioStationJingleMetadata", "defaultBackgroundJingle", cr2w, this);
				}
				return _defaultBackgroundJingle;
			}
			set
			{
				if (_defaultBackgroundJingle == value)
				{
					return;
				}
				_defaultBackgroundJingle = value;
				PropertySet(this);
			}
		}

		public audioRadioStationMetadataMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
