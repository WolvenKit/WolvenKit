using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTriggerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("variationIndex")] 
		public CUInt32 VariationIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("variationNumber")] 
		public CUInt32 VariationNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		public audioVoiceTriggerData()
		{
			OverridingVoContext = Enums.locVoiceoverContext.Default_Vo_Context;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
