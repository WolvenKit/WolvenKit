using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSideScrollerMiniGameCollisionLogic : inkWidgetLogicController
	{
		private Vector2 _colliderPositionOffset;
		private Vector2 _colliderSizeOffset;

		[Ordinal(1)] 
		[RED("colliderPositionOffset")] 
		public Vector2 ColliderPositionOffset
		{
			get => GetProperty(ref _colliderPositionOffset);
			set => SetProperty(ref _colliderPositionOffset, value);
		}

		[Ordinal(2)] 
		[RED("colliderSizeOffset")] 
		public Vector2 ColliderSizeOffset
		{
			get => GetProperty(ref _colliderSizeOffset);
			set => SetProperty(ref _colliderSizeOffset, value);
		}
	}
}
