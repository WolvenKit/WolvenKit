
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIITargetTrackingListener : IScriptable
	{
		public AIITargetTrackingListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
