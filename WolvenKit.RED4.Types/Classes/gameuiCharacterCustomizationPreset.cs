using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationPreset : CResource
	{
		private CBool _isMale;
		private CArray<gameuiCustomizationGroup> _bodyGroups;
		private CArray<gameuiCustomizationGroup> _headGroups;
		private CArray<gameuiCustomizationGroup> _armsGroups;
		private CArray<gameuiPerspectiveInfo> _perspectiveInfo;
		private redTagList _tags;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetProperty(ref _isMale);
			set => SetProperty(ref _isMale, value);
		}

		[Ordinal(2)] 
		[RED("bodyGroups")] 
		public CArray<gameuiCustomizationGroup> BodyGroups
		{
			get => GetProperty(ref _bodyGroups);
			set => SetProperty(ref _bodyGroups, value);
		}

		[Ordinal(3)] 
		[RED("headGroups")] 
		public CArray<gameuiCustomizationGroup> HeadGroups
		{
			get => GetProperty(ref _headGroups);
			set => SetProperty(ref _headGroups, value);
		}

		[Ordinal(4)] 
		[RED("armsGroups")] 
		public CArray<gameuiCustomizationGroup> ArmsGroups
		{
			get => GetProperty(ref _armsGroups);
			set => SetProperty(ref _armsGroups, value);
		}

		[Ordinal(5)] 
		[RED("perspectiveInfo")] 
		public CArray<gameuiPerspectiveInfo> PerspectiveInfo
		{
			get => GetProperty(ref _perspectiveInfo);
			set => SetProperty(ref _perspectiveInfo, value);
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(7)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}
	}
}
