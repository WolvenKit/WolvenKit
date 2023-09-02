using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiIndexedAppearanceDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public TweakDBID Icon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("actions")] 
		public CArray<gameuiCharacterCustomizationAction> Actions
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationAction>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationAction>>(value);
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public gameuiIndexedAppearanceDefinition()
		{
			Color = new CColor();
			Actions = new();
			Tags = new redTagList { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
