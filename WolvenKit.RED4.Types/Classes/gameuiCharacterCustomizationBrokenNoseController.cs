using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationBrokenNoseController : gameuiICharacterCustomizationComponent
	{
		private gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance _stage1App;
		private gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance _stage2App;

		[Ordinal(3)] 
		[RED("stage1App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage1App
		{
			get => GetProperty(ref _stage1App);
			set => SetProperty(ref _stage1App, value);
		}

		[Ordinal(4)] 
		[RED("stage2App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage2App
		{
			get => GetProperty(ref _stage2App);
			set => SetProperty(ref _stage2App, value);
		}
	}
}
