using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsCategory : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("label")] 
		public CName Label
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("subcategories")] 
		public CArray<SettingsCategory> Subcategories
		{
			get => GetPropertyValue<CArray<SettingsCategory>>();
			set => SetPropertyValue<CArray<SettingsCategory>>(value);
		}

		[Ordinal(2)] 
		[RED("options")] 
		public CArray<CHandle<userSettingsVar>> Options
		{
			get => GetPropertyValue<CArray<CHandle<userSettingsVar>>>();
			set => SetPropertyValue<CArray<CHandle<userSettingsVar>>>(value);
		}

		[Ordinal(3)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SettingsCategory()
		{
			Subcategories = new();
			Options = new();
			IsEmpty = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
