using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimsetWithOverridesTagCondition : animIRuntimeCondition
	{
		[Ordinal(0)] 
		[RED("animsetTags")] 
		public redTagList AnimsetTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public animAnimsetWithOverridesTagCondition()
		{
			AnimsetTags = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
