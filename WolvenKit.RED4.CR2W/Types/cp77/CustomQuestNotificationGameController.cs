using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomQuestNotificationGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _desc;
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _fluffHeader;
		private CHandle<inkWidget> _root;
		private CHandle<CustomQuestNotificationUserData> _data;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get
			{
				if (_desc == null)
				{
					_desc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc", cr2w, this);
				}
				return _desc;
			}
			set
			{
				if (_desc == value)
				{
					return;
				}
				_desc = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("fluffHeader")] 
		public inkTextWidgetReference FluffHeader
		{
			get
			{
				if (_fluffHeader == null)
				{
					_fluffHeader = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffHeader", cr2w, this);
				}
				return _fluffHeader;
			}
			set
			{
				if (_fluffHeader == value)
				{
					return;
				}
				_fluffHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("data")] 
		public CHandle<CustomQuestNotificationUserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<CustomQuestNotificationUserData>) CR2WTypeManager.Create("handle:CustomQuestNotificationUserData", "data", cr2w, this);
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

		[Ordinal(15)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		public CustomQuestNotificationGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
