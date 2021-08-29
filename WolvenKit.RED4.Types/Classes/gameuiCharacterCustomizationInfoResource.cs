using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationInfoResource : CResource
	{
		private CUInt32 _version;
		private CArray<CHandle<gameuiCharacterCustomizationInfo>> _headCustomizationOptions;
		private CArray<CHandle<gameuiCharacterCustomizationInfo>> _bodyCustomizationOptions;
		private CArray<CHandle<gameuiCharacterCustomizationInfo>> _armsCustomizationOptions;
		private CArray<gameuiOptionsGroup> _armsGroups;
		private CArray<gameuiOptionsGroup> _headGroups;
		private CArray<gameuiOptionsGroup> _bodyGroups;
		private CArray<gameuiPerspectiveInfo> _perspectiveInfo;
		private CArray<gameuiCharacterCustomizationUiPresetInfo> _uiPresets;
		private CArray<CName> _excludedFromRandomize;

		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(2)] 
		[RED("headCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> HeadCustomizationOptions
		{
			get => GetProperty(ref _headCustomizationOptions);
			set => SetProperty(ref _headCustomizationOptions, value);
		}

		[Ordinal(3)] 
		[RED("bodyCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> BodyCustomizationOptions
		{
			get => GetProperty(ref _bodyCustomizationOptions);
			set => SetProperty(ref _bodyCustomizationOptions, value);
		}

		[Ordinal(4)] 
		[RED("armsCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> ArmsCustomizationOptions
		{
			get => GetProperty(ref _armsCustomizationOptions);
			set => SetProperty(ref _armsCustomizationOptions, value);
		}

		[Ordinal(5)] 
		[RED("armsGroups")] 
		public CArray<gameuiOptionsGroup> ArmsGroups
		{
			get => GetProperty(ref _armsGroups);
			set => SetProperty(ref _armsGroups, value);
		}

		[Ordinal(6)] 
		[RED("headGroups")] 
		public CArray<gameuiOptionsGroup> HeadGroups
		{
			get => GetProperty(ref _headGroups);
			set => SetProperty(ref _headGroups, value);
		}

		[Ordinal(7)] 
		[RED("bodyGroups")] 
		public CArray<gameuiOptionsGroup> BodyGroups
		{
			get => GetProperty(ref _bodyGroups);
			set => SetProperty(ref _bodyGroups, value);
		}

		[Ordinal(8)] 
		[RED("perspectiveInfo")] 
		public CArray<gameuiPerspectiveInfo> PerspectiveInfo
		{
			get => GetProperty(ref _perspectiveInfo);
			set => SetProperty(ref _perspectiveInfo, value);
		}

		[Ordinal(9)] 
		[RED("uiPresets")] 
		public CArray<gameuiCharacterCustomizationUiPresetInfo> UiPresets
		{
			get => GetProperty(ref _uiPresets);
			set => SetProperty(ref _uiPresets, value);
		}

		[Ordinal(10)] 
		[RED("excludedFromRandomize")] 
		public CArray<CName> ExcludedFromRandomize
		{
			get => GetProperty(ref _excludedFromRandomize);
			set => SetProperty(ref _excludedFromRandomize, value);
		}
	}
}
