using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerVisuals_SetBrokenNoseStage : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)] 
		[RED("brokenNoseStage")] 
		public CEnum<gameuiCharacterCustomization_BrokenNoseStage> BrokenNoseStage
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomization_BrokenNoseStage>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomization_BrokenNoseStage>>(value);
		}
	}
}
