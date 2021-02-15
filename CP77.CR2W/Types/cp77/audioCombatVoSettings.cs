using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("answerGroupName")] public CName AnswerGroupName { get; set; }
		[Ordinal(2)] [RED("isPlayerAlly")] public CBool IsPlayerAlly { get; set; }
		[Ordinal(3)] [RED("contexts")] public CName Contexts { get; set; }
		[Ordinal(4)] [RED("voTriggerVariations")] public CName VoTriggerVariations { get; set; }
		[Ordinal(5)] [RED("generalGruntSettings")] public audioGeneralVoiceGruntSettings GeneralGruntSettings { get; set; }
		[Ordinal(6)] [RED("voTriggerLimits")] public audioVoiceTriggerLimits VoTriggerLimits { get; set; }
		[Ordinal(7)] [RED("overridingVoTriggerLimits")] public CName OverridingVoTriggerLimits { get; set; }
		[Ordinal(8)] [RED("barkTriggerLimits")] public audioVoiceTriggerLimits BarkTriggerLimits { get; set; }
		[Ordinal(9)] [RED("gruntTriggerLimits")] public audioVoiceTriggerLimits GruntTriggerLimits { get; set; }
		[Ordinal(10)] [RED("minDamageToInterruptVoWithPainShort")] public CFloat MinDamageToInterruptVoWithPainShort { get; set; }
		[Ordinal(11)] [RED("minDamageToInterruptVoWithPainLong")] public CFloat MinDamageToInterruptVoWithPainLong { get; set; }

		public audioCombatVoSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
