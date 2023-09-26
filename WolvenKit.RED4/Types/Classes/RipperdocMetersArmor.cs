using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocMetersArmor : RipperdocMetersBase
	{
		[Ordinal(24)] 
		[RED("barScale")] 
		public CFloat BarScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("currentArmorLabelContainer")] 
		public inkWidgetReference CurrentArmorLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("currentArmorLabelBackground")] 
		public inkWidgetReference CurrentArmorLabelBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("costArmorLabelContainer")] 
		public inkWidgetReference CostArmorLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("costArmorLabelBackground")] 
		public inkWidgetReference CostArmorLabelBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("costArmorLabelValue")] 
		public inkTextWidgetReference CostArmorLabelValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("maxArmorLabel")] 
		public inkWidgetReference MaxArmorLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("maxArmorLabelContainer")] 
		public inkWidgetReference MaxArmorLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("maxArmorLabelValue")] 
		public inkTextWidgetReference MaxArmorLabelValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("maxArmor")] 
		public CFloat MaxArmor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("curEquippedArmor")] 
		public CFloat CurEquippedArmor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("newEquippedArmor")] 
		public CFloat NewEquippedArmor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("maxArmorPossible")] 
		public CFloat MaxArmorPossible
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("maxDamageReduction")] 
		public CFloat MaxDamageReduction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("currentArmorLabel")] 
		public CWeakHandle<RipperdocFillLabel> CurrentArmorLabel
		{
			get => GetPropertyValue<CWeakHandle<RipperdocFillLabel>>();
			set => SetPropertyValue<CWeakHandle<RipperdocFillLabel>>(value);
		}

		[Ordinal(39)] 
		[RED("currentArmorLabelAnimation")] 
		public CHandle<inkanimProxy> CurrentArmorLabelAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(40)] 
		[RED("costArmorLabelAnimation")] 
		public CHandle<inkanimProxy> CostArmorLabelAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("currentArmorLabelPulseAnimation")] 
		public CHandle<PulseAnimation> CurrentArmorLabelPulseAnimation
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(42)] 
		[RED("costArmorLabelPulseAnimation")] 
		public CHandle<PulseAnimation> CostArmorLabelPulseAnimation
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(43)] 
		[RED("maxBaseBar")] 
		public CInt32 MaxBaseBar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(44)] 
		[RED("currentBars")] 
		public CInt32 CurrentBars
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("barsSpawned")] 
		public CBool BarsSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("C_costLabelAnchorPoint_ADD")] 
		public Vector2 C_costLabelAnchorPoint_ADD
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(47)] 
		[RED("C_costLabelAnchorPoint_SUBTRACT")] 
		public Vector2 C_costLabelAnchorPoint_SUBTRACT
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(48)] 
		[RED("C_costLabelAnchorPoint_EQUIPPED")] 
		public Vector2 C_costLabelAnchorPoint_EQUIPPED
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public RipperdocMetersArmor()
		{
			BarWidgetLibraryName = "ArmorMeterBar";
			SlopeLengthModifier = 0.250000F;
			BarsHeigh = 9.000000F;
			BarsMargin = 9.000000F;
			BarScale = 2.500000F;
			CurrentArmorLabelContainer = new inkWidgetReference();
			CurrentArmorLabelBackground = new inkWidgetReference();
			CostArmorLabelContainer = new inkWidgetReference();
			CostArmorLabelBackground = new inkWidgetReference();
			CostArmorLabelValue = new inkTextWidgetReference();
			MaxArmorLabel = new inkWidgetReference();
			MaxArmorLabelContainer = new inkWidgetReference();
			MaxArmorLabelValue = new inkTextWidgetReference();
			C_costLabelAnchorPoint_ADD = new Vector2();
			C_costLabelAnchorPoint_SUBTRACT = new Vector2();
			C_costLabelAnchorPoint_EQUIPPED = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
