using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SInteractionAreaOperationData : RedBaseClass
	{
		private CBool _isActivatorPlayer;
		private CBool _isActivatorNPC;
		private CName _areaTag;
		private CEnum<gameinteractionsEInteractionEventType> _operationType;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("isActivatorPlayer")] 
		public CBool IsActivatorPlayer
		{
			get => GetProperty(ref _isActivatorPlayer);
			set => SetProperty(ref _isActivatorPlayer, value);
		}

		[Ordinal(1)] 
		[RED("isActivatorNPC")] 
		public CBool IsActivatorNPC
		{
			get => GetProperty(ref _isActivatorNPC);
			set => SetProperty(ref _isActivatorNPC, value);
		}

		[Ordinal(2)] 
		[RED("areaTag")] 
		public CName AreaTag
		{
			get => GetProperty(ref _areaTag);
			set => SetProperty(ref _areaTag, value);
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<gameinteractionsEInteractionEventType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(4)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}
	}
}
