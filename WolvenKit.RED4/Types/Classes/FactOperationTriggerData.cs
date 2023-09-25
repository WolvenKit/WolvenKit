using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("comparisionType")] 
		public CEnum<EComparisonOperator> ComparisionType
		{
			get => GetPropertyValue<CEnum<EComparisonOperator>>();
			set => SetPropertyValue<CEnum<EComparisonOperator>>(value);
		}

		[Ordinal(2)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public FactOperationTriggerData()
		{
			FactValue = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
