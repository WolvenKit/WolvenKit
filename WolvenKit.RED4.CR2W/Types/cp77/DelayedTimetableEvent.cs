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
			get => GetProperty(ref _eventToForward);
			set => SetProperty(ref _eventToForward, value);
		}

		[Ordinal(1)] 
		[RED("targetPS")] 
		public wCHandle<ScriptableDeviceComponentPS> TargetPS
		{
			get => GetProperty(ref _targetPS);
			set => SetProperty(ref _targetPS, value);
		}

		public DelayedTimetableEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
