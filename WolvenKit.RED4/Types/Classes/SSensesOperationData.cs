using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SSensesOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isActivatorPlayer")] 
		public CBool IsActivatorPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isActivatorNPC")] 
		public CBool IsActivatorNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("attitudeGroup")] 
		public CName AttitudeGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<ETriggerOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<ETriggerOperationType>>();
			set => SetPropertyValue<CEnum<ETriggerOperationType>>(value);
		}

		[Ordinal(4)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public SSensesOperationData()
		{
			Operation = new SBaseDeviceOperationData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
