
namespace WolvenKit.RED4.Types
{
	public abstract partial class moveIMotionPlannerComponent : entIComponent
	{
		public moveIMotionPlannerComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
