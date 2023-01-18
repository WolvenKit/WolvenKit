
namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimatorComponentReplicatedState : netIComponentState
	{
		public gameTransformAnimatorComponentReplicatedState()
		{
			Enabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
