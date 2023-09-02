using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationPreset : CResource
	{
		[Ordinal(1)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("bodyGroups")] 
		public CArray<gameuiCustomizationGroup> BodyGroups
		{
			get => GetPropertyValue<CArray<gameuiCustomizationGroup>>();
			set => SetPropertyValue<CArray<gameuiCustomizationGroup>>(value);
		}

		[Ordinal(3)] 
		[RED("headGroups")] 
		public CArray<gameuiCustomizationGroup> HeadGroups
		{
			get => GetPropertyValue<CArray<gameuiCustomizationGroup>>();
			set => SetPropertyValue<CArray<gameuiCustomizationGroup>>(value);
		}

		[Ordinal(4)] 
		[RED("armsGroups")] 
		public CArray<gameuiCustomizationGroup> ArmsGroups
		{
			get => GetPropertyValue<CArray<gameuiCustomizationGroup>>();
			set => SetPropertyValue<CArray<gameuiCustomizationGroup>>(value);
		}

		[Ordinal(5)] 
		[RED("perspectiveInfo")] 
		public CArray<gameuiPerspectiveInfo> PerspectiveInfo
		{
			get => GetPropertyValue<CArray<gameuiPerspectiveInfo>>();
			set => SetPropertyValue<CArray<gameuiPerspectiveInfo>>(value);
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(7)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiCharacterCustomizationPreset()
		{
			BodyGroups = new();
			HeadGroups = new();
			ArmsGroups = new();
			PerspectiveInfo = new();
			Tags = new redTagList { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
