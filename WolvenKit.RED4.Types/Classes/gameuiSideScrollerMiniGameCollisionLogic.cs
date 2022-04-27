using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSideScrollerMiniGameCollisionLogic : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("colliderPositionOffset")] 
		public Vector2 ColliderPositionOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("colliderSizeOffset")] 
		public Vector2 ColliderSizeOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameuiSideScrollerMiniGameCollisionLogic()
		{
			ColliderPositionOffset = new();
			ColliderSizeOffset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
