using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedTimetableEvent : redEvent
	{
		private CHandle<DeviceTimetableEvent> _eventToForward;
		private CWeakHandle<ScriptableDeviceComponentPS> _targetPS;

		[Ordinal(0)] 
		[RED("eventToForward")] 
		public CHandle<DeviceTimetableEvent> EventToForward
		{
			get => GetProperty(ref _eventToForward);
			set => SetProperty(ref _eventToForward, value);
		}

		[Ordinal(1)] 
		[RED("targetPS")] 
		public CWeakHandle<ScriptableDeviceComponentPS> TargetPS
		{
			get => GetProperty(ref _targetPS);
			set => SetProperty(ref _targetPS, value);
		}
	}
}
