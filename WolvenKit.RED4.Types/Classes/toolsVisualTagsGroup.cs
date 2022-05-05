using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsVisualTagsGroup : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("tags")] 
		public CArray<toolsVisualTagsDefinition> Tags
		{
			get => GetPropertyValue<CArray<toolsVisualTagsDefinition>>();
			set => SetPropertyValue<CArray<toolsVisualTagsDefinition>>(value);
		}

		public toolsVisualTagsGroup()
		{
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
