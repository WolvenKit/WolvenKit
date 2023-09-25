using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialMenuItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("menuData")] 
		public MenuData MenuData
		{
			get => GetPropertyValue<MenuData>();
			set => SetPropertyValue<MenuData>(value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("hoverPanel")] 
		public inkWidgetReference HoverPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("levelFlag")] 
		public inkWidgetReference LevelFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("attrFlag")] 
		public inkWidgetReference AttrFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("attrText")] 
		public inkTextWidgetReference AttrText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("perkFlag")] 
		public inkWidgetReference PerkFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("perkText")] 
		public inkTextWidgetReference PerkText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("queueHoverEvents")] 
		public CBool QueueHoverEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("disableClick")] 
		public CBool DisableClick
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("applyHoverState")] 
		public CBool ApplyHoverState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("itemHovered")] 
		public CBool ItemHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("panelHovered")] 
		public CBool PanelHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("panelTransitionProxy")] 
		public CHandle<inkanimProxy> PanelTransitionProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("buttonTransitionProxy")] 
		public CHandle<inkanimProxy> ButtonTransitionProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("isPanelShown")] 
		public CBool IsPanelShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("isDimmed")] 
		public CBool IsDimmed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("isHyperlink")] 
		public CBool IsHyperlink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RadialMenuItemController()
		{
			MenuData = new MenuData { Identifier = -1, SubMenus = new() };
			Label = new inkTextWidgetReference();
			Icon = new inkImageWidgetReference();
			FrameHovered = new inkWidgetReference();
			HoverPanel = new inkWidgetReference();
			Background = new inkWidgetReference();
			LevelFlag = new inkWidgetReference();
			AttrFlag = new inkWidgetReference();
			AttrText = new inkTextWidgetReference();
			PerkFlag = new inkWidgetReference();
			PerkText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
