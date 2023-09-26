using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuButtonHoverOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("buttonId")] 
		public CInt32 ButtonId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public MenuButtonHoverOverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
