
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RagdollPose : animAnimNode_Base
	{
		public animAnimNode_RagdollPose()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
