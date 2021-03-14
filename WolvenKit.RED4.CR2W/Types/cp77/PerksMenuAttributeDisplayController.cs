using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeDisplayController : BaseButtonView
	{
		private inkWidgetReference _widgetWrapper;
		private inkWidgetReference _foregroundWrapper;
		private inkWidgetReference _johnnyWrapper;
		private inkTextWidgetReference _attributeName;
		private inkImageWidgetReference _attributeIcon;
		private inkTextWidgetReference _attributeLevel;
		private inkWidgetReference _frameHovered;
		private inkWidgetReference _accent1Hovered;
		private inkWidgetReference _accent1BGHovered;
		private inkWidgetReference _accent2Hovered;
		private inkWidgetReference _accent2BGHovered;
		private inkWidgetReference _topConnectionContainer;
		private inkWidgetReference _bottomConnectionContainer;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CEnum<PerkMenuAttribute> _attribute;
		private CHandle<AttributeData> _attributeData;

		[Ordinal(2)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get
			{
				if (_widgetWrapper == null)
				{
					_widgetWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetWrapper", cr2w, this);
				}
				return _widgetWrapper;
			}
			set
			{
				if (_widgetWrapper == value)
				{
					return;
				}
				_widgetWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("foregroundWrapper")] 
		public inkWidgetReference ForegroundWrapper
		{
			get
			{
				if (_foregroundWrapper == null)
				{
					_foregroundWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "foregroundWrapper", cr2w, this);
				}
				return _foregroundWrapper;
			}
			set
			{
				if (_foregroundWrapper == value)
				{
					return;
				}
				_foregroundWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("johnnyWrapper")] 
		public inkWidgetReference JohnnyWrapper
		{
			get
			{
				if (_johnnyWrapper == null)
				{
					_johnnyWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "johnnyWrapper", cr2w, this);
				}
				return _johnnyWrapper;
			}
			set
			{
				if (_johnnyWrapper == value)
				{
					return;
				}
				_johnnyWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attributeName")] 
		public inkTextWidgetReference AttributeName
		{
			get
			{
				if (_attributeName == null)
				{
					_attributeName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeName", cr2w, this);
				}
				return _attributeName;
			}
			set
			{
				if (_attributeName == value)
				{
					return;
				}
				_attributeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("attributeIcon")] 
		public inkImageWidgetReference AttributeIcon
		{
			get
			{
				if (_attributeIcon == null)
				{
					_attributeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "attributeIcon", cr2w, this);
				}
				return _attributeIcon;
			}
			set
			{
				if (_attributeIcon == value)
				{
					return;
				}
				_attributeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attributeLevel")] 
		public inkTextWidgetReference AttributeLevel
		{
			get
			{
				if (_attributeLevel == null)
				{
					_attributeLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeLevel", cr2w, this);
				}
				return _attributeLevel;
			}
			set
			{
				if (_attributeLevel == value)
				{
					return;
				}
				_attributeLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("accent1Hovered")] 
		public inkWidgetReference Accent1Hovered
		{
			get
			{
				if (_accent1Hovered == null)
				{
					_accent1Hovered = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "accent1Hovered", cr2w, this);
				}
				return _accent1Hovered;
			}
			set
			{
				if (_accent1Hovered == value)
				{
					return;
				}
				_accent1Hovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("accent1BGHovered")] 
		public inkWidgetReference Accent1BGHovered
		{
			get
			{
				if (_accent1BGHovered == null)
				{
					_accent1BGHovered = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "accent1BGHovered", cr2w, this);
				}
				return _accent1BGHovered;
			}
			set
			{
				if (_accent1BGHovered == value)
				{
					return;
				}
				_accent1BGHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("accent2Hovered")] 
		public inkWidgetReference Accent2Hovered
		{
			get
			{
				if (_accent2Hovered == null)
				{
					_accent2Hovered = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "accent2Hovered", cr2w, this);
				}
				return _accent2Hovered;
			}
			set
			{
				if (_accent2Hovered == value)
				{
					return;
				}
				_accent2Hovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("accent2BGHovered")] 
		public inkWidgetReference Accent2BGHovered
		{
			get
			{
				if (_accent2BGHovered == null)
				{
					_accent2BGHovered = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "accent2BGHovered", cr2w, this);
				}
				return _accent2BGHovered;
			}
			set
			{
				if (_accent2BGHovered == value)
				{
					return;
				}
				_accent2BGHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("topConnectionContainer")] 
		public inkWidgetReference TopConnectionContainer
		{
			get
			{
				if (_topConnectionContainer == null)
				{
					_topConnectionContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "topConnectionContainer", cr2w, this);
				}
				return _topConnectionContainer;
			}
			set
			{
				if (_topConnectionContainer == value)
				{
					return;
				}
				_topConnectionContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bottomConnectionContainer")] 
		public inkWidgetReference BottomConnectionContainer
		{
			get
			{
				if (_bottomConnectionContainer == null)
				{
					_bottomConnectionContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bottomConnectionContainer", cr2w, this);
				}
				return _bottomConnectionContainer;
			}
			set
			{
				if (_bottomConnectionContainer == value)
				{
					return;
				}
				_bottomConnectionContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<PlayerDevelopmentDataManager>) CR2WTypeManager.Create("handle:PlayerDevelopmentDataManager", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("attribute")] 
		public CEnum<PerkMenuAttribute> Attribute
		{
			get
			{
				if (_attribute == null)
				{
					_attribute = (CEnum<PerkMenuAttribute>) CR2WTypeManager.Create("PerkMenuAttribute", "attribute", cr2w, this);
				}
				return _attribute;
			}
			set
			{
				if (_attribute == value)
				{
					return;
				}
				_attribute = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get
			{
				if (_attributeData == null)
				{
					_attributeData = (CHandle<AttributeData>) CR2WTypeManager.Create("handle:AttributeData", "attributeData", cr2w, this);
				}
				return _attributeData;
			}
			set
			{
				if (_attributeData == value)
				{
					return;
				}
				_attributeData = value;
				PropertySet(this);
			}
		}

		public PerksMenuAttributeDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
