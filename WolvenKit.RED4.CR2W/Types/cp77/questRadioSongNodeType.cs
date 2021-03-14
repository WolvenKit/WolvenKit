using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadioSongNodeType : questIAudioNodeType
	{
		private CArray<audioRadioStationSongEventStruct> _radioStationEvents;

		[Ordinal(0)] 
		[RED("radioStationEvents")] 
		public CArray<audioRadioStationSongEventStruct> RadioStationEvents
		{
			get
			{
				if (_radioStationEvents == null)
				{
					_radioStationEvents = (CArray<audioRadioStationSongEventStruct>) CR2WTypeManager.Create("array:audioRadioStationSongEventStruct", "radioStationEvents", cr2w, this);
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

		public questRadioSongNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
