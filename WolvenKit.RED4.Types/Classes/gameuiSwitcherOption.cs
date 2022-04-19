using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSwitcherOption : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("actions")] 
		public CArray<gameuiCharacterCustomizationAction> Actions
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationAction>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationAction>>(value);
		}

		[Ordinal(4)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public gameuiSwitcherOption()
		{
			Names = new();
			Actions = new();
			Tags = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
