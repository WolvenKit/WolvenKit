using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AnimSetTagValue : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public animAnimNode_AnimSetTagValue()
		{
			Id = uint.MaxValue;
			Tags = new redTagList();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
