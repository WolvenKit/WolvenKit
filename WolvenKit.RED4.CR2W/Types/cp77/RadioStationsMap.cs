using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioStationsMap : CVariable
	{
		[Ordinal(0)] [RED("soundEvent")] public CName SoundEvent { get; set; }
		[Ordinal(1)] [RED("channelName")] public CString ChannelName { get; set; }
		[Ordinal(2)] [RED("stationID")] public CEnum<ERadioStationList> StationID { get; set; }

		public RadioStationsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
