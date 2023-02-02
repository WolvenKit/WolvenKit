using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsVisualTagsSchema : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("categories")] 
		public CArray<toolsVisualTagsGroup> Categories
		{
			get => GetPropertyValue<CArray<toolsVisualTagsGroup>>();
			set => SetPropertyValue<CArray<toolsVisualTagsGroup>>(value);
		}

		[Ordinal(2)] 
		[RED("presets")] 
		public CArray<toolsVisualTagsGroup> Presets
		{
			get => GetPropertyValue<CArray<toolsVisualTagsGroup>>();
			set => SetPropertyValue<CArray<toolsVisualTagsGroup>>(value);
		}

		public toolsVisualTagsSchema()
		{
			Categories = new();
			Presets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
