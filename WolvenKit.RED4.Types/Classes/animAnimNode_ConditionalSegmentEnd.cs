
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ConditionalSegmentEnd : animAnimNode_OnePoseInput
	{
		public animAnimNode_ConditionalSegmentEnd()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
