using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHoldControllerActionData : inkUserData
	{
		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkHoldControllerActionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
