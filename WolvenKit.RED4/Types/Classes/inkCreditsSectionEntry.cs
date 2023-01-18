using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCreditsSectionEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sectionTitle")] 
		public CString SectionTitle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(2)] 
		[RED("displayMode")] 
		public CEnum<inkDisplayMode> DisplayMode
		{
			get => GetPropertyValue<CEnum<inkDisplayMode>>();
			set => SetPropertyValue<CEnum<inkDisplayMode>>(value);
		}

		public inkCreditsSectionEntry()
		{
			Names = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
