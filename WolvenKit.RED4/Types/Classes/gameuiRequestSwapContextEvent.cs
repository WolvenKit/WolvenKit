using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRequestSwapContextEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("oldContext")] 
		public CEnum<UIGameContext> OldContext
		{
			get => GetPropertyValue<CEnum<UIGameContext>>();
			set => SetPropertyValue<CEnum<UIGameContext>>(value);
		}

		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<UIGameContext> NewContext
		{
			get => GetPropertyValue<CEnum<UIGameContext>>();
			set => SetPropertyValue<CEnum<UIGameContext>>(value);
		}

		public gameuiRequestSwapContextEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
