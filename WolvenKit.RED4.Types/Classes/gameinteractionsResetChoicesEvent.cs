using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsResetChoicesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("layer")] 
		public CName Layer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameinteractionsResetChoicesEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
