using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeEvent : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("event")] 
		public CName Event
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CArray<audioAudSimpleParameter> Params
		{
			get => GetPropertyValue<CArray<audioAudSimpleParameter>>();
			set => SetPropertyValue<CArray<audioAudSimpleParameter>>(value);
		}

		public audioMeleeEvent()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
