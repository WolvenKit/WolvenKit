using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
	{
		[Ordinal(33)] 
		[RED("leftBracket")] 
		public CWeakHandle<inkImageWidget> LeftBracket
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(34)] 
		[RED("rightBracket")] 
		public CWeakHandle<inkImageWidget> RightBracket
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(35)] 
		[RED("hori")] 
		public CWeakHandle<inkWidget> Hori
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(36)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkWidget> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(37)] 
		[RED("chargeBoth")] 
		public CWeakHandle<inkWidget> ChargeBoth
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(38)] 
		[RED("chargeLeftBar")] 
		public CWeakHandle<inkRectangleWidget> ChargeLeftBar
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(39)] 
		[RED("chargeRightBar")] 
		public CWeakHandle<inkRectangleWidget> ChargeRightBar
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(40)] 
		[RED("centerPart")] 
		public CWeakHandle<inkImageWidget> CenterPart
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(41)] 
		[RED("fluffCanvas")] 
		public CWeakHandle<inkWidget> FluffCanvas
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(42)] 
		[RED("chargeAnimationProxy")] 
		public CHandle<inkanimProxy> ChargeAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(44)] 
		[RED("weaponlocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(45)] 
		[RED("bbcharge")] 
		public CHandle<redCallbackObject> Bbcharge
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("bbcurrentFireMode")] 
		public CHandle<redCallbackObject> BbcurrentFireMode
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetPropertyValue<CEnum<gamedataTriggerMode>>();
			set => SetPropertyValue<CEnum<gamedataTriggerMode>>(value);
		}

		[Ordinal(48)] 
		[RED("bbNPCStatsInfo")] 
		public CHandle<redCallbackObject> BbNPCStatsInfo
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("charge")] 
		public CFloat Charge
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("spread")] 
		public CFloat Spread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CrosshairGameController_Tech_Hex()
		{
			BufferedSpread = new Vector2();
			GameplaySpreadMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
