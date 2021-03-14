using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsStartTakedownEvent : redEvent
	{
		private wCHandle<gameObject> _target;
		private CFloat _slideTime;
		private CName _actionName;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slideTime")] 
		public CFloat SlideTime
		{
			get
			{
				if (_slideTime == null)
				{
					_slideTime = (CFloat) CR2WTypeManager.Create("Float", "slideTime", cr2w, this);
				}
				return _slideTime;
			}
			set
			{
				if (_slideTime == value)
				{
					return;
				}
				_slideTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		public gameeventsStartTakedownEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
