using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiCharacterCustomizationHeadPartsController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(4)] 
		[RED("groupName")] 
		public CName GroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationHeadPartsController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
