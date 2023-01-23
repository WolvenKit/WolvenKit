
namespace WolvenKit.RED4.Types
{
	public partial class DeadState : ChangeHighLevelStateAbstract
	{
		public DeadState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
