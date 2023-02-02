using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceContextMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("voTrigger")] 
		public CName VoTrigger
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("bark")] 
		public CEnum<audioVoBarkType> Bark
		{
			get => GetPropertyValue<CEnum<audioVoBarkType>>();
			set => SetPropertyValue<CEnum<audioVoBarkType>>(value);
		}

		[Ordinal(3)] 
		[RED("grunt")] 
		public CEnum<audioVoGruntType> Grunt
		{
			get => GetPropertyValue<CEnum<audioVoGruntType>>();
			set => SetPropertyValue<CEnum<audioVoGruntType>>(value);
		}

		[Ordinal(4)] 
		[RED("answer")] 
		public audioVoiceContextAnswer Answer
		{
			get => GetPropertyValue<audioVoiceContextAnswer>();
			set => SetPropertyValue<audioVoiceContextAnswer>(value);
		}

		[Ordinal(5)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		[Ordinal(6)] 
		[RED("gruntInterruptMode")] 
		public CEnum<audioVoGruntInterruptMode> GruntInterruptMode
		{
			get => GetPropertyValue<CEnum<audioVoGruntInterruptMode>>();
			set => SetPropertyValue<CEnum<audioVoGruntInterruptMode>>(value);
		}

		public audioVoiceContextMapItem()
		{
			Grunt = Enums.audioVoGruntType.None;
			Answer = new();
			OverridingVoContext = Enums.locVoiceoverContext.Default_Vo_Context;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
