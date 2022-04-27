using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioCombatVoSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("answerGroupName")] 
		public CName AnswerGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("isPlayerAlly")] 
		public CBool IsPlayerAlly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("contexts")] 
		public CName Contexts
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("voTriggerVariations")] 
		public CName VoTriggerVariations
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("generalGruntSettings")] 
		public audioGeneralVoiceGruntSettings GeneralGruntSettings
		{
			get => GetPropertyValue<audioGeneralVoiceGruntSettings>();
			set => SetPropertyValue<audioGeneralVoiceGruntSettings>(value);
		}

		[Ordinal(6)] 
		[RED("voTriggerLimits")] 
		public audioVoiceTriggerLimits VoTriggerLimits
		{
			get => GetPropertyValue<audioVoiceTriggerLimits>();
			set => SetPropertyValue<audioVoiceTriggerLimits>(value);
		}

		[Ordinal(7)] 
		[RED("overridingVoTriggerLimits")] 
		public CName OverridingVoTriggerLimits
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("barkTriggerLimits")] 
		public audioVoiceTriggerLimits BarkTriggerLimits
		{
			get => GetPropertyValue<audioVoiceTriggerLimits>();
			set => SetPropertyValue<audioVoiceTriggerLimits>(value);
		}

		[Ordinal(9)] 
		[RED("gruntTriggerLimits")] 
		public audioVoiceTriggerLimits GruntTriggerLimits
		{
			get => GetPropertyValue<audioVoiceTriggerLimits>();
			set => SetPropertyValue<audioVoiceTriggerLimits>(value);
		}

		[Ordinal(10)] 
		[RED("minDamageToInterruptVoWithPainShort")] 
		public CFloat MinDamageToInterruptVoWithPainShort
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("minDamageToInterruptVoWithPainLong")] 
		public CFloat MinDamageToInterruptVoWithPainLong
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioCombatVoSettings()
		{
			GeneralGruntSettings = new() { VariationsCount = 1, ContextualVoiceGruntSettings = new() { PainShort = new(), Effort = new() }, GruntVariations = new() { CachedVariations = new() } };
			VoTriggerLimits = new() { Probability = 1.000000F };
			BarkTriggerLimits = new() { Probability = 1.000000F };
			GruntTriggerLimits = new() { Probability = 1.000000F };
			MinDamageToInterruptVoWithPainShort = 9.000000F;
			MinDamageToInterruptVoWithPainLong = 30.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
