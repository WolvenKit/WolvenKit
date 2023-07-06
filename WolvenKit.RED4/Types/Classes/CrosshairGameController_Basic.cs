using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Basic : gameuiCrosshairBaseGameController
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
		[RED("upPart")] 
		public inkImageWidgetReference UpPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("downPart")] 
		public inkImageWidgetReference DownPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("centerPart")] 
		public inkImageWidgetReference CenterPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(24)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetPropertyValue<CEnum<gamedataTriggerMode>>();
			set => SetPropertyValue<CEnum<gamedataTriggerMode>>(value);
		}

		[Ordinal(25)] 
		[RED("weaponlocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("bbcurrentFireMode")] 
		public CHandle<redCallbackObject> BbcurrentFireMode
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("ricochetModeActive")] 
		public CUInt32 RicochetModeActive
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(28)] 
		[RED("RicochetChance")] 
		public CUInt32 RicochetChance
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(29)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CrosshairGameController_Basic()
		{
			LeftPart = new inkImageWidgetReference();
			RightPart = new inkImageWidgetReference();
			UpPart = new inkImageWidgetReference();
			DownPart = new inkImageWidgetReference();
			CenterPart = new inkImageWidgetReference();
			BufferedSpread = new Vector2();
			HorizontalMinSpread = 20.000000F;
			VerticalMinSpread = 20.000000F;
			GameplaySpreadMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
