using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkKeyBindingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("keyName")] 
		public CName KeyName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkKeyBindingEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
