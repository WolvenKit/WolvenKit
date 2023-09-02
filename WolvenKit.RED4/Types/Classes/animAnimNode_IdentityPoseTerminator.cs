
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_IdentityPoseTerminator : animAnimNode_Base
	{
		public animAnimNode_IdentityPoseTerminator()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
