using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystemAddAvailableCar : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("carFact")] 
		public CName CarFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public UIScriptableSystemAddAvailableCar()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
