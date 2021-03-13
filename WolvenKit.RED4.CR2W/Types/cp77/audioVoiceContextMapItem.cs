using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextMapItem : audioAudioMetadata
	{
		[Ordinal(1)] [RED("voTrigger")] public CName VoTrigger { get; set; }
		[Ordinal(2)] [RED("bark")] public CEnum<audioVoBarkType> Bark { get; set; }
		[Ordinal(3)] [RED("grunt")] public CEnum<audioVoGruntType> Grunt { get; set; }
		[Ordinal(4)] [RED("answer")] public audioVoiceContextAnswer Answer { get; set; }
		[Ordinal(5)] [RED("overridingVoContext")] public CEnum<locVoiceoverContext> OverridingVoContext { get; set; }
		[Ordinal(6)] [RED("gruntInterruptMode")] public CEnum<audioVoGruntInterruptMode> GruntInterruptMode { get; set; }

		public audioVoiceContextMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
