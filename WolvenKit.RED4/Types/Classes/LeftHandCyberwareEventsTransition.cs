
namespace WolvenKit.RED4.Types
{
	public abstract partial class LeftHandCyberwareEventsTransition : LeftHandCyberwareTransition
	{
		public LeftHandCyberwareEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
