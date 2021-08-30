using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOMissionDevice : gameObject
	{
		private CName _compatibleDeviceName;
		private CBool _blockAfterOperation;
		private CName _factToUnblock;
		private CBool _isBlocked;
		private CUInt32 _factUnblockCallbackID;

		[Ordinal(40)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetProperty(ref _compatibleDeviceName);
			set => SetProperty(ref _compatibleDeviceName, value);
		}

		[Ordinal(41)] 
		[RED("blockAfterOperation")] 
		public CBool BlockAfterOperation
		{
			get => GetProperty(ref _blockAfterOperation);
			set => SetProperty(ref _blockAfterOperation, value);
		}

		[Ordinal(42)] 
		[RED("factToUnblock")] 
		public CName FactToUnblock
		{
			get => GetProperty(ref _factToUnblock);
			set => SetProperty(ref _factToUnblock, value);
		}

		[Ordinal(43)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetProperty(ref _isBlocked);
			set => SetProperty(ref _isBlocked, value);
		}

		[Ordinal(44)] 
		[RED("factUnblockCallbackID")] 
		public CUInt32 FactUnblockCallbackID
		{
			get => GetProperty(ref _factUnblockCallbackID);
			set => SetProperty(ref _factUnblockCallbackID, value);
		}

		public CPOMissionDevice()
		{
			_blockAfterOperation = true;
		}
	}
}
