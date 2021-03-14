using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadioAnnouncementNodeType : questIAudioNodeType
	{
		private CArray<questRadioStationAnnouncementEventStruct> _radioStationEvents;

		[Ordinal(0)] 
		[RED("radioStationEvents")] 
		public CArray<questRadioStationAnnouncementEventStruct> RadioStationEvents
		{
			get
			{
				if (_radioStationEvents == null)
				{
					_radioStationEvents = (CArray<questRadioStationAnnouncementEventStruct>) CR2WTypeManager.Create("array:questRadioStationAnnouncementEventStruct", "radioStationEvents", cr2w, this);
				}
				return _radioStationEvents;
			}
			set
			{
				if (_radioStationEvents == value)
				{
					return;
				}
				_radioStationEvents = value;
				PropertySet(this);
			}
		}

		public questRadioAnnouncementNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
