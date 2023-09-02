using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGeneralVoiceGruntSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("variationsCount")] 
		public CUInt32 VariationsCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("painLong")] 
		public CName PainLong
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("agressionShort")] 
		public CName AgressionShort
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("agressionLong")] 
		public CName AgressionLong
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("longFall")] 
		public CName LongFall
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("death")] 
		public CName Death
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("silentDeath")] 
		public CName SilentDeath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("grapple")] 
		public CName Grapple
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("grappleMovement")] 
		public CName GrappleMovement
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("environmentalKnockdown")] 
		public CName EnvironmentalKnockdown
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("bump")] 
		public CName Bump
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("curious")] 
		public CName Curious
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("fear")] 
		public CName Fear
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("jump")] 
		public CName Jump
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("effortLong")] 
		public CName EffortLong
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("deathShort")] 
		public CName DeathShort
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("greet")] 
		public CName Greet
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("laughHard")] 
		public CName LaughHard
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("laughSoft")] 
		public CName LaughSoft
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("phone")] 
		public CName Phone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("braindanceExcited")] 
		public CName BraindanceExcited
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("braindanceFearful")] 
		public CName BraindanceFearful
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("braindanceNeutral")] 
		public CName BraindanceNeutral
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("braindanceSexual")] 
		public CName BraindanceSexual
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("contextualVoiceGruntSettings")] 
		public audioContextualVoiceGruntSettings ContextualVoiceGruntSettings
		{
			get => GetPropertyValue<audioContextualVoiceGruntSettings>();
			set => SetPropertyValue<audioContextualVoiceGruntSettings>(value);
		}

		[Ordinal(25)] 
		[RED("gruntVariations")] 
		public audioVoiceGruntVariations GruntVariations
		{
			get => GetPropertyValue<audioVoiceGruntVariations>();
			set => SetPropertyValue<audioVoiceGruntVariations>(value);
		}

		public audioGeneralVoiceGruntSettings()
		{
			VariationsCount = 1;
			ContextualVoiceGruntSettings = new audioContextualVoiceGruntSettings { PainShort = new audioContextualVoiceGrunt(), Effort = new audioContextualVoiceGrunt() };
			GruntVariations = new audioVoiceGruntVariations { CachedVariations = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
