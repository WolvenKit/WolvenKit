using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_Custom_HMG : gameuiCrosshairBaseGameController
	{
		[Ordinal(29)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("bottomPart")] 
		public inkWidgetReference BottomPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("overheatContainer")] 
		public inkWidgetReference OverheatContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("overheatWarning")] 
		public inkWidgetReference OverheatWarning
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("overheatMask")] 
		public inkWidgetReference OverheatMask
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("overheatValueL")] 
		public inkTextWidgetReference OverheatValueL
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("overheatValueR")] 
		public inkTextWidgetReference OverheatValueR
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("leftPartExtra")] 
		public inkImageWidgetReference LeftPartExtra
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("rightPartExtra")] 
		public inkImageWidgetReference RightPartExtra
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("crosshairContainer")] 
		public inkCanvasWidgetReference CrosshairContainer
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("weaponLocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(47)] 
		[RED("overheatBBID")] 
		public CHandle<redCallbackObject> OverheatBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(48)] 
		[RED("forcedOverheatBBID")] 
		public CHandle<redCallbackObject> ForcedOverheatBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("forcedCooldownProxy")] 
		public CHandle<inkanimProxy> ForcedCooldownProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(51)] 
		[RED("forcedCooldownOptions")] 
		public inkanimPlaybackOptions ForcedCooldownOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		public Crosshair_Custom_HMG()
		{
			LeftPart = new inkWidgetReference();
			RightPart = new inkWidgetReference();
			TopPart = new inkWidgetReference();
			BottomPart = new inkWidgetReference();
			HoriPart = new inkWidgetReference();
			VertPart = new inkWidgetReference();
			OverheatContainer = new inkWidgetReference();
			OverheatWarning = new inkWidgetReference();
			OverheatMask = new inkWidgetReference();
			OverheatValueL = new inkTextWidgetReference();
			OverheatValueR = new inkTextWidgetReference();
			LeftPartExtra = new inkImageWidgetReference();
			RightPartExtra = new inkImageWidgetReference();
			CrosshairContainer = new inkCanvasWidgetReference();
			OffsetLeftRight = 0.800000F;
			OffsetLeftRightExtra = 1.200000F;
			LatchVertical = 40.000000F;
			TargetColorChange = new inkWidgetReference();
			ForcedCooldownOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
