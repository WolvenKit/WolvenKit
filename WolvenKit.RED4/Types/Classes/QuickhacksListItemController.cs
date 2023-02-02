using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickhacksListItemController : inkListItemController
	{
		[Ordinal(16)] 
		[RED("expandAnimationDuration")] 
		public CFloat ExpandAnimationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("memoryValue")] 
		public inkTextWidgetReference MemoryValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("memoryCells")] 
		public inkCompoundWidgetReference MemoryCells
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("actionStateRoot")] 
		public inkWidgetReference ActionStateRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("actionStateText")] 
		public inkTextWidgetReference ActionStateText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("cooldownIcon")] 
		public inkWidgetReference CooldownIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("cooldownValue")] 
		public inkTextWidgetReference CooldownValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("descriptionSize")] 
		public inkWidgetReference DescriptionSize
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("costReductionArrow")] 
		public inkWidgetReference CostReductionArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("curveRadius")] 
		public CFloat CurveRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("selectedLoop")] 
		public CHandle<inkanimProxy> SelectedLoop
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("currentAnimationName")] 
		public CName CurrentAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("choiceAccepted")] 
		public CHandle<inkanimProxy> ChoiceAccepted
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("resizeAnim")] 
		public CHandle<inkanimController> ResizeAnim
		{
			get => GetPropertyValue<CHandle<inkanimController>>();
			set => SetPropertyValue<CHandle<inkanimController>>(value);
		}

		[Ordinal(32)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(33)] 
		[RED("data")] 
		public CHandle<QuickhackData> Data
		{
			get => GetPropertyValue<CHandle<QuickhackData>>();
			set => SetPropertyValue<CHandle<QuickhackData>>(value);
		}

		[Ordinal(34)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("expanded")] 
		public CBool Expanded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("cachedDescriptionSize")] 
		public Vector2 CachedDescriptionSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(37)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public QuickhacksListItemController()
		{
			ExpandAnimationDuration = 0.200000F;
			Icon = new();
			Description = new();
			MemoryValue = new();
			MemoryCells = new();
			ActionStateRoot = new();
			ActionStateText = new();
			CooldownIcon = new();
			CooldownValue = new();
			DescriptionSize = new();
			CostReductionArrow = new();
			CachedDescriptionSize = new();
			DefaultMargin = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
