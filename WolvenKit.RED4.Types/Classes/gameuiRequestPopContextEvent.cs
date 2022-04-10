using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRequestPopContextEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("context")] 
		public CEnum<UIGameContext> Context
		{
			get => GetPropertyValue<CEnum<UIGameContext>>();
			set => SetPropertyValue<CEnum<UIGameContext>>(value);
		}

		public gameuiRequestPopContextEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
