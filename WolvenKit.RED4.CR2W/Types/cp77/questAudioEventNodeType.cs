using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioEventNodeType : questIAudioNodeType
	{
		[Ordinal(0)] [RED("events")] public CArray<audioAudEventStruct> Events { get; set; }
		[Ordinal(1)] [RED("musicEvents")] public CArray<audioAudEventStruct> MusicEvents { get; set; }
		[Ordinal(2)] [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }
		[Ordinal(3)] [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(4)] [RED("dynamicParams")] public CArray<CName> DynamicParams { get; set; }
		[Ordinal(5)] [RED("event")] public audioAudEventStruct Event { get; set; }
		[Ordinal(6)] [RED("ambientUniqueName")] public CName AmbientUniqueName { get; set; }
		[Ordinal(7)] [RED("emitter")] public CName Emitter { get; set; }
		[Ordinal(8)] [RED("isMusic")] public CBool IsMusic { get; set; }
		[Ordinal(9)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(10)] [RED("isPlayer")] public CBool IsPlayer { get; set; }

		public questAudioEventNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
