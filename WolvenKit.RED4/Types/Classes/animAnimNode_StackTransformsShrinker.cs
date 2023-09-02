using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StackTransformsShrinker : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_StackTransformsShrinker()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
