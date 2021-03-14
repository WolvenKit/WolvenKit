using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinBaseController : inkWidgetLogicController
	{
		private inkImageWidgetReference _iconWidget;
		private inkWidgetReference _playerTrackedWidget;
		private inkWidgetReference _scaleWidget;
		private inkWidgetReference _animPlayerTrackedWidget;
		private inkWidgetReference _animPlayerAboveBelowWidget;
		private CArray<inkWidgetReference> _taggedWidgets;

		[Ordinal(1)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get
			{
				if (_iconWidget == null)
				{
					_iconWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconWidget", cr2w, this);
				}
				return _iconWidget;
			}
			set
			{
				if (_iconWidget == value)
				{
					return;
				}
				_iconWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playerTrackedWidget")] 
		public inkWidgetReference PlayerTrackedWidget
		{
			get
			{
				if (_playerTrackedWidget == null)
				{
					_playerTrackedWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerTrackedWidget", cr2w, this);
				}
				return _playerTrackedWidget;
			}
			set
			{
				if (_playerTrackedWidget == value)
				{
					return;
				}
				_playerTrackedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scaleWidget")] 
		public inkWidgetReference ScaleWidget
		{
			get
			{
				if (_scaleWidget == null)
				{
					_scaleWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scaleWidget", cr2w, this);
				}
				return _scaleWidget;
			}
			set
			{
				if (_scaleWidget == value)
				{
					return;
				}
				_scaleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animPlayerTrackedWidget")] 
		public inkWidgetReference AnimPlayerTrackedWidget
		{
			get
			{
				if (_animPlayerTrackedWidget == null)
				{
					_animPlayerTrackedWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animPlayerTrackedWidget", cr2w, this);
				}
				return _animPlayerTrackedWidget;
			}
			set
			{
				if (_animPlayerTrackedWidget == value)
				{
					return;
				}
				_animPlayerTrackedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animPlayerAboveBelowWidget")] 
		public inkWidgetReference AnimPlayerAboveBelowWidget
		{
			get
			{
				if (_animPlayerAboveBelowWidget == null)
				{
					_animPlayerAboveBelowWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animPlayerAboveBelowWidget", cr2w, this);
				}
				return _animPlayerAboveBelowWidget;
			}
			set
			{
				if (_animPlayerAboveBelowWidget == value)
				{
					return;
				}
				_animPlayerAboveBelowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("taggedWidgets")] 
		public CArray<inkWidgetReference> TaggedWidgets
		{
			get
			{
				if (_taggedWidgets == null)
				{
					_taggedWidgets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "taggedWidgets", cr2w, this);
				}
				return _taggedWidgets;
			}
			set
			{
				if (_taggedWidgets == value)
				{
					return;
				}
				_taggedWidgets = value;
				PropertySet(this);
			}
		}

		public gameuiMappinBaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
