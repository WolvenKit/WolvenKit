using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAppearanceInfo : gameuiCharacterCustomizationInfo
	{
		private CResourceAsyncReference<appearanceAppearanceResource> _resource;
		private CArray<gameuiIndexedAppearanceDefinition> _definitions;
		private CBool _useThumbnails;

		[Ordinal(12)] 
		[RED("resource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(13)] 
		[RED("definitions")] 
		public CArray<gameuiIndexedAppearanceDefinition> Definitions
		{
			get => GetProperty(ref _definitions);
			set => SetProperty(ref _definitions, value);
		}

		[Ordinal(14)] 
		[RED("useThumbnails")] 
		public CBool UseThumbnails
		{
			get => GetProperty(ref _useThumbnails);
			set => SetProperty(ref _useThumbnails, value);
		}
	}
}
