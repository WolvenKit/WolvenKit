
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ForegroundSegmentBegin : animAnimNode_OnePoseInput
	{
		public animAnimNode_ForegroundSegmentBegin()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
