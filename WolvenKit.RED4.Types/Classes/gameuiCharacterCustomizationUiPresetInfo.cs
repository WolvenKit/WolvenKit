using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationUiPresetInfo : RedBaseClass
	{
		private CName _name;
		private CResourceAsyncReference<gameuiCharacterCustomizationUiPreset> _resource;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("resource")] 
		public CResourceAsyncReference<gameuiCharacterCustomizationUiPreset> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}
	}
}
