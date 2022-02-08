using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationFeetController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(3)] 
		[RED("liftedFeetGroupName")] 
		public CName LiftedFeetGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("flatFeetGroupName")] 
		public CName FlatFeetGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationFeetController()
		{
			Name = "Component";
		}
	}
}
