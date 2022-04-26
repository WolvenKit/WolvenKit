using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AnimSetTagValue : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public animAnimNode_AnimSetTagValue()
		{
			Id = 4294967295;
			Tags = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
