using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FocusModeOperationTriggerData : DeviceOperationTriggerData
	{
		private CEnum<ETriggerOperationType> _operationType;
		private CBool _isLookedAt;

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<ETriggerOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(2)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetProperty(ref _isLookedAt);
			set => SetProperty(ref _isLookedAt, value);
		}
	}
}
