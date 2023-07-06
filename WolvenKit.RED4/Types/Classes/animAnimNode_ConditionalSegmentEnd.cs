
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ConditionalSegmentEnd : animAnimNode_OnePoseInput
	{
		public animAnimNode_ConditionalSegmentEnd()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
