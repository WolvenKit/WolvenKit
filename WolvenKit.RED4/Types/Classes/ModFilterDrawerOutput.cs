using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModFilterDrawerOutput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("activeFilterName")] 
		public CString ActiveFilterName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("localizedFilterName")] 
		public CString LocalizedFilterName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("bIsLanguageFilter")] 
		public CBool BIsLanguageFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("bIsExceptionFilter")] 
		public CBool BIsExceptionFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ModFilterDrawerOutput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
