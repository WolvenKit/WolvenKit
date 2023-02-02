using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Simple : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("leftPartExtra")] 
		public inkImageWidgetReference LeftPartExtra
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("rightPartExtra")] 
		public inkImageWidgetReference RightPartExtra
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("topPart")] 
		public inkImageWidgetReference TopPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("bottomPart")] 
		public inkImageWidgetReference BottomPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("middlePart")] 
		public inkWidgetReference MiddlePart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("overheatShake")] 
		public inkWidgetReference OverheatShake
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("overheatTL")] 
		public inkWidgetReference OverheatTL
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("overheatBL")] 
		public inkWidgetReference OverheatBL
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("overheatTR")] 
		public inkWidgetReference OverheatTR
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("overheatBR")] 
		public inkWidgetReference OverheatBR
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("weaponLocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(37)] 
		[RED("onChargeChangeBBID")] 
		public CHandle<redCallbackObject> OnChargeChangeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("shakeAnimation")] 
		public CHandle<inkanimProxy> ShakeAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(39)] 
		[RED("isInForcedCool")] 
		public CBool IsInForcedCool
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrosshairGameController_Simple()
		{
			LeftPart = new();
			RightPart = new();
			LeftPartExtra = new();
			RightPartExtra = new();
			OffsetLeftRight = 0.800000F;
			OffsetLeftRightExtra = 1.200000F;
			LatchVertical = 40.000000F;
			TopPart = new();
			BottomPart = new();
			HoriPart = new();
			VertPart = new();
			TargetColorChange = new();
			MiddlePart = new();
			OverheatShake = new();
			OverheatTL = new();
			OverheatBL = new();
			OverheatTR = new();
			OverheatBR = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
