using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questScan_ConditionType : questIObjectConditionType
	{
		private gameEntityReference _objectRef;
		private CEnum<questObjectScanEventType> _eventType;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questObjectScanEventType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}

		public questScan_ConditionType()
		{
			_eventType = new() { Value = Enums.questObjectScanEventType.Started };
		}
	}
}
