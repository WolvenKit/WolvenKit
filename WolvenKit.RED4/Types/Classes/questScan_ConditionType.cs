using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questScan_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questObjectScanEventType> EventType
		{
			get => GetPropertyValue<CEnum<questObjectScanEventType>>();
			set => SetPropertyValue<CEnum<questObjectScanEventType>>(value);
		}

		public questScan_ConditionType()
		{
			ObjectRef = new() { Names = new() };
			EventType = Enums.questObjectScanEventType.Started;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
