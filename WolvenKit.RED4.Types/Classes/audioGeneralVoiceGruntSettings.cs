using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGeneralVoiceGruntSettings : RedBaseClass
	{
		private CUInt32 _variationsCount;
		private CName _painLong;
		private CName _agressionShort;
		private CName _agressionLong;
		private CName _longFall;
		private CName _death;
		private CName _silentDeath;
		private CName _grapple;
		private CName _grappleMovement;
		private CName _environmentalKnockdown;
		private CName _bump;
		private CName _curious;
		private CName _fear;
		private CName _jump;
		private CName _effortLong;
		private CName _deathShort;
		private CName _greet;
		private CName _laughHard;
		private CName _laughSoft;
		private CName _phone;
		private CName _braindanceExcited;
		private CName _braindanceFearful;
		private CName _braindanceNeutral;
		private CName _braindanceSexual;
		private audioContextualVoiceGruntSettings _contextualVoiceGruntSettings;
		private audioVoiceGruntVariations _gruntVariations;

		[Ordinal(0)] 
		[RED("variationsCount")] 
		public CUInt32 VariationsCount
		{
			get => GetProperty(ref _variationsCount);
			set => SetProperty(ref _variationsCount, value);
		}

		[Ordinal(1)] 
		[RED("painLong")] 
		public CName PainLong
		{
			get => GetProperty(ref _painLong);
			set => SetProperty(ref _painLong, value);
		}

		[Ordinal(2)] 
		[RED("agressionShort")] 
		public CName AgressionShort
		{
			get => GetProperty(ref _agressionShort);
			set => SetProperty(ref _agressionShort, value);
		}

		[Ordinal(3)] 
		[RED("agressionLong")] 
		public CName AgressionLong
		{
			get => GetProperty(ref _agressionLong);
			set => SetProperty(ref _agressionLong, value);
		}

		[Ordinal(4)] 
		[RED("longFall")] 
		public CName LongFall
		{
			get => GetProperty(ref _longFall);
			set => SetProperty(ref _longFall, value);
		}

		[Ordinal(5)] 
		[RED("death")] 
		public CName Death
		{
			get => GetProperty(ref _death);
			set => SetProperty(ref _death, value);
		}

		[Ordinal(6)] 
		[RED("silentDeath")] 
		public CName SilentDeath
		{
			get => GetProperty(ref _silentDeath);
			set => SetProperty(ref _silentDeath, value);
		}

		[Ordinal(7)] 
		[RED("grapple")] 
		public CName Grapple
		{
			get => GetProperty(ref _grapple);
			set => SetProperty(ref _grapple, value);
		}

		[Ordinal(8)] 
		[RED("grappleMovement")] 
		public CName GrappleMovement
		{
			get => GetProperty(ref _grappleMovement);
			set => SetProperty(ref _grappleMovement, value);
		}

		[Ordinal(9)] 
		[RED("environmentalKnockdown")] 
		public CName EnvironmentalKnockdown
		{
			get => GetProperty(ref _environmentalKnockdown);
			set => SetProperty(ref _environmentalKnockdown, value);
		}

		[Ordinal(10)] 
		[RED("bump")] 
		public CName Bump
		{
			get => GetProperty(ref _bump);
			set => SetProperty(ref _bump, value);
		}

		[Ordinal(11)] 
		[RED("curious")] 
		public CName Curious
		{
			get => GetProperty(ref _curious);
			set => SetProperty(ref _curious, value);
		}

		[Ordinal(12)] 
		[RED("fear")] 
		public CName Fear
		{
			get => GetProperty(ref _fear);
			set => SetProperty(ref _fear, value);
		}

		[Ordinal(13)] 
		[RED("jump")] 
		public CName Jump
		{
			get => GetProperty(ref _jump);
			set => SetProperty(ref _jump, value);
		}

		[Ordinal(14)] 
		[RED("effortLong")] 
		public CName EffortLong
		{
			get => GetProperty(ref _effortLong);
			set => SetProperty(ref _effortLong, value);
		}

		[Ordinal(15)] 
		[RED("deathShort")] 
		public CName DeathShort
		{
			get => GetProperty(ref _deathShort);
			set => SetProperty(ref _deathShort, value);
		}

		[Ordinal(16)] 
		[RED("greet")] 
		public CName Greet
		{
			get => GetProperty(ref _greet);
			set => SetProperty(ref _greet, value);
		}

		[Ordinal(17)] 
		[RED("laughHard")] 
		public CName LaughHard
		{
			get => GetProperty(ref _laughHard);
			set => SetProperty(ref _laughHard, value);
		}

		[Ordinal(18)] 
		[RED("laughSoft")] 
		public CName LaughSoft
		{
			get => GetProperty(ref _laughSoft);
			set => SetProperty(ref _laughSoft, value);
		}

		[Ordinal(19)] 
		[RED("phone")] 
		public CName Phone
		{
			get => GetProperty(ref _phone);
			set => SetProperty(ref _phone, value);
		}

		[Ordinal(20)] 
		[RED("braindanceExcited")] 
		public CName BraindanceExcited
		{
			get => GetProperty(ref _braindanceExcited);
			set => SetProperty(ref _braindanceExcited, value);
		}

		[Ordinal(21)] 
		[RED("braindanceFearful")] 
		public CName BraindanceFearful
		{
			get => GetProperty(ref _braindanceFearful);
			set => SetProperty(ref _braindanceFearful, value);
		}

		[Ordinal(22)] 
		[RED("braindanceNeutral")] 
		public CName BraindanceNeutral
		{
			get => GetProperty(ref _braindanceNeutral);
			set => SetProperty(ref _braindanceNeutral, value);
		}

		[Ordinal(23)] 
		[RED("braindanceSexual")] 
		public CName BraindanceSexual
		{
			get => GetProperty(ref _braindanceSexual);
			set => SetProperty(ref _braindanceSexual, value);
		}

		[Ordinal(24)] 
		[RED("contextualVoiceGruntSettings")] 
		public audioContextualVoiceGruntSettings ContextualVoiceGruntSettings
		{
			get => GetProperty(ref _contextualVoiceGruntSettings);
			set => SetProperty(ref _contextualVoiceGruntSettings, value);
		}

		[Ordinal(25)] 
		[RED("gruntVariations")] 
		public audioVoiceGruntVariations GruntVariations
		{
			get => GetProperty(ref _gruntVariations);
			set => SetProperty(ref _gruntVariations, value);
		}

		public audioGeneralVoiceGruntSettings()
		{
			_variationsCount = 1;
		}
	}
}
