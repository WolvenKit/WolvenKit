using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GarmentItemPreviewGameController : gameuiBaseGarmentItemPreviewGameController
	{
		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetPropertyValue<CHandle<InventoryItemPreviewData>>();
			set => SetPropertyValue<CHandle<InventoryItemPreviewData>>(value);
		}

		[Ordinal(19)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("c_GARMENT_ROTATION_SPEED")] 
		public CFloat C_GARMENT_ROTATION_SPEED
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GarmentItemPreviewGameController()
		{
			C_GARMENT_ROTATION_SPEED = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
