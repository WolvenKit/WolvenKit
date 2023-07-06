
namespace WolvenKit.RED4.Types
{
	public abstract partial class ReactionTransition : DefaultTransition
	{
		public ReactionTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
