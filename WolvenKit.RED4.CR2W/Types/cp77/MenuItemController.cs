using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuItemController : inkWidgetLogicController
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
			get
			{
				if (_menuData == null)
				{
					_menuData = (MenuData) CR2WTypeManager.Create("MenuData", "menuData", cr2w, this);
				}
				return _menuData;
			}
			set
			{
				if (_menuData == value)
				{
					return;
				}
				_menuData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get
			{
				if (_frameHovered == null)
				{
					_frameHovered = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "frameHovered", cr2w, this);
				}
				return _frameHovered;
			}
			set
			{
				if (_frameHovered == value)
				{
					return;
				}
				_frameHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hoverPanel")] 
		public inkWidgetReference HoverPanel
		{
			get
			{
				if (_hoverPanel == null)
				{
					_hoverPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hoverPanel", cr2w, this);
				}
				return _hoverPanel;
			}
			set
			{
				if (_hoverPanel == value)
				{
					return;
				}
				_hoverPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("levelFlag")] 
		public inkWidgetReference LevelFlag
		{
			get
			{
				if (_levelFlag == null)
				{
					_levelFlag = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelFlag", cr2w, this);
				}
				return _levelFlag;
			}
			set
			{
				if (_levelFlag == value)
				{
					return;
				}
				_levelFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("attrFlag")] 
		public inkWidgetReference AttrFlag
		{
			get
			{
				if (_attrFlag == null)
				{
					_attrFlag = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attrFlag", cr2w, this);
				}
				return _attrFlag;
			}
			set
			{
				if (_attrFlag == value)
				{
					return;
				}
				_attrFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attrText")] 
		public inkTextWidgetReference AttrText
		{
			get
			{
				if (_attrText == null)
				{
					_attrText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attrText", cr2w, this);
				}
				return _attrText;
			}
			set
			{
				if (_attrText == value)
				{
					return;
				}
				_attrText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("perkFlag")] 
		public inkWidgetReference PerkFlag
		{
			get
			{
				if (_perkFlag == null)
				{
					_perkFlag = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "perkFlag", cr2w, this);
				}
				return _perkFlag;
			}
			set
			{
				if (_perkFlag == value)
				{
					return;
				}
				_perkFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("perkText")] 
		public inkTextWidgetReference PerkText
		{
			get
			{
				if (_perkText == null)
				{
					_perkText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "perkText", cr2w, this);
				}
				return _perkText;
			}
			set
			{
				if (_perkText == value)
				{
					return;
				}
				_perkText = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("itemHovered")] 
		public CBool ItemHovered
		{
			get
			{
				if (_itemHovered == null)
				{
					_itemHovered = (CBool) CR2WTypeManager.Create("Bool", "itemHovered", cr2w, this);
				}
				return _itemHovered;
			}
			set
			{
				if (_itemHovered == value)
				{
					return;
				}
				_itemHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("panelHovered")] 
		public CBool PanelHovered
		{
			get
			{
				if (_panelHovered == null)
				{
					_panelHovered = (CBool) CR2WTypeManager.Create("Bool", "panelHovered", cr2w, this);
				}
				return _panelHovered;
			}
			set
			{
				if (_panelHovered == value)
				{
					return;
				}
				_panelHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("panelTransitionProxy")] 
		public CHandle<inkanimProxy> PanelTransitionProxy
		{
			get
			{
				if (_panelTransitionProxy == null)
				{
					_panelTransitionProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "panelTransitionProxy", cr2w, this);
				}
				return _panelTransitionProxy;
			}
			set
			{
				if (_panelTransitionProxy == value)
				{
					return;
				}
				_panelTransitionProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("buttonTransitionProxy")] 
		public CHandle<inkanimProxy> ButtonTransitionProxy
		{
			get
			{
				if (_buttonTransitionProxy == null)
				{
					_buttonTransitionProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "buttonTransitionProxy", cr2w, this);
				}
				return _buttonTransitionProxy;
			}
			set
			{
				if (_buttonTransitionProxy == value)
				{
					return;
				}
				_buttonTransitionProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isPanelShown")] 
		public CBool IsPanelShown
		{
			get
			{
				if (_isPanelShown == null)
				{
					_isPanelShown = (CBool) CR2WTypeManager.Create("Bool", "isPanelShown", cr2w, this);
				}
				return _isPanelShown;
			}
			set
			{
				if (_isPanelShown == value)
				{
					return;
				}
				_isPanelShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isDimmed")] 
		public CBool IsDimmed
		{
			get
			{
				if (_isDimmed == null)
				{
					_isDimmed = (CBool) CR2WTypeManager.Create("Bool", "isDimmed", cr2w, this);
				}
				return _isDimmed;
			}
			set
			{
				if (_isDimmed == value)
				{
					return;
				}
				_isDimmed = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isHyperlink")] 
		public CBool IsHyperlink
		{
			get
			{
				if (_isHyperlink == null)
				{
					_isHyperlink = (CBool) CR2WTypeManager.Create("Bool", "isHyperlink", cr2w, this);
				}
				return _isHyperlink;
			}
			set
			{
				if (_isHyperlink == value)
				{
					return;
				}
				_isHyperlink = value;
				PropertySet(this);
			}
		}

		public MenuItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
