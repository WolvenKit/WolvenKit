using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationHairstyleController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(3)] 
		[RED("headGroupName")] 
		public CName HeadGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationHairstyleController()
		{
			Name = "Component";
		}
	}
}
