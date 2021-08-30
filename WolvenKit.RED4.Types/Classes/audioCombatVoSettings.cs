using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioCombatVoSettings : audioAudioMetadata
	{
		private CName _answerGroupName;
		private CBool _isPlayerAlly;
		private CName _contexts;
		private CName _voTriggerVariations;
		private audioGeneralVoiceGruntSettings _generalGruntSettings;
		private audioVoiceTriggerLimits _voTriggerLimits;
		private CName _overridingVoTriggerLimits;
		private audioVoiceTriggerLimits _barkTriggerLimits;
		private audioVoiceTriggerLimits _gruntTriggerLimits;
		private CFloat _minDamageToInterruptVoWithPainShort;
		private CFloat _minDamageToInterruptVoWithPainLong;

		[Ordinal(1)] 
		[RED("answerGroupName")] 
		public CName AnswerGroupName
		{
			get => GetProperty(ref _answerGroupName);
			set => SetProperty(ref _answerGroupName, value);
		}

		[Ordinal(2)] 
		[RED("isPlayerAlly")] 
		public CBool IsPlayerAlly
		{
			get => GetProperty(ref _isPlayerAlly);
			set => SetProperty(ref _isPlayerAlly, value);
		}

		[Ordinal(3)] 
		[RED("contexts")] 
		public CName Contexts
		{
			get => GetProperty(ref _contexts);
			set => SetProperty(ref _contexts, value);
		}

		[Ordinal(4)] 
		[RED("voTriggerVariations")] 
		public CName VoTriggerVariations
		{
			get => GetProperty(ref _voTriggerVariations);
			set => SetProperty(ref _voTriggerVariations, value);
		}

		[Ordinal(5)] 
		[RED("generalGruntSettings")] 
		public audioGeneralVoiceGruntSettings GeneralGruntSettings
		{
			get => GetProperty(ref _generalGruntSettings);
			set => SetProperty(ref _generalGruntSettings, value);
		}

		[Ordinal(6)] 
		[RED("voTriggerLimits")] 
		public audioVoiceTriggerLimits VoTriggerLimits
		{
			get => GetProperty(ref _voTriggerLimits);
			set => SetProperty(ref _voTriggerLimits, value);
		}

		[Ordinal(7)] 
		[RED("overridingVoTriggerLimits")] 
		public CName OverridingVoTriggerLimits
		{
			get => GetProperty(ref _overridingVoTriggerLimits);
			set => SetProperty(ref _overridingVoTriggerLimits, value);
		}

		[Ordinal(8)] 
		[RED("barkTriggerLimits")] 
		public audioVoiceTriggerLimits BarkTriggerLimits
		{
			get => GetProperty(ref _barkTriggerLimits);
			set => SetProperty(ref _barkTriggerLimits, value);
		}

		[Ordinal(9)] 
		[RED("gruntTriggerLimits")] 
		public audioVoiceTriggerLimits GruntTriggerLimits
		{
			get => GetProperty(ref _gruntTriggerLimits);
			set => SetProperty(ref _gruntTriggerLimits, value);
		}

		[Ordinal(10)] 
		[RED("minDamageToInterruptVoWithPainShort")] 
		public CFloat MinDamageToInterruptVoWithPainShort
		{
			get => GetProperty(ref _minDamageToInterruptVoWithPainShort);
			set => SetProperty(ref _minDamageToInterruptVoWithPainShort, value);
		}

		[Ordinal(11)] 
		[RED("minDamageToInterruptVoWithPainLong")] 
		public CFloat MinDamageToInterruptVoWithPainLong
		{
			get => GetProperty(ref _minDamageToInterruptVoWithPainLong);
			set => SetProperty(ref _minDamageToInterruptVoWithPainLong, value);
		}

		public audioCombatVoSettings()
		{
			_minDamageToInterruptVoWithPainShort = 9.000000F;
			_minDamageToInterruptVoWithPainLong = 30.000000F;
		}
	}
}
