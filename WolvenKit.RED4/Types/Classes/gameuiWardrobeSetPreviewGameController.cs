using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWardrobeSetPreviewGameController : gameuiBaseGarmentItemPreviewGameController
	{
		[Ordinal(17)] 
		[RED("colliderWidgetRef")] 
		public inkWidgetReference ColliderWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("colliderWidget")] 
		public CWeakHandle<inkWidget> ColliderWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetPropertyValue<CHandle<InventoryItemPreviewData>>();
			set => SetPropertyValue<CHandle<InventoryItemPreviewData>>(value);
		}

		[Ordinal(20)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("isNotification")] 
		public CBool IsNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("c_GARMENT_ROTATION_SPEED")] 
		public CFloat C_GARMENT_ROTATION_SPEED
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiWardrobeSetPreviewGameController()
		{
			ColliderWidgetRef = new();
			C_GARMENT_ROTATION_SPEED = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
