using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickhacksListItemController : inkListItemController
	{
		private CFloat _expandAnimationDuration;
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _memoryValue;
		private inkCompoundWidgetReference _memoryCells;
		private inkWidgetReference _actionStateRoot;
		private inkTextWidgetReference _actionStateText;
		private inkWidgetReference _cooldownIcon;
		private inkTextWidgetReference _cooldownValue;
		private inkWidgetReference _descriptionSize;
		private inkWidgetReference _costReductionArrow;
		private CFloat _curveRadius;
		private CHandle<inkanimProxy> _selectedLoop;
		private CName _currentAnimationName;
		private CHandle<inkanimProxy> _choiceAccepted;
		private CHandle<inkanimController> _resizeAnim;
		private CWeakHandle<inkWidget> _root;
		private CHandle<QuickhackData> _data;
		private CBool _isSelected;
		private CBool _expanded;
		private Vector2 _cachedDescriptionSize;
		private inkMargin _defaultMargin;

		[Ordinal(16)] 
		[RED("expandAnimationDuration")] 
		public CFloat ExpandAnimationDuration
		{
			get => GetProperty(ref _expandAnimationDuration);
			set => SetProperty(ref _expandAnimationDuration, value);
		}

		[Ordinal(17)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(18)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(19)] 
		[RED("memoryValue")] 
		public inkTextWidgetReference MemoryValue
		{
			get => GetProperty(ref _memoryValue);
			set => SetProperty(ref _memoryValue, value);
		}

		[Ordinal(20)] 
		[RED("memoryCells")] 
		public inkCompoundWidgetReference MemoryCells
		{
			get => GetProperty(ref _memoryCells);
			set => SetProperty(ref _memoryCells, value);
		}

		[Ordinal(21)] 
		[RED("actionStateRoot")] 
		public inkWidgetReference ActionStateRoot
		{
			get => GetProperty(ref _actionStateRoot);
			set => SetProperty(ref _actionStateRoot, value);
		}

		[Ordinal(22)] 
		[RED("actionStateText")] 
		public inkTextWidgetReference ActionStateText
		{
			get => GetProperty(ref _actionStateText);
			set => SetProperty(ref _actionStateText, value);
		}

		[Ordinal(23)] 
		[RED("cooldownIcon")] 
		public inkWidgetReference CooldownIcon
		{
			get => GetProperty(ref _cooldownIcon);
			set => SetProperty(ref _cooldownIcon, value);
		}

		[Ordinal(24)] 
		[RED("cooldownValue")] 
		public inkTextWidgetReference CooldownValue
		{
			get => GetProperty(ref _cooldownValue);
			set => SetProperty(ref _cooldownValue, value);
		}

		[Ordinal(25)] 
		[RED("descriptionSize")] 
		public inkWidgetReference DescriptionSize
		{
			get => GetProperty(ref _descriptionSize);
			set => SetProperty(ref _descriptionSize, value);
		}

		[Ordinal(26)] 
		[RED("costReductionArrow")] 
		public inkWidgetReference CostReductionArrow
		{
			get => GetProperty(ref _costReductionArrow);
			set => SetProperty(ref _costReductionArrow, value);
		}

		[Ordinal(27)] 
		[RED("curveRadius")] 
		public CFloat CurveRadius
		{
			get => GetProperty(ref _curveRadius);
			set => SetProperty(ref _curveRadius, value);
		}

		[Ordinal(28)] 
		[RED("selectedLoop")] 
		public CHandle<inkanimProxy> SelectedLoop
		{
			get => GetProperty(ref _selectedLoop);
			set => SetProperty(ref _selectedLoop, value);
		}

		[Ordinal(29)] 
		[RED("currentAnimationName")] 
		public CName CurrentAnimationName
		{
			get => GetProperty(ref _currentAnimationName);
			set => SetProperty(ref _currentAnimationName, value);
		}

		[Ordinal(30)] 
		[RED("choiceAccepted")] 
		public CHandle<inkanimProxy> ChoiceAccepted
		{
			get => GetProperty(ref _choiceAccepted);
			set => SetProperty(ref _choiceAccepted, value);
		}

		[Ordinal(31)] 
		[RED("resizeAnim")] 
		public CHandle<inkanimController> ResizeAnim
		{
			get => GetProperty(ref _resizeAnim);
			set => SetProperty(ref _resizeAnim, value);
		}

		[Ordinal(32)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(33)] 
		[RED("data")] 
		public CHandle<QuickhackData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(34)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(35)] 
		[RED("expanded")] 
		public CBool Expanded
		{
			get => GetProperty(ref _expanded);
			set => SetProperty(ref _expanded, value);
		}

		[Ordinal(36)] 
		[RED("cachedDescriptionSize")] 
		public Vector2 CachedDescriptionSize
		{
			get => GetProperty(ref _cachedDescriptionSize);
			set => SetProperty(ref _cachedDescriptionSize, value);
		}

		[Ordinal(37)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get => GetProperty(ref _defaultMargin);
			set => SetProperty(ref _defaultMargin, value);
		}

		public QuickhacksListItemController()
		{
			_expandAnimationDuration = 0.200000F;
		}
	}
}
