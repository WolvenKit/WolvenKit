
namespace WolvenKit.RED4.Types
{
	public partial class HasLastKnownPositionChanged : PreventionConditionAbstract
	{
		public HasLastKnownPositionChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
