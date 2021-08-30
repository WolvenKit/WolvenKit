using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SFocusModeOperationData : RedBaseClass
	{
		private CEnum<ETriggerOperationType> _operationType;
		private CBool _isLookedAt;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<ETriggerOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(1)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetProperty(ref _isLookedAt);
			set => SetProperty(ref _isLookedAt, value);
		}

		[Ordinal(2)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		public SFocusModeOperationData()
		{
			_isLookedAt = true;
		}
	}
}
