using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoManagerSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("forceApucVoiceTagSelectionProbability")] public CFloat ForceApucVoiceTagSelectionProbability { get; set; }
		[Ordinal(1)]  [RED("genericAlertedVOContexts")] public CArray<CName> GenericAlertedVOContexts { get; set; }
		[Ordinal(2)]  [RED("genericCombatLosingVOContexts")] public CArray<CName> GenericCombatLosingVOContexts { get; set; }
		[Ordinal(3)]  [RED("genericCombatSingleEnemyVOContexts")] public CArray<CName> GenericCombatSingleEnemyVOContexts { get; set; }
		[Ordinal(4)]  [RED("genericCombatVOContexts")] public CArray<CName> GenericCombatVOContexts { get; set; }
		[Ordinal(5)]  [RED("genericFearVOContexts")] public CArray<CName> GenericFearVOContexts { get; set; }
		[Ordinal(6)]  [RED("genericRelaxedVOContexts")] public CArray<CName> GenericRelaxedVOContexts { get; set; }
		[Ordinal(7)]  [RED("maxVoHearableHorizontalDistance")] public CFloat MaxVoHearableHorizontalDistance { get; set; }
		[Ordinal(8)]  [RED("maxVoHearableVerticalDistance")] public CFloat MaxVoHearableVerticalDistance { get; set; }
		[Ordinal(9)]  [RED("maxVoVisibleDistance")] public CFloat MaxVoVisibleDistance { get; set; }
		[Ordinal(10)]  [RED("minNoVOTimeNeededToTryPlayingGenericVO")] public CFloat MinNoVOTimeNeededToTryPlayingGenericVO { get; set; }
		[Ordinal(11)]  [RED("specificVoicesetVoVariationMinRepeatTime")] public CFloat SpecificVoicesetVoVariationMinRepeatTime { get; set; }
		[Ordinal(12)]  [RED("thresholdDbForCombatDialog")] public CFloat ThresholdDbForCombatDialog { get; set; }
		[Ordinal(13)]  [RED("triggerIdleChattersTime")] public CFloat TriggerIdleChattersTime { get; set; }
		[Ordinal(14)]  [RED("triggerVoEventBufferTime")] public CFloat TriggerVoEventBufferTime { get; set; }
		[Ordinal(15)]  [RED("voiceTagSelectionRandomTimeOffset")] public CFloat VoiceTagSelectionRandomTimeOffset { get; set; }

		public audioCombatVoManagerSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
