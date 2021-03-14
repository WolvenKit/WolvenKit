using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedTimetableEvent : redEvent
	{
		private CHandle<DeviceTimetableEvent> _eventToForward;
		private wCHandle<ScriptableDeviceComponentPS> _targetPS;

		[Ordinal(0)] 
		[RED("eventToForward")] 
		public CHandle<DeviceTimetableEvent> EventToForward
		{
			get
			{
				if (_eventToForward == null)
				{
					_eventToForward = (CHandle<DeviceTimetableEvent>) CR2WTypeManager.Create("handle:DeviceTimetableEvent", "eventToForward", cr2w, this);
				}
				return _eventToForward;
			}
			set
			{
				if (_eventToForward == value)
				{
					return;
				}
				_eventToForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetPS")] 
		public wCHandle<ScriptableDeviceComponentPS> TargetPS
		{
			get
			{
				if (_targetPS == null)
				{
					_targetPS = (wCHandle<ScriptableDeviceComponentPS>) CR2WTypeManager.Create("whandle:ScriptableDeviceComponentPS", "targetPS", cr2w, this);
				}
				return _targetPS;
			}
			set
			{
				if (_targetPS == value)
				{
					return;
				}
				_targetPS = value;
				PropertySet(this);
			}
		}

		public DelayedTimetableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
