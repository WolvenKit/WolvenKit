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
			HardTags = new() { Tags = new() };
			SoftTags = new() { Tags = new() };
			ExcludedTags = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
