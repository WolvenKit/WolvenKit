using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoManagerSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("thresholdDbForCombatDialog")] public CFloat ThresholdDbForCombatDialog { get; set; }
		[Ordinal(2)] [RED("maxVoHearableHorizontalDistance")] public CFloat MaxVoHearableHorizontalDistance { get; set; }
		[Ordinal(3)] [RED("maxVoHearableVerticalDistance")] public CFloat MaxVoHearableVerticalDistance { get; set; }
		[Ordinal(4)] [RED("maxVoVisibleDistance")] public CFloat MaxVoVisibleDistance { get; set; }
		[Ordinal(5)] [RED("triggerVoEventBufferTime")] public CFloat TriggerVoEventBufferTime { get; set; }
		[Ordinal(6)] [RED("triggerIdleChattersTime")] public CFloat TriggerIdleChattersTime { get; set; }
		[Ordinal(7)] [RED("minNoVOTimeNeededToTryPlayingGenericVO")] public CFloat MinNoVOTimeNeededToTryPlayingGenericVO { get; set; }
		[Ordinal(8)] [RED("specificVoicesetVoVariationMinRepeatTime")] public CFloat SpecificVoicesetVoVariationMinRepeatTime { get; set; }
		[Ordinal(9)] [RED("forceApucVoiceTagSelectionProbability")] public CFloat ForceApucVoiceTagSelectionProbability { get; set; }
		[Ordinal(10)] [RED("voiceTagSelectionRandomTimeOffset")] public CFloat VoiceTagSelectionRandomTimeOffset { get; set; }
		[Ordinal(11)] [RED("genericRelaxedVOContexts")] public CArray<CName> GenericRelaxedVOContexts { get; set; }
		[Ordinal(12)] [RED("genericFearVOContexts")] public CArray<CName> GenericFearVOContexts { get; set; }
		[Ordinal(13)] [RED("genericAlertedVOContexts")] public CArray<CName> GenericAlertedVOContexts { get; set; }
		[Ordinal(14)] [RED("genericCombatVOContexts")] public CArray<CName> GenericCombatVOContexts { get; set; }
		[Ordinal(15)] [RED("genericCombatLosingVOContexts")] public CArray<CName> GenericCombatLosingVOContexts { get; set; }
		[Ordinal(16)] [RED("genericCombatSingleEnemyVOContexts")] public CArray<CName> GenericCombatSingleEnemyVOContexts { get; set; }

		public audioCombatVoManagerSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
