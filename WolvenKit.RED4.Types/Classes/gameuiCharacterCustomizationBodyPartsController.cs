using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationBodyPartsController : gameuiICharacterCustomizationBodyPartsController
	{
		[Ordinal(3)] 
		[RED("isHiddenInFpp")] 
		public CBool IsHiddenInFpp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
