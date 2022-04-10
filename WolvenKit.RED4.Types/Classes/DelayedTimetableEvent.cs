using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedTimetableEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("eventToForward")] 
		public CHandle<DeviceTimetableEvent> EventToForward
		{
			get => GetPropertyValue<CHandle<DeviceTimetableEvent>>();
			set => SetPropertyValue<CHandle<DeviceTimetableEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("targetPS")] 
		public CWeakHandle<ScriptableDeviceComponentPS> TargetPS
		{
			get => GetPropertyValue<CWeakHandle<ScriptableDeviceComponentPS>>();
			set => SetPropertyValue<CWeakHandle<ScriptableDeviceComponentPS>>(value);
		}

		public DelayedTimetableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
