using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FactOperationTriggerData : DeviceOperationTriggerData
	{
		private CEnum<EComparisonOperator> _comparisionType;
		private CName _factName;
		private CInt32 _factValue;
		private CUInt32 _callbackID;

		[Ordinal(1)] 
		[RED("comparisionType")] 
		public CEnum<EComparisonOperator> ComparisionType
		{
			get => GetProperty(ref _comparisionType);
			set => SetProperty(ref _comparisionType, value);
		}

		[Ordinal(2)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(3)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetProperty(ref _factValue);
			set => SetProperty(ref _factValue, value);
		}

		[Ordinal(4)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}
	}
}
