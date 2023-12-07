using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyStaminaHandlerEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("opSymbol")] 
		public CName OpSymbol
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ModifyStaminaHandlerEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
