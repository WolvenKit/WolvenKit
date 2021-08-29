using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance : RedBaseClass
	{
		private CResourceAsyncReference<appearanceAppearanceResource> _resource;
		private CName _definition;

		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(1)] 
		[RED("definition")] 
		public CName Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}
	}
}
