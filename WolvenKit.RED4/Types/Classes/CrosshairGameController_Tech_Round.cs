using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Tech_Round : BaseTechCrosshairController
	{
		[Ordinal(35)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(36)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("topPart")] 
		public inkImageWidgetReference TopPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("bottomPart")] 
		public inkImageWidgetReference BottomPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkCanvasWidget> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(46)] 
		[RED("chargeBarFG")] 
		public CWeakHandle<inkRectangleWidget> ChargeBarFG
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(47)] 
		[RED("chargeBarBG")] 
		public CWeakHandle<inkRectangleWidget> ChargeBarBG
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(48)] 
		[RED("chargeBarMG")] 
		public CWeakHandle<inkRectangleWidget> ChargeBarMG
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(49)] 
		[RED("centerPart")] 
		public CWeakHandle<inkWidget> CenterPart
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(50)] 
		[RED("crosshair")] 
		public CWeakHandle<inkWidget> Crosshair
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(51)] 
		[RED("bottom_hip_bar")] 
		public CWeakHandle<inkWidget> Bottom_hip_bar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(52)] 
		[RED("realFluffText_1")] 
		public CWeakHandle<inkTextWidget> RealFluffText_1
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(53)] 
		[RED("realFluffText_2")] 
		public CWeakHandle<inkTextWidget> RealFluffText_2
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(54)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(55)] 
		[RED("weaponlocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(56)] 
		[RED("bbcharge")] 
		public CHandle<redCallbackObject> Bbcharge
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(57)] 
		[RED("bbmagazineAmmoCapacity")] 
		public CHandle<redCallbackObject> BbmagazineAmmoCapacity
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(58)] 
		[RED("bbmagazineAmmoCount")] 
		public CHandle<redCallbackObject> BbmagazineAmmoCount
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(59)] 
		[RED("bbcurrentFireMode")] 
		public CHandle<redCallbackObject> BbcurrentFireMode
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(60)] 
		[RED("currentAmmo")] 
		public CInt32 CurrentAmmo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(61)] 
		[RED("currentMaxAmmo")] 
		public CInt32 CurrentMaxAmmo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(62)] 
		[RED("maxSupportedAmmo")] 
		public CInt32 MaxSupportedAmmo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(63)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetPropertyValue<CEnum<gamedataTriggerMode>>();
			set => SetPropertyValue<CEnum<gamedataTriggerMode>>(value);
		}

		[Ordinal(64)] 
		[RED("orgSideSize")] 
		public Vector2 OrgSideSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(65)] 
		[RED("sidesScale")] 
		public CFloat SidesScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("chargeAnimationProxy")] 
		public CHandle<inkanimProxy> ChargeAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(67)] 
		[RED("bbNPCStatsInfo")] 
		public CHandle<redCallbackObject> BbNPCStatsInfo
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(68)] 
		[RED("currentObstructedTargetBBID")] 
		public CHandle<redCallbackObject> CurrentObstructedTargetBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(69)] 
		[RED("potentialVisibleTarget")] 
		public CWeakHandle<gameObject> PotentialVisibleTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(70)] 
		[RED("potentialObstructedTarget")] 
		public CWeakHandle<gameObject> PotentialObstructedTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(71)] 
		[RED("useVisibleTarget")] 
		public CBool UseVisibleTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(73)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(74)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(75)] 
		[RED("stateADS")] 
		public CBool StateADS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrosshairGameController_Tech_Round()
		{
			LeftPart = new inkImageWidgetReference();
			RightPart = new inkImageWidgetReference();
			OffsetLeftRight = 0.800000F;
			OffsetLeftRightExtra = 1.200000F;
			LatchVertical = 40.000000F;
			TopPart = new inkImageWidgetReference();
			BottomPart = new inkImageWidgetReference();
			HoriPart = new inkWidgetReference();
			VertPart = new inkWidgetReference();
			BufferedSpread = new Vector2();
			CurrentAmmo = 2;
			CurrentMaxAmmo = 2;
			MaxSupportedAmmo = 8;
			OrgSideSize = new Vector2();
			UseVisibleTarget = true;
			GameplaySpreadMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
