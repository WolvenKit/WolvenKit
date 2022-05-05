using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationInfoResource : CResource
	{
		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("headCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> HeadCustomizationOptions
		{
			get => GetPropertyValue<CArray<CHandle<gameuiCharacterCustomizationInfo>>>();
			set => SetPropertyValue<CArray<CHandle<gameuiCharacterCustomizationInfo>>>(value);
		}

		[Ordinal(3)] 
		[RED("bodyCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> BodyCustomizationOptions
		{
			get => GetPropertyValue<CArray<CHandle<gameuiCharacterCustomizationInfo>>>();
			set => SetPropertyValue<CArray<CHandle<gameuiCharacterCustomizationInfo>>>(value);
		}

		[Ordinal(4)] 
		[RED("armsCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> ArmsCustomizationOptions
		{
			get => GetPropertyValue<CArray<CHandle<gameuiCharacterCustomizationInfo>>>();
			set => SetPropertyValue<CArray<CHandle<gameuiCharacterCustomizationInfo>>>(value);
		}

		[Ordinal(5)] 
		[RED("armsGroups")] 
		public CArray<gameuiOptionsGroup> ArmsGroups
		{
			get => GetPropertyValue<CArray<gameuiOptionsGroup>>();
			set => SetPropertyValue<CArray<gameuiOptionsGroup>>(value);
		}

		[Ordinal(6)] 
		[RED("headGroups")] 
		public CArray<gameuiOptionsGroup> HeadGroups
		{
			get => GetPropertyValue<CArray<gameuiOptionsGroup>>();
			set => SetPropertyValue<CArray<gameuiOptionsGroup>>(value);
		}

		[Ordinal(7)] 
		[RED("bodyGroups")] 
		public CArray<gameuiOptionsGroup> BodyGroups
		{
			get => GetPropertyValue<CArray<gameuiOptionsGroup>>();
			set => SetPropertyValue<CArray<gameuiOptionsGroup>>(value);
		}

		[Ordinal(8)] 
		[RED("perspectiveInfo")] 
		public CArray<gameuiPerspectiveInfo> PerspectiveInfo
		{
			get => GetPropertyValue<CArray<gameuiPerspectiveInfo>>();
			set => SetPropertyValue<CArray<gameuiPerspectiveInfo>>(value);
		}

		[Ordinal(9)] 
		[RED("uiPresets")] 
		public CArray<gameuiCharacterCustomizationUiPresetInfo> UiPresets
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationUiPresetInfo>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationUiPresetInfo>>(value);
		}

		[Ordinal(10)] 
		[RED("excludedFromRandomize")] 
		public CArray<CName> ExcludedFromRandomize
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(11)] 
		[RED("versionUpdateInfo")] 
		public CArray<gameuiCharacterCustomizationVersionUpdateInfo> VersionUpdateInfo
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationVersionUpdateInfo>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationVersionUpdateInfo>>(value);
		}

		public gameuiCharacterCustomizationInfoResource()
		{
			HeadCustomizationOptions = new();
			BodyCustomizationOptions = new();
			ArmsCustomizationOptions = new();
			ArmsGroups = new();
			HeadGroups = new();
			BodyGroups = new();
			PerspectiveInfo = new();
			UiPresets = new();
			ExcludedFromRandomize = new();
			VersionUpdateInfo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
