using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAppearanceInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(12)] 
		[RED("resource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>();
			set => SetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>(value);
		}

		[Ordinal(13)] 
		[RED("definitions")] 
		public CArray<gameuiIndexedAppearanceDefinition> Definitions
		{
			get => GetPropertyValue<CArray<gameuiIndexedAppearanceDefinition>>();
			set => SetPropertyValue<CArray<gameuiIndexedAppearanceDefinition>>(value);
		}

		[Ordinal(14)] 
		[RED("useThumbnails")] 
		public CBool UseThumbnails
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiAppearanceInfo()
		{
			Enabled = true;
			OnDeactivateActions = new();
			Definitions = new();
		}
	}
}
