using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneContactItemVirtualController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _msgCount;
		private inkWidgetReference _msgIndicator;
		private inkWidgetReference _questFlag;
		private inkWidgetReference _regFlag;
		private CHandle<inkanimProxy> _animProxyQuest;
		private CHandle<inkanimProxy> _animProxySelection;
		private CHandle<ContactData> _contactData;

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("msgCount")] 
		public inkTextWidgetReference MsgCount
		{
			get
			{
				if (_msgCount == null)
				{
					_msgCount = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "msgCount", cr2w, this);
				}
				return _msgCount;
			}
			set
			{
				if (_msgCount == value)
				{
					return;
				}
				_msgCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get
			{
				if (_msgIndicator == null)
				{
					_msgIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "msgIndicator", cr2w, this);
				}
				return _msgIndicator;
			}
			set
			{
				if (_msgIndicator == value)
				{
					return;
				}
				_msgIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("questFlag")] 
		public inkWidgetReference QuestFlag
		{
			get
			{
				if (_questFlag == null)
				{
					_questFlag = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "questFlag", cr2w, this);
				}
				return _questFlag;
			}
			set
			{
				if (_questFlag == value)
				{
					return;
				}
				_questFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("regFlag")] 
		public inkWidgetReference RegFlag
		{
			get
			{
				if (_regFlag == null)
				{
					_regFlag = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "regFlag", cr2w, this);
				}
				return _regFlag;
			}
			set
			{
				if (_regFlag == value)
				{
					return;
				}
				_regFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animProxyQuest")] 
		public CHandle<inkanimProxy> AnimProxyQuest
		{
			get
			{
				if (_animProxyQuest == null)
				{
					_animProxyQuest = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxyQuest", cr2w, this);
				}
				return _animProxyQuest;
			}
			set
			{
				if (_animProxyQuest == value)
				{
					return;
				}
				_animProxyQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("animProxySelection")] 
		public CHandle<inkanimProxy> AnimProxySelection
		{
			get
			{
				if (_animProxySelection == null)
				{
					_animProxySelection = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxySelection", cr2w, this);
				}
				return _animProxySelection;
			}
			set
			{
				if (_animProxySelection == value)
				{
					return;
				}
				_animProxySelection = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get
			{
				if (_contactData == null)
				{
					_contactData = (CHandle<ContactData>) CR2WTypeManager.Create("handle:ContactData", "contactData", cr2w, this);
				}
				return _contactData;
			}
			set
			{
				if (_contactData == value)
				{
					return;
				}
				_contactData = value;
				PropertySet(this);
			}
		}

		public PhoneContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
