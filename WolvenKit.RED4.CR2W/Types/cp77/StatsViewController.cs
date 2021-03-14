using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsViewController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statLabelRef;
		private inkTextWidgetReference _statValueRef;
		private inkImageWidgetReference _icon;
		private gameStatViewData _stat;
		private wCHandle<inkButtonController> _buttonConctroller;

		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get
			{
				if (_statLabelRef == null)
				{
					_statLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "StatLabelRef", cr2w, this);
				}
				return _statLabelRef;
			}
			set
			{
				if (_statLabelRef == value)
				{
					return;
				}
				_statLabelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("StatValueRef")] 
		public inkTextWidgetReference StatValueRef
		{
			get
			{
				if (_statValueRef == null)
				{
					_statValueRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "StatValueRef", cr2w, this);
				}
				return _statValueRef;
			}
			set
			{
				if (_statValueRef == value)
				{
					return;
				}
				_statValueRef = value;
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
		[RED("stat")] 
		public gameStatViewData Stat
		{
			get
			{
				if (_stat == null)
				{
					_stat = (gameStatViewData) CR2WTypeManager.Create("gameStatViewData", "stat", cr2w, this);
				}
				return _stat;
			}
			set
			{
				if (_stat == value)
				{
					return;
				}
				_stat = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("buttonConctroller")] 
		public wCHandle<inkButtonController> ButtonConctroller
		{
			get
			{
				if (_buttonConctroller == null)
				{
					_buttonConctroller = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "buttonConctroller", cr2w, this);
				}
				return _buttonConctroller;
			}
			set
			{
				if (_buttonConctroller == value)
				{
					return;
				}
				_buttonConctroller = value;
				PropertySet(this);
			}
		}

		public StatsViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
