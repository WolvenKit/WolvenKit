using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuItemController : inkWidgetLogicController
	{
		private MenuData _menuData;
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _frameHovered;
		private inkWidgetReference _hoverPanel;
		private inkWidgetReference _background;
		private inkWidgetReference _levelFlag;
		private inkWidgetReference _attrFlag;
		private inkTextWidgetReference _attrText;
		private inkWidgetReference _perkFlag;
		private inkTextWidgetReference _perkText;
		private CBool _itemHovered;
		private CBool _panelHovered;
		private CHandle<inkanimProxy> _panelTransitionProxy;
		private CHandle<inkanimProxy> _buttonTransitionProxy;
		private CBool _isPanelShown;
		private CBool _isDimmed;
		private CBool _isHyperlink;

		[Ordinal(1)] 
		[RED("menuData")] 
		public MenuData MenuData
		{
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(4)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get => GetProperty(ref _frameHovered);
			set => SetProperty(ref _frameHovered, value);
		}

		[Ordinal(5)] 
		[RED("hoverPanel")] 
		public inkWidgetReference HoverPanel
		{
			get => GetProperty(ref _hoverPanel);
			set => SetProperty(ref _hoverPanel, value);
		}

		[Ordinal(6)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(7)] 
		[RED("levelFlag")] 
		public inkWidgetReference LevelFlag
		{
			get => GetProperty(ref _levelFlag);
			set => SetProperty(ref _levelFlag, value);
		}

		[Ordinal(8)] 
		[RED("attrFlag")] 
		public inkWidgetReference AttrFlag
		{
			get => GetProperty(ref _attrFlag);
			set => SetProperty(ref _attrFlag, value);
		}

		[Ordinal(9)] 
		[RED("attrText")] 
		public inkTextWidgetReference AttrText
		{
			get => GetProperty(ref _attrText);
			set => SetProperty(ref _attrText, value);
		}

		[Ordinal(10)] 
		[RED("perkFlag")] 
		public inkWidgetReference PerkFlag
		{
			get => GetProperty(ref _perkFlag);
			set => SetProperty(ref _perkFlag, value);
		}

		[Ordinal(11)] 
		[RED("perkText")] 
		public inkTextWidgetReference PerkText
		{
			get => GetProperty(ref _perkText);
			set => SetProperty(ref _perkText, value);
		}

		[Ordinal(12)] 
		[RED("itemHovered")] 
		public CBool ItemHovered
		{
			get => GetProperty(ref _itemHovered);
			set => SetProperty(ref _itemHovered, value);
		}

		[Ordinal(13)] 
		[RED("panelHovered")] 
		public CBool PanelHovered
		{
			get => GetProperty(ref _panelHovered);
			set => SetProperty(ref _panelHovered, value);
		}

		[Ordinal(14)] 
		[RED("panelTransitionProxy")] 
		public CHandle<inkanimProxy> PanelTransitionProxy
		{
			get => GetProperty(ref _panelTransitionProxy);
			set => SetProperty(ref _panelTransitionProxy, value);
		}

		[Ordinal(15)] 
		[RED("buttonTransitionProxy")] 
		public CHandle<inkanimProxy> ButtonTransitionProxy
		{
			get => GetProperty(ref _buttonTransitionProxy);
			set => SetProperty(ref _buttonTransitionProxy, value);
		}

		[Ordinal(16)] 
		[RED("isPanelShown")] 
		public CBool IsPanelShown
		{
			get => GetProperty(ref _isPanelShown);
			set => SetProperty(ref _isPanelShown, value);
		}

		[Ordinal(17)] 
		[RED("isDimmed")] 
		public CBool IsDimmed
		{
			get => GetProperty(ref _isDimmed);
			set => SetProperty(ref _isDimmed, value);
		}

		[Ordinal(18)] 
		[RED("isHyperlink")] 
		public CBool IsHyperlink
		{
			get => GetProperty(ref _isHyperlink);
			set => SetProperty(ref _isHyperlink, value);
		}
	}
}
