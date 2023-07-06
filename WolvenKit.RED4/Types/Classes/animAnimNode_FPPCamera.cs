
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FPPCamera : animAnimNode_OnePoseInput
	{
		public animAnimNode_FPPCamera()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
