using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerVisuals_SetBrokenNoseStage : questICharacterManagerVisuals_NodeSubType
	{
		private CEnum<gameuiCharacterCustomization_BrokenNoseStage> _brokenNoseStage;

		[Ordinal(0)] 
		[RED("brokenNoseStage")] 
		public CEnum<gameuiCharacterCustomization_BrokenNoseStage> BrokenNoseStage
		{
			get => GetProperty(ref _brokenNoseStage);
			set => SetProperty(ref _brokenNoseStage, value);
		}
	}
}
