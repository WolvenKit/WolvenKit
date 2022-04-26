using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveMotionPlannerComponent : moveIMotionPlannerComponent
	{
		[Ordinal(3)] 
		[RED("snapToGround")] 
		public CBool SnapToGround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public moveMotionPlannerComponent()
		{
			Name = "Component";
			SnapToGround = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
