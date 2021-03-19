using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCreditsSectionEntry : CVariable
	{
		private CString _sectionTitle;
		private CArray<CString> _names;
		private CEnum<inkDisplayMode> _displayMode;

		[Ordinal(0)] 
		[RED("sectionTitle")] 
		public CString SectionTitle
		{
			get => GetProperty(ref _sectionTitle);
			set => SetProperty(ref _sectionTitle, value);
		}

		[Ordinal(1)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		[Ordinal(2)] 
		[RED("displayMode")] 
		public CEnum<inkDisplayMode> DisplayMode
		{
			get => GetProperty(ref _displayMode);
			set => SetProperty(ref _displayMode, value);
		}

		public inkCreditsSectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
