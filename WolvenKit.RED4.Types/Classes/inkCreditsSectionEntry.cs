using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCreditsSectionEntry : RedBaseClass
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
	}
}
