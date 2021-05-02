using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFontFamilyResource : CResource
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

		public inkFontFamilyResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
