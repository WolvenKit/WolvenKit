using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkMenuTooltipController : AGenericTooltipController
	{
		private inkWidgetReference _titleContainer;
		private inkTextWidgetReference _titleText;
		private inkWidgetReference _typeContainer;
		private inkTextWidgetReference _typeText;
		private inkWidgetReference _desc1Container;
		private inkTextWidgetReference _desc1Text;
		private inkWidgetReference _desc2Container;
		private inkTextWidgetReference _desc2Text;
		private inkTextWidgetReference _desc2TextNextLevel;
		private inkTextWidgetReference _desc2TextNextLevelDesc;
		private inkWidgetReference _holdToUpgrade;
		private inkWidgetReference _openPerkScreen;
		private inkWidgetReference _videoContainerWidget;
		private inkVideoWidgetReference _videoWidget;
		private CHandle<BasePerksMenuTooltipData> _data;
		private CInt32 _maxProficiencyLevel;

		[Ordinal(2)] 
		[RED("titleContainer")] 
		public inkWidgetReference TitleContainer
		{
			get
			{
				if (_titleContainer == null)
				{
					_titleContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "titleContainer", cr2w, this);
				}
				return _titleContainer;
			}
			set
			{
				if (_titleContainer == value)
				{
					return;
				}
				_titleContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get
			{
				if (_titleText == null)
				{
					_titleText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleText", cr2w, this);
				}
				return _titleText;
			}
			set
			{
				if (_titleText == value)
				{
					return;
				}
				_titleText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("typeContainer")] 
		public inkWidgetReference TypeContainer
		{
			get
			{
				if (_typeContainer == null)
				{
					_typeContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "typeContainer", cr2w, this);
				}
				return _typeContainer;
			}
			set
			{
				if (_typeContainer == value)
				{
					return;
				}
				_typeContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("typeText")] 
		public inkTextWidgetReference TypeText
		{
			get
			{
				if (_typeText == null)
				{
					_typeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "typeText", cr2w, this);
				}
				return _typeText;
			}
			set
			{
				if (_typeText == value)
				{
					return;
				}
				_typeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("desc1Container")] 
		public inkWidgetReference Desc1Container
		{
			get
			{
				if (_desc1Container == null)
				{
					_desc1Container = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "desc1Container", cr2w, this);
				}
				return _desc1Container;
			}
			set
			{
				if (_desc1Container == value)
				{
					return;
				}
				_desc1Container = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("desc1Text")] 
		public inkTextWidgetReference Desc1Text
		{
			get
			{
				if (_desc1Text == null)
				{
					_desc1Text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc1Text", cr2w, this);
				}
				return _desc1Text;
			}
			set
			{
				if (_desc1Text == value)
				{
					return;
				}
				_desc1Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("desc2Container")] 
		public inkWidgetReference Desc2Container
		{
			get
			{
				if (_desc2Container == null)
				{
					_desc2Container = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "desc2Container", cr2w, this);
				}
				return _desc2Container;
			}
			set
			{
				if (_desc2Container == value)
				{
					return;
				}
				_desc2Container = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("desc2Text")] 
		public inkTextWidgetReference Desc2Text
		{
			get
			{
				if (_desc2Text == null)
				{
					_desc2Text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc2Text", cr2w, this);
				}
				return _desc2Text;
			}
			set
			{
				if (_desc2Text == value)
				{
					return;
				}
				_desc2Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("desc2TextNextLevel")] 
		public inkTextWidgetReference Desc2TextNextLevel
		{
			get
			{
				if (_desc2TextNextLevel == null)
				{
					_desc2TextNextLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc2TextNextLevel", cr2w, this);
				}
				return _desc2TextNextLevel;
			}
			set
			{
				if (_desc2TextNextLevel == value)
				{
					return;
				}
				_desc2TextNextLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("desc2TextNextLevelDesc")] 
		public inkTextWidgetReference Desc2TextNextLevelDesc
		{
			get
			{
				if (_desc2TextNextLevelDesc == null)
				{
					_desc2TextNextLevelDesc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc2TextNextLevelDesc", cr2w, this);
				}
				return _desc2TextNextLevelDesc;
			}
			set
			{
				if (_desc2TextNextLevelDesc == value)
				{
					return;
				}
				_desc2TextNextLevelDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("holdToUpgrade")] 
		public inkWidgetReference HoldToUpgrade
		{
			get
			{
				if (_holdToUpgrade == null)
				{
					_holdToUpgrade = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "holdToUpgrade", cr2w, this);
				}
				return _holdToUpgrade;
			}
			set
			{
				if (_holdToUpgrade == value)
				{
					return;
				}
				_holdToUpgrade = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("openPerkScreen")] 
		public inkWidgetReference OpenPerkScreen
		{
			get
			{
				if (_openPerkScreen == null)
				{
					_openPerkScreen = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "openPerkScreen", cr2w, this);
				}
				return _openPerkScreen;
			}
			set
			{
				if (_openPerkScreen == value)
				{
					return;
				}
				_openPerkScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("videoContainerWidget")] 
		public inkWidgetReference VideoContainerWidget
		{
			get
			{
				if (_videoContainerWidget == null)
				{
					_videoContainerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "videoContainerWidget", cr2w, this);
				}
				return _videoContainerWidget;
			}
			set
			{
				if (_videoContainerWidget == value)
				{
					return;
				}
				_videoContainerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get
			{
				if (_videoWidget == null)
				{
					_videoWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoWidget", cr2w, this);
				}
				return _videoWidget;
			}
			set
			{
				if (_videoWidget == value)
				{
					return;
				}
				_videoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<BasePerksMenuTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<BasePerksMenuTooltipData>) CR2WTypeManager.Create("handle:BasePerksMenuTooltipData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("maxProficiencyLevel")] 
		public CInt32 MaxProficiencyLevel
		{
			get
			{
				if (_maxProficiencyLevel == null)
				{
					_maxProficiencyLevel = (CInt32) CR2WTypeManager.Create("Int32", "maxProficiencyLevel", cr2w, this);
				}
				return _maxProficiencyLevel;
			}
			set
			{
				if (_maxProficiencyLevel == value)
				{
					return;
				}
				_maxProficiencyLevel = value;
				PropertySet(this);
			}
		}

		public PerkMenuTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
