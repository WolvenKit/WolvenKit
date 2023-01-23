using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsEmitterEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsEmitterEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
