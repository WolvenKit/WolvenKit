using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationGenitalsController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(4)] 
		[RED("upperBodyGroupName")] 
		public CName UpperBodyGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("bottomBodyGroupName")] 
		public CName BottomBodyGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("forceHideGenitals")] 
		public CBool ForceHideGenitals
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiCharacterCustomizationGenitalsController()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
