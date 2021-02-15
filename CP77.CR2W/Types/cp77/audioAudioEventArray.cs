using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioEventArray : ISerializable
	{
		[Ordinal(0)] [RED("isSortedByRedHash")] public CBool IsSortedByRedHash { get; set; }
		[Ordinal(1)] [RED("events")] public CArray<audioAudioEventMetadataArrayElement> Events { get; set; }
		[Ordinal(2)] [RED("switchGroup")] public CArray<audioAudioEventMetadataArrayElement> SwitchGroup { get; set; }
		[Ordinal(3)] [RED("switch")] public CArray<audioAudioEventMetadataArrayElement> Switch { get; set; }
		[Ordinal(4)] [RED("stateGroup")] public CArray<audioAudioEventMetadataArrayElement> StateGroup { get; set; }
		[Ordinal(5)] [RED("state")] public CArray<audioAudioEventMetadataArrayElement> State { get; set; }
		[Ordinal(6)] [RED("gameParameter")] public CArray<audioAudioEventMetadataArrayElement> GameParameter { get; set; }
		[Ordinal(7)] [RED("bus")] public CArray<audioAudioEventMetadataArrayElement> Bus { get; set; }

		public audioAudioEventArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
