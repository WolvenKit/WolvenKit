using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoManagerSettings : audioAudioMetadata
	{
		private CFloat _thresholdDbForCombatDialog;
		private CFloat _maxVoHearableHorizontalDistance;
		private CFloat _maxVoHearableVerticalDistance;
		private CFloat _maxVoVisibleDistance;
		private CFloat _triggerVoEventBufferTime;
		private CFloat _triggerIdleChattersTime;
		private CFloat _minNoVOTimeNeededToTryPlayingGenericVO;
		private CFloat _specificVoicesetVoVariationMinRepeatTime;
		private CFloat _forceApucVoiceTagSelectionProbability;
		private CFloat _voiceTagSelectionRandomTimeOffset;
		private CArray<CName> _genericRelaxedVOContexts;
		private CArray<CName> _genericFearVOContexts;
		private CArray<CName> _genericAlertedVOContexts;
		private CArray<CName> _genericCombatVOContexts;
		private CArray<CName> _genericCombatLosingVOContexts;
		private CArray<CName> _genericCombatSingleEnemyVOContexts;

		[Ordinal(1)] 
		[RED("thresholdDbForCombatDialog")] 
		public CFloat ThresholdDbForCombatDialog
		{
			get => GetProperty(ref _thresholdDbForCombatDialog);
			set => SetProperty(ref _thresholdDbForCombatDialog, value);
		}

		[Ordinal(2)] 
		[RED("maxVoHearableHorizontalDistance")] 
		public CFloat MaxVoHearableHorizontalDistance
		{
			get => GetProperty(ref _maxVoHearableHorizontalDistance);
			set => SetProperty(ref _maxVoHearableHorizontalDistance, value);
		}

		[Ordinal(3)] 
		[RED("maxVoHearableVerticalDistance")] 
		public CFloat MaxVoHearableVerticalDistance
		{
			get => GetProperty(ref _maxVoHearableVerticalDistance);
			set => SetProperty(ref _maxVoHearableVerticalDistance, value);
		}

		[Ordinal(4)] 
		[RED("maxVoVisibleDistance")] 
		public CFloat MaxVoVisibleDistance
		{
			get => GetProperty(ref _maxVoVisibleDistance);
			set => SetProperty(ref _maxVoVisibleDistance, value);
		}

		[Ordinal(5)] 
		[RED("triggerVoEventBufferTime")] 
		public CFloat TriggerVoEventBufferTime
		{
			get => GetProperty(ref _triggerVoEventBufferTime);
			set => SetProperty(ref _triggerVoEventBufferTime, value);
		}

		[Ordinal(6)] 
		[RED("triggerIdleChattersTime")] 
		public CFloat TriggerIdleChattersTime
		{
			get => GetProperty(ref _triggerIdleChattersTime);
			set => SetProperty(ref _triggerIdleChattersTime, value);
		}

		[Ordinal(7)] 
		[RED("minNoVOTimeNeededToTryPlayingGenericVO")] 
		public CFloat MinNoVOTimeNeededToTryPlayingGenericVO
		{
			get => GetProperty(ref _minNoVOTimeNeededToTryPlayingGenericVO);
			set => SetProperty(ref _minNoVOTimeNeededToTryPlayingGenericVO, value);
		}

		[Ordinal(8)] 
		[RED("specificVoicesetVoVariationMinRepeatTime")] 
		public CFloat SpecificVoicesetVoVariationMinRepeatTime
		{
			get => GetProperty(ref _specificVoicesetVoVariationMinRepeatTime);
			set => SetProperty(ref _specificVoicesetVoVariationMinRepeatTime, value);
		}

		[Ordinal(9)] 
		[RED("forceApucVoiceTagSelectionProbability")] 
		public CFloat ForceApucVoiceTagSelectionProbability
		{
			get => GetProperty(ref _forceApucVoiceTagSelectionProbability);
			set => SetProperty(ref _forceApucVoiceTagSelectionProbability, value);
		}

		[Ordinal(10)] 
		[RED("voiceTagSelectionRandomTimeOffset")] 
		public CFloat VoiceTagSelectionRandomTimeOffset
		{
			get => GetProperty(ref _voiceTagSelectionRandomTimeOffset);
			set => SetProperty(ref _voiceTagSelectionRandomTimeOffset, value);
		}

		[Ordinal(11)] 
		[RED("genericRelaxedVOContexts")] 
		public CArray<CName> GenericRelaxedVOContexts
		{
			get => GetProperty(ref _genericRelaxedVOContexts);
			set => SetProperty(ref _genericRelaxedVOContexts, value);
		}

		[Ordinal(12)] 
		[RED("genericFearVOContexts")] 
		public CArray<CName> GenericFearVOContexts
		{
			get => GetProperty(ref _genericFearVOContexts);
			set => SetProperty(ref _genericFearVOContexts, value);
		}

		[Ordinal(13)] 
		[RED("genericAlertedVOContexts")] 
		public CArray<CName> GenericAlertedVOContexts
		{
			get => GetProperty(ref _genericAlertedVOContexts);
			set => SetProperty(ref _genericAlertedVOContexts, value);
		}

		[Ordinal(14)] 
		[RED("genericCombatVOContexts")] 
		public CArray<CName> GenericCombatVOContexts
		{
			get => GetProperty(ref _genericCombatVOContexts);
			set => SetProperty(ref _genericCombatVOContexts, value);
		}

		[Ordinal(15)] 
		[RED("genericCombatLosingVOContexts")] 
		public CArray<CName> GenericCombatLosingVOContexts
		{
			get => GetProperty(ref _genericCombatLosingVOContexts);
			set => SetProperty(ref _genericCombatLosingVOContexts, value);
		}

		[Ordinal(16)] 
		[RED("genericCombatSingleEnemyVOContexts")] 
		public CArray<CName> GenericCombatSingleEnemyVOContexts
		{
			get => GetProperty(ref _genericCombatSingleEnemyVOContexts);
			set => SetProperty(ref _genericCombatSingleEnemyVOContexts, value);
		}

		public audioCombatVoManagerSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
