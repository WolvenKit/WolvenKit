using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationGenitalsController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(3)] 
		[RED("upperBodyGroupName")] 
		public CName UpperBodyGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("bottomBodyGroupName")] 
		public CName BottomBodyGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("forceHideGenitals")] 
		public CBool ForceHideGenitals
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiCharacterCustomizationGenitalsController()
		{
			Name = "Component";
		}
	}
}
