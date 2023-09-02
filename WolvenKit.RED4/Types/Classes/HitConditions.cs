
namespace WolvenKit.RED4.Types
{
	public abstract partial class HitConditions : AIbehaviorconditionScript
	{
		public HitConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
