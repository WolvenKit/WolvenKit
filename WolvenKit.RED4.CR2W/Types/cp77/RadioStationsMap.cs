using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioStationsMap : CVariable
	{
		private CName _soundEvent;
		private CString _channelName;
		private CEnum<ERadioStationList> _stationID;

		[Ordinal(0)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get
			{
				if (_soundEvent == null)
				{
					_soundEvent = (CName) CR2WTypeManager.Create("CName", "soundEvent", cr2w, this);
				}
				return _soundEvent;
			}
			set
			{
				if (_soundEvent == value)
				{
					return;
				}
				_soundEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("channelName")] 
		public CString ChannelName
		{
			get
			{
				if (_channelName == null)
				{
					_channelName = (CString) CR2WTypeManager.Create("String", "channelName", cr2w, this);
				}
				return _channelName;
			}
			set
			{
				if (_channelName == value)
				{
					return;
				}
				_channelName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stationID")] 
		public CEnum<ERadioStationList> StationID
		{
			get
			{
				if (_stationID == null)
				{
					_stationID = (CEnum<ERadioStationList>) CR2WTypeManager.Create("ERadioStationList", "stationID", cr2w, this);
				}
				return _stationID;
			}
			set
			{
				if (_stationID == value)
				{
					return;
				}
				_stationID = value;
				PropertySet(this);
			}
		}

		public RadioStationsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
