
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkipPerformanceModeBegin : animAnimNode_OnePoseInput
	{
		public animAnimNode_SkipPerformanceModeBegin()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
