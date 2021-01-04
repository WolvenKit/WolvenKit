using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAudioEventNodeType : questIAudioNodeType
	{
		[Ordinal(0)]  [RED("ambientUniqueName")] public CName AmbientUniqueName { get; set; }
		[Ordinal(1)]  [RED("dynamicParams")] public CArray<CName> DynamicParams { get; set; }
		[Ordinal(2)]  [RED("emitter")] public CName Emitter { get; set; }
		[Ordinal(3)]  [RED("event")] public audioAudEventStruct Event { get; set; }
		[Ordinal(4)]  [RED("events")] public CArray<audioAudEventStruct> Events { get; set; }
		[Ordinal(5)]  [RED("isMusic")] public CBool IsMusic { get; set; }
		[Ordinal(6)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(7)]  [RED("musicEvents")] public CArray<audioAudEventStruct> MusicEvents { get; set; }
		[Ordinal(8)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(9)]  [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(10)]  [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }

		public questAudioEventNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
