using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocMetersCapacity : RipperdocMetersBase
	{
		[Ordinal(24)] 
		[RED("defaultRightBarScale")] 
		public CFloat DefaultRightBarScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("overchargeGapSize")] 
		public CFloat OverchargeGapSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("curCapacityLabelContainer")] 
		public inkWidgetReference CurCapacityLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("curCapacityLabelBackground")] 
		public inkWidgetReference CurCapacityLabelBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("costLabelContainer")] 
		public inkWidgetReference CostLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("costLabelText")] 
		public inkTextWidgetReference CostLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("maxCapacityLabelContainer")] 
		public inkWidgetReference MaxCapacityLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("maxCapacityLabelText")] 
		public inkTextWidgetReference MaxCapacityLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("overchargeBox")] 
		public inkWidgetReference OverchargeBox
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("thresholdLine")] 
		public inkWidgetReference ThresholdLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("edgrunnerLock")] 
		public inkWidgetReference EdgrunnerLock
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("overchargeGlow")] 
		public inkWidgetReference OverchargeGlow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("overchargeGlowAnimName")] 
		public CName OverchargeGlowAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("overchargeVisibilityThreshold")] 
		public CFloat OverchargeVisibilityThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("currentCapacity")] 
		public CInt32 CurrentCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(39)] 
		[RED("maxCapacity")] 
		public CInt32 MaxCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(40)] 
		[RED("maxCapacityPossible")] 
		public CFloat MaxCapacityPossible
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("overchargeMaxCapacity")] 
		public CInt32 OverchargeMaxCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(42)] 
		[RED("overchargeValue")] 
		public CInt32 OverchargeValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(43)] 
		[RED("isEdgerunner")] 
		public CBool IsEdgerunner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("curCapacityLabel")] 
		public CWeakHandle<RipperdocFillLabel> CurCapacityLabel
		{
			get => GetPropertyValue<CWeakHandle<RipperdocFillLabel>>();
			set => SetPropertyValue<CWeakHandle<RipperdocFillLabel>>(value);
		}

		[Ordinal(45)] 
		[RED("capacityLabelAnimation")] 
		public CHandle<inkanimProxy> CapacityLabelAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(46)] 
		[RED("costLabelAnimation")] 
		public CHandle<inkanimProxy> CostLabelAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(47)] 
		[RED("capacityPulseAnimation")] 
		public CHandle<PulseAnimation> CapacityPulseAnimation
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(48)] 
		[RED("costLabelPulseAnimation")] 
		public CHandle<PulseAnimation> CostLabelPulseAnimation
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(49)] 
		[RED("overchargeGlowAnimProxy")] 
		public CHandle<inkanimProxy> OverchargeGlowAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(50)] 
		[RED("overchargeGlowAnimOptions")] 
		public inkanimPlaybackOptions OverchargeGlowAnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(51)] 
		[RED("overchargeBoxState")] 
		public CName OverchargeBoxState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(52)] 
		[RED("maxBaseBar")] 
		public CInt32 MaxBaseBar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(53)] 
		[RED("overBars")] 
		public CInt32 OverBars
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(54)] 
		[RED("barsSpawned")] 
		public CBool BarsSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("showOverchargeBox")] 
		public CBool ShowOverchargeBox
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("isHoverdCyberwareEquipped")] 
		public CBool IsHoverdCyberwareEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("C_costLabelAnchorPoint_ADD")] 
		public Vector2 C_costLabelAnchorPoint_ADD
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(58)] 
		[RED("C_costLabelAnchorPoint_SUBTRACT")] 
		public Vector2 C_costLabelAnchorPoint_SUBTRACT
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(59)] 
		[RED("C_costLabelAnchorPoint_EQUIPPED")] 
		public Vector2 C_costLabelAnchorPoint_EQUIPPED
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(60)] 
		[RED("C_costLabelAnchorPoint_EQUIPPED_EDGRUNNER")] 
		public Vector2 C_costLabelAnchorPoint_EQUIPPED_EDGRUNNER
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public RipperdocMetersCapacity()
		{
			BarWidgetLibraryName = "CapacityMeterBar";
			SlopeLengthModifier = 0.075000F;
			BarsHeigh = 9.000000F;
			BarsMargin = 9.000000F;
			DefaultRightBarScale = 1.000000F;
			OverchargeGapSize = 9.000000F;
			CurCapacityLabelContainer = new inkWidgetReference();
			CurCapacityLabelBackground = new inkWidgetReference();
			CostLabelContainer = new inkWidgetReference();
			CostLabelText = new inkTextWidgetReference();
			MaxCapacityLabelContainer = new inkWidgetReference();
			MaxCapacityLabelText = new inkTextWidgetReference();
			OverchargeBox = new inkWidgetReference();
			ThresholdLine = new inkWidgetReference();
			EdgrunnerLock = new inkWidgetReference();
			OverchargeGlow = new inkWidgetReference();
			OverchargeGlowAnimName = "overchargeGlow_pulse";
			OverchargeVisibilityThreshold = 0.200000F;
			OverchargeValue = 50;
			OverchargeGlowAnimOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };
			C_costLabelAnchorPoint_ADD = new Vector2();
			C_costLabelAnchorPoint_SUBTRACT = new Vector2();
			C_costLabelAnchorPoint_EQUIPPED = new Vector2();
			C_costLabelAnchorPoint_EQUIPPED_EDGRUNNER = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
