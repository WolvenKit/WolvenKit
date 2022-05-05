using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsSetParameterOnEmitter : gameaudioeventsEmitterEvent
	{
		[Ordinal(1)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("paramValue")] 
		public CFloat ParamValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameaudioeventsSetParameterOnEmitter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
