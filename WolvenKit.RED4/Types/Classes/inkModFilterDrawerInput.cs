using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkModFilterDrawerInput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("folderNameTextLocKey")] 
		public CString FolderNameTextLocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("bIsLanguageFilter")] 
		public CBool BIsLanguageFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("bAllowMultipleSelection")] 
		public CBool BAllowMultipleSelection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("listOfFilterItemNames")] 
		public CArray<CString> ListOfFilterItemNames
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(4)] 
		[RED("listOfFilterItemLocKeys")] 
		public CArray<CString> ListOfFilterItemLocKeys
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public inkModFilterDrawerInput()
		{
			ListOfFilterItemNames = new();
			ListOfFilterItemLocKeys = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
