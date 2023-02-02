using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SensesOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("isActivatorPlayer")] 
		public CBool IsActivatorPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isActivatorNPC")] 
		public CBool IsActivatorNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("attitudeGroup")] 
		public CName AttitudeGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("operationType")] 
		public CEnum<ETriggerOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<ETriggerOperationType>>();
			set => SetPropertyValue<CEnum<ETriggerOperationType>>(value);
		}

		public SensesOperationTriggerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
