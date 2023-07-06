
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PoseCorrection : animAnimNode_OnePoseInput
	{
		public animAnimNode_PoseCorrection()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
