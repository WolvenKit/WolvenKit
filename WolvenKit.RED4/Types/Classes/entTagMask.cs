using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTagMask : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hardTags")] 
		public redTagList HardTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(1)] 
		[RED("softTags")] 
		public redTagList SoftTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(2)] 
		[RED("excludedTags")] 
		public redTagList ExcludedTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public entTagMask()
		{
			HardTags = new redTagList { Tags = new() };
			SoftTags = new redTagList { Tags = new() };
			ExcludedTags = new redTagList { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
