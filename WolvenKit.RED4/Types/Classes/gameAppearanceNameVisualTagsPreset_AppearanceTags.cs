using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAppearanceNameVisualTagsPreset_AppearanceTags : ISerializable
	{
		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public gameAppearanceNameVisualTagsPreset_AppearanceTags()
		{
			VisualTags = new redTagList { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
