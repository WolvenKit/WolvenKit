using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceTimetableEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("restorePower")] 
		public CBool RestorePower
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceTimetableEvent()
		{
			RequesterID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
