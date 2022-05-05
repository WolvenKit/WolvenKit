using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVisualTagsSchema : ISerializable
	{
		[Ordinal(0)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(1)] 
		[RED("schema")] 
		public CName Schema
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entVisualTagsSchema()
		{
			VisualTags = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
