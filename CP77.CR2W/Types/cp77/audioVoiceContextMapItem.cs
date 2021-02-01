using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextMapItem : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("answer")] public audioVoiceContextAnswer Answer { get; set; }
		[Ordinal(1)]  [RED("bark")] public CEnum<audioVoBarkType> Bark { get; set; }
		[Ordinal(2)]  [RED("grunt")] public CEnum<audioVoGruntType> Grunt { get; set; }
		[Ordinal(3)]  [RED("gruntInterruptMode")] public CEnum<audioVoGruntInterruptMode> GruntInterruptMode { get; set; }
		[Ordinal(4)]  [RED("overridingVoContext")] public CEnum<locVoiceoverContext> OverridingVoContext { get; set; }
		[Ordinal(5)]  [RED("voTrigger")] public CName VoTrigger { get; set; }

		public audioVoiceContextMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
