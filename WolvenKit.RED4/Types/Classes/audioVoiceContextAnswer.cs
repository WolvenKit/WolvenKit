using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceContextAnswer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("answerContext")] 
		public CName AnswerContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVoiceContextAnswer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
