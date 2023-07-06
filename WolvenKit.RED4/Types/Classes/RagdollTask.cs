
namespace WolvenKit.RED4.Types
{
	public abstract partial class RagdollTask : AIbehaviortaskScript
	{
		public RagdollTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
