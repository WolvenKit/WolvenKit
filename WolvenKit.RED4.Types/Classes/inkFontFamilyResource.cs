using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFontFamilyResource : CResource
	{
		private CName _familyName;
		private CArray<inkFontStyle> _fontStyles;

		[Ordinal(1)] 
		[RED("familyName")] 
		public CName FamilyName
		{
			get => GetProperty(ref _familyName);
			set => SetProperty(ref _familyName, value);
		}

		[Ordinal(2)] 
		[RED("fontStyles")] 
		public CArray<inkFontStyle> FontStyles
		{
			get => GetProperty(ref _fontStyles);
			set => SetProperty(ref _fontStyles, value);
		}
	}
}
