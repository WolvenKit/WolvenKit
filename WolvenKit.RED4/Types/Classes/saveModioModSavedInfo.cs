using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class saveModioModSavedInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("modID")] 
		public CInt64 ModID
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(1)] 
		[RED("modName")] 
		public CString ModName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("authorName")] 
		public CString AuthorName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public saveModioModSavedInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
