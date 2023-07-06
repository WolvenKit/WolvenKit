using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Melee : gameuiCrosshairBaseMelee
	{
		[Ordinal(20)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkCanvasWidget> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("chargeBarFG")] 
		public CWeakHandle<inkRectangleWidget> ChargeBarFG
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("chargeBarMonoTop")] 
		public CWeakHandle<inkImageWidget> ChargeBarMonoTop
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("chargeBarMonoBottom")] 
		public CWeakHandle<inkImageWidget> ChargeBarMonoBottom
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("chargeBarMask")] 
		public CWeakHandle<inkMaskWidget> ChargeBarMask
		{
			get => GetPropertyValue<CWeakHandle<inkMaskWidget>>();
			set => SetPropertyValue<CWeakHandle<inkMaskWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("chargeValueL")] 
		public CWeakHandle<inkTextWidget> ChargeValueL
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("chargeValueR")] 
		public CWeakHandle<inkTextWidget> ChargeValueR
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("bbcharge")] 
		public CUInt32 Bbcharge
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(29)] 
		[RED("meleeResourcePoolListener")] 
		public CHandle<MeleeResourcePoolListener> MeleeResourcePoolListener
		{
			get => GetPropertyValue<CHandle<MeleeResourcePoolListener>>();
			set => SetPropertyValue<CHandle<MeleeResourcePoolListener>>(value);
		}

		[Ordinal(30)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(31)] 
		[RED("displayChargeBar")] 
		public CBool DisplayChargeBar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrosshairGameController_Melee()
		{
			TargetColorChange = new inkWidgetReference();
			WeaponID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
